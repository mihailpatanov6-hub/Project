using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class LessonEditForm : Form
    {
        private DatabaseHelper db;
        private Lesson lesson;
        private bool isEditing = false; // Флаг, чтобы не сбрасывать предмет при загрузке

        // Конструктор для ДОБАВЛЕНИЯ нового занятия
        public LessonEditForm(DateTime date)
        {
            InitializeComponent();
            db = new DatabaseHelper();

            LoadStudents();

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }
            dtpDate.Value = date;

            // Подписки на ховеры для кнопок
            btnSave.MouseEnter += (s, e) => btnSave.BackColor = Color.FromArgb(94, 53, 177);
            btnSave.MouseLeave += (s, e) => btnSave.BackColor = Color.FromArgb(124, 77, 255);
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(237, 228, 255);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.White;
        }

        // Конструктор для РЕДАКТИРОВАНИЯ существующего занятия
        public LessonEditForm(Lesson existingLesson) : this(DateTime.Today)
        {
            lesson = existingLesson;
            isEditing = true;
            Text = "Редактировать занятие";
            lblTitle.Text = "Редактировать занятие";
            btnSave.Text = "Сохранить изменения";

            FillFields();
            isEditing = false;
        }

        // ... (Метод LoadStudents оставляем без изменений, как в прошлом ответе) ...
        private void LoadStudents()
        {
            cmbStudent.Items.Clear();
            var students = db.GetAllStudents();

            var nameCounts = new Dictionary<string, int>();
            var phoneCounts = new Dictionary<string, int>();

            foreach (var s in students)
            {
                string name = s.FullName;
                string phone = s.Phone ?? "";
                if (!nameCounts.ContainsKey(name)) nameCounts[name] = 0;
                nameCounts[name]++;
                if (!string.IsNullOrEmpty(phone))
                {
                    if (!phoneCounts.ContainsKey(phone)) phoneCounts[phone] = 0;
                    phoneCounts[phone]++;
                }
            }

            foreach (var s in students)
            {
                string displayName = s.FullName;
                if (nameCounts[s.FullName] > 1)
                {
                    if (!string.IsNullOrWhiteSpace(s.Phone))
                    {
                        displayName += $" — {s.Phone}";
                        if (phoneCounts[s.Phone] > 1) displayName += $" (ID: {s.Id})";
                    }
                    else
                    {
                        displayName += $" (ID: {s.Id})";
                    }
                }
                cmbStudent.Items.Add(new StudentItem { Id = s.Id, Name = displayName });
            }

            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
        }

        // НОВЫЙ МЕТОД: Срабатывает при выборе ученика
        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если мы в процессе загрузки данных для редактирования, не трогаем предметы
            if (isEditing) return;

            cmbSubject.Items.Clear();
            cmbSubject.Text = "";

            if (cmbStudent.SelectedItem is StudentItem selectedStudent)
            {
                // Ищем ученика в базе по ID, чтобы получить его предметы
                var student = db.GetStudentById(selectedStudent.Id);

                if (student != null && !string.IsNullOrWhiteSpace(student.Subject))
                {
                    // Разбиваем строку "Математика, Физика" на отдельные предметы
                    string[] subjects = student.Subject.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string subj in subjects)
                    {
                        cmbSubject.Items.Add(subj.Trim());
                    }

                    // Автоматически выбираем первый предмет
                    if (cmbSubject.Items.Count > 0)
                    {
                        cmbSubject.SelectedIndex = 0;
                    }
                }
            }
        }

        private void FillFields()
        {
            if (lesson != null)
            {
                // 1. Дата
                dtpDate.Value = DateTime.ParseExact(lesson.LessonDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                // 2. Ученик (надежный поиск)
                foreach (StudentItem item in cmbStudent.Items)
                {
                    if (item.Id == lesson.StudentId)
                    {
                        cmbStudent.SelectedItem = item;
                        break;
                    }
                }

                // 3. ПРЕДМЕТ
                // Сначала принудительно загружаем ВСЕ предметы этого ученика в список
                cmbSubject.Items.Clear();
                var student = db.GetStudentById(lesson.StudentId);
                if (student != null && !string.IsNullOrWhiteSpace(student.Subject))
                {
                    string[] subjects = student.Subject.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string subj in subjects)
                    {
                        cmbSubject.Items.Add(subj.Trim());
                    }
                }

                // Теперь выбираем тот предмет, который был сохранен в занятии.
                // Если его нет в списке (например, ученика перевели на другой предмет), добавляем его принудительно.
                if (!string.IsNullOrEmpty(lesson.Subject))
                {
                    if (!cmbSubject.Items.Contains(lesson.Subject))
                    {
                        cmbSubject.Items.Add(lesson.Subject);
                    }
                    cmbSubject.SelectedItem = lesson.Subject;
                }

                // 4. Время начала
                if (TimeSpan.TryParse(lesson.StartTime, out TimeSpan startTs))
                {
                    dtpStartTime.Value = DateTime.Today.Add(startTs);
                }

                // 5. Время окончания
                if (!string.IsNullOrEmpty(lesson.EndTime) && TimeSpan.TryParse(lesson.EndTime, out TimeSpan endTs))
                {
                    dtpEndTime.Value = DateTime.Today.Add(endTs);
                }

                // 6. Статус и заметки
                if (cmbStatus.Items.Contains(lesson.Status))
                {
                    cmbStatus.SelectedItem = lesson.Status;
                }
                else if (cmbStatus.Items.Count > 0)
                {
                    cmbStatus.SelectedIndex = 0;
                }

                txtNotes.Text = lesson.Notes;
            }
        }

        // ... (Метод btnSave_Click оставляем без изменений) ...
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem == null)
            {
                MessageBox.Show("Выберите ученика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStudent.Focus();
                return;
            }
            if (cmbSubject.SelectedItem == null && string.IsNullOrWhiteSpace(cmbSubject.Text))
            {
                MessageBox.Show("Выберите или введите предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }

            try
            {
                int studentId = ((StudentItem)cmbStudent.SelectedItem).Id;
                string subject = cmbSubject.Text.Trim(); // Берем то, что выбрано или введено
                string date = dtpDate.Value.ToString("yyyy-MM-dd");
                string startTime = dtpStartTime.Value.ToString("HH:mm");
                string endTime = dtpEndTime.Value.ToString("HH:mm");
                string status = cmbStatus.Text;

                if (lesson == null)
                {
                    db.AddLesson(studentId, subject, date, startTime, endTime, status, txtNotes.Text.Trim());
                    MessageBox.Show("Занятие добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.UpdateLesson(lesson.Id, studentId, subject, date, startTime, endTime, status, txtNotes.Text.Trim());
                    MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LessonEditForm_Load(object sender, EventArgs e)
        {

        }
    }

    // Класс для элементов выпадающего списка
    public class StudentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}