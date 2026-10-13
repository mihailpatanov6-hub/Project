using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace Проект.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;
        public DatabaseHelper()
        {
            // Путь к БД в папке с программой (не в bin/Debug)
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            _connectionString = $"Data Source={appPath}tutor_app.db";
        }

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        public void InitializeDatabase()
        {
            using var connection = GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Students (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    LastName TEXT NOT NULL,
                    FirstName TEXT NOT NULL,
                    MiddleName TEXT,
                    Phone TEXT,
                    Subject TEXT NOT NULL,
                    ClassLevel TEXT,
                    Notes TEXT,
                    CreatedAt TEXT DEFAULT (datetime('now')),
                    UpdatedAt TEXT DEFAULT (datetime('now'))
                );

                CREATE TABLE IF NOT EXISTS Lessons (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER NOT NULL,
                    Subject TEXT NOT NULL,
                    LessonDate TEXT NOT NULL,
                    StartTime TEXT NOT NULL,
                    EndTime TEXT,
                    Status TEXT DEFAULT 'Запланировано',
                    Notes TEXT,
                    CreatedAt TEXT DEFAULT (datetime('now')),
                    UpdatedAt TEXT DEFAULT (datetime('now')),
                    FOREIGN KEY (StudentId) REFERENCES Students(Id) ON DELETE CASCADE
                );

                CREATE INDEX IF NOT EXISTS idx_students_lastname ON Students(LastName);
                CREATE INDEX IF NOT EXISTS idx_students_fullname ON Students(LastName, FirstName, MiddleName);
                CREATE INDEX IF NOT EXISTS idx_lessons_student ON Lessons(StudentId);
                CREATE INDEX IF NOT EXISTS idx_lessons_date ON Lessons(LessonDate);
                CREATE INDEX IF NOT EXISTS idx_lessons_status ON Lessons(Status);
                CREATE UNIQUE INDEX IF NOT EXISTS idx_lessons_unique_time ON Lessons(StudentId, LessonDate, StartTime);";
            cmd.ExecuteNonQuery();
        }

        // ========== СТУДЕНТЫ ==========

        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, LastName, FirstName, MiddleName, Phone, Subject, ClassLevel, Notes FROM Students ORDER BY LastName, FirstName";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleName = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Subject = reader.GetString(5),
                    ClassLevel = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Notes = reader.IsDBNull(7) ? null : reader.GetString(7)
                });
            }
            return list;
        }

        public Student GetStudentById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, LastName, FirstName, MiddleName, Phone, Subject, ClassLevel, Notes FROM Students WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Student
                {
                    Id = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleName = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Subject = reader.GetString(5),
                    ClassLevel = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Notes = reader.IsDBNull(7) ? null : reader.GetString(7)
                };
            }
            return null;
        }

        public List<Student> SearchByLastName(string query)
        {
            var list = new List<Student>();
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, LastName, FirstName, MiddleName, Phone, Subject, ClassLevel, Notes FROM Students WHERE LastName LIKE $q OR FirstName LIKE $q OR MiddleName LIKE $q ORDER BY LastName";
            cmd.Parameters.AddWithValue("$q", $"%{query}%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleName = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Subject = reader.GetString(5),
                    ClassLevel = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Notes = reader.IsDBNull(7) ? null : reader.GetString(7)
                });
            }
            return list;
        }

        public int AddStudent(string lastName, string firstName, string middleName,
                              string phone, string subject, string classLevel, string notes)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Students (LastName, FirstName, MiddleName, Phone, Subject, ClassLevel, Notes)
                VALUES ($ln, $fn, $mn, $ph, $sub, $cl, $nt);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("$ln", lastName);
            cmd.Parameters.AddWithValue("$fn", firstName);
            cmd.Parameters.AddWithValue("$mn", middleName);
            cmd.Parameters.AddWithValue("$ph", phone);
            cmd.Parameters.AddWithValue("$sub", subject);
            cmd.Parameters.AddWithValue("$cl", classLevel);
            cmd.Parameters.AddWithValue("$nt", notes);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void UpdateStudent(int id, string lastName, string firstName, string middleName,
                                  string phone, string subject, string classLevel, string notes)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Students SET LastName=$ln, FirstName=$fn, MiddleName=$mn,
                    Phone=$ph, Subject=$sub, ClassLevel=$cl, Notes=$nt,
                    UpdatedAt=datetime('now') WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.Parameters.AddWithValue("$ln", lastName);
            cmd.Parameters.AddWithValue("$fn", firstName);
            cmd.Parameters.AddWithValue("$mn", middleName);
            cmd.Parameters.AddWithValue("$ph", phone);
            cmd.Parameters.AddWithValue("$sub", subject);
            cmd.Parameters.AddWithValue("$cl", classLevel);
            cmd.Parameters.AddWithValue("$nt", notes);
            cmd.ExecuteNonQuery();
        }

        public void DeleteStudent(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Students WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }

        // ========== ЗАНЯТИЯ ==========

        public List<Lesson> GetLessonsByStudent(int studentId)
        {
            var list = new List<Lesson>();
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, StudentId, Subject, LessonDate, StartTime, EndTime, Status, Notes FROM Lessons WHERE StudentId = $sid ORDER BY LessonDate, StartTime";
            cmd.Parameters.AddWithValue("$sid", studentId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Lesson
                {
                    Id = reader.GetInt32(0),
                    StudentId = reader.GetInt32(1),
                    Subject = reader.GetString(2),
                    LessonDate = reader.GetString(3),
                    StartTime = reader.GetString(4),
                    EndTime = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Status = reader.GetString(6),
                    Notes = reader.IsDBNull(7) ? null : reader.GetString(7)
                });
            }
            return list;
        }

        public List<Lesson> GetLessonsByPeriod(DateTime from, DateTime to)
        {
            var list = new List<Lesson>();
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT l.Id, l.StudentId, s.LastName, s.FirstName, l.Subject, 
                       l.LessonDate, l.StartTime, l.EndTime, l.Status, l.Notes
                FROM Lessons l
                JOIN Students s ON l.StudentId = s.Id
                WHERE l.LessonDate BETWEEN $from AND $to
                ORDER BY l.LessonDate, l.StartTime";
            cmd.Parameters.AddWithValue("$from", from.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("$to", to.ToString("yyyy-MM-dd"));
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Lesson
                {
                    Id = reader.GetInt32(0),
                    StudentId = reader.GetInt32(1),
                    StudentName = $"{reader.GetString(2)} {reader.GetString(3)}",
                    Subject = reader.GetString(4),
                    LessonDate = reader.GetString(5),
                    StartTime = reader.GetString(6),
                    EndTime = reader.IsDBNull(7) ? null : reader.GetString(7),
                    Status = reader.GetString(8),
                    Notes = reader.IsDBNull(9) ? null : reader.GetString(9)
                });
            }
            return list;
        }

        public Lesson GetLessonById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, StudentId, Subject, LessonDate, StartTime, EndTime, Status, Notes FROM Lessons WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Lesson
                {
                    Id = reader.GetInt32(0),
                    StudentId = reader.GetInt32(1),
                    Subject = reader.GetString(2),
                    LessonDate = reader.GetString(3),
                    StartTime = reader.GetString(4),
                    EndTime = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Status = reader.GetString(6),
                    Notes = reader.IsDBNull(7) ? null : reader.GetString(7)
                };
            }
            return null;
        }

        public int AddLesson(int studentId, string subject, string lessonDate,
                             string startTime, string endTime, string status, string notes)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Lessons (StudentId, Subject, LessonDate, StartTime, EndTime, Status, Notes)
                VALUES ($sid, $sub, $ld, $st, $et, $stat, $nt);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("$sid", studentId);
            cmd.Parameters.AddWithValue("$sub", subject);
            cmd.Parameters.AddWithValue("$ld", lessonDate);
            cmd.Parameters.AddWithValue("$st", startTime);
            cmd.Parameters.AddWithValue("$et", (object?)endTime ?? DBNull.Value);
            cmd.Parameters.AddWithValue("$stat", status);
            cmd.Parameters.AddWithValue("$nt", notes);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void UpdateLesson(int id, int studentId, string subject, string lessonDate,
                                 string startTime, string endTime, string status, string notes)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Lessons SET StudentId=$sid, Subject=$sub, LessonDate=$ld,
                    StartTime=$st, EndTime=$et, Status=$stat, Notes=$nt,
                    UpdatedAt=datetime('now') WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.Parameters.AddWithValue("$sid", studentId);
            cmd.Parameters.AddWithValue("$sub", subject);
            cmd.Parameters.AddWithValue("$ld", lessonDate);
            cmd.Parameters.AddWithValue("$st", startTime);
            cmd.Parameters.AddWithValue("$et", (object?)endTime ?? DBNull.Value);
            cmd.Parameters.AddWithValue("$stat", status);
            cmd.Parameters.AddWithValue("$nt", notes);
            cmd.ExecuteNonQuery();
        }

        public void DeleteLesson(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Lessons WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }

        public void UpdateLessonStatus(int id, string status)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Lessons SET Status = $stat, UpdatedAt = datetime('now') WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.Parameters.AddWithValue("$stat", status);
            cmd.ExecuteNonQuery();
        }

        // Сводка: количество занятий и часов за период
        public (int count, double hours) GetSummary(int studentId, DateTime from, DateTime to)
        {
            using var connection = GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT COUNT(*) as cnt,
                       COALESCE(SUM(
                           (CAST(substr(EndTime,1,2) AS INTEGER) * 60 + CAST(substr(EndTime,4,2) AS INTEGER)) -
                           (CAST(substr(StartTime,1,2) AS INTEGER) * 60 + CAST(substr(StartTime,4,2) AS INTEGER))
                       ), 0) as total_minutes
                FROM Lessons
                WHERE StudentId = $sid AND LessonDate BETWEEN $from AND $to AND Status = 'Проведено'";
            cmd.Parameters.AddWithValue("$sid", studentId);
            cmd.Parameters.AddWithValue("$from", from.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("$to", to.ToString("yyyy-MM-dd"));
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                double minutes = reader.GetDouble(1);
                return (count, minutes / 60);
            }
            return (0, 0);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string ClassLevel { get; set; }
        public string Notes { get; set; }

        public string FullName =>
            $"{LastName} {FirstName}{(string.IsNullOrEmpty(MiddleName) ? "" : " " + MiddleName)}".Trim();
    }

    public class Lesson
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public string LessonDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}