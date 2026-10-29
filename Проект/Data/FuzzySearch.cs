using System;
using System.Collections.Generic;
using System.Linq;

namespace Проект.Data
{
    public static class FuzzySearch
    {
        /// <summary>
        /// Вычисляет расстояние Левенштейна между двумя строками
        /// </summary>
        public static int LevenshteinDistance(string source, string target)
        {
            if (string.IsNullOrEmpty(source)) return target?.Length ?? 0;
            if (string.IsNullOrEmpty(target)) return source.Length;

            int n = source.Length;
            int m = target.Length;
            int[,] d = new int[n + 1, m + 1];

            // Инициализация
            for (int i = 0; i <= n; i++) d[i, 0] = i;
            for (int j = 0; j <= m; j++) d[0, j] = j;

            // Вычисление
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost
                    );
                }
            }

            return d[n, m];
        }

        /// <summary>
        /// Вычисляет коэффициент похожести (0-100%)
        /// </summary>
        public static int Similarity(string source, string target)
        {
            if (string.IsNullOrEmpty(source) && string.IsNullOrEmpty(target)) return 100;
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target)) return 0;

            int distance = LevenshteinDistance(source.ToLower(), target.ToLower());
            int maxLen = Math.Max(source.Length, target.Length);
            return (int)((1.0 - (double)distance / maxLen) * 100);
        }

        /// <summary>
        /// Ищет учеников с нечётким поиском
        /// </summary>
        public static List<Student> FuzzySearchStudents(List<Student> students, string query, int threshold = 60)
        {
            if (string.IsNullOrWhiteSpace(query))
                return students;

            string queryLower = query.ToLower();
            int queryLen = queryLower.Length;

            return students
                .Select(s => new
                {
                    Student = s,
                    Score = CalculateScore(s, queryLower, queryLen, threshold)
                })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .Select(x => x.Student)
                .ToList();
        }

        private static int CalculateScore(Student s, string queryLower, int queryLen, int threshold)
        {
            var fields = new[]
            {
        s.LastName ?? "",
        s.FirstName ?? "",
        s.MiddleName ?? "",
        s.Subject ?? "",
        s.Phone ?? "",
        s.ClassLevel ?? "",
        s.Notes ?? ""
    };

            int bestScore = 0;

            foreach (var field in fields)
            {
                if (string.IsNullOrEmpty(field)) continue;
                string fieldLower = field.ToLower();

                // 1. Точное совпадение
                if (fieldLower == queryLower) return 1000;

                // 2. Начинается с запроса
                if (fieldLower.StartsWith(queryLower))
                {
                    int score = 500 + (100 - queryLen);
                    if (score > bestScore) bestScore = score;
                }

                // 3. Содержит запрос
                if (fieldLower.Contains(queryLower))
                {
                    int score = 300;
                    if (score > bestScore) bestScore = score;
                }

                // 4. Поиск по первым буквам слов (для "Гр" найдёт "Глушков")
                // Разбиваем поле на слова и проверяем начало каждого
                string[] words = fieldLower.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word.StartsWith(queryLower))
                    {
                        int score = 400 + (100 - queryLen);
                        if (score > bestScore) bestScore = score;
                    }
                }

                // 5. Нечёткий поиск — для любой длины запроса
                int similarity = Similarity(fieldLower, queryLower);
                if (similarity >= threshold)
                {
                    int score = similarity * 2;
                    if (score > bestScore) bestScore = score;
                }
            }

            return bestScore;
        }
    }
}