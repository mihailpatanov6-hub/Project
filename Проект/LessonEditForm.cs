using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class LessonEditForm : Form
    {
        private DatabaseHelper db;
        private Lesson lesson;

        // Конструктор для ДОБАВЛЕНИЯ нового занятия
        public LessonEditForm(DateTime date)
        {
            InitializeComponent();
            db = new DatabaseHelper();

            LoadStudents();
            LoadSubjects();

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
            Text = "Редактировать занятие";
            lblTitle.Text = "Редактировать занятие";
            btnSave.Text = "Сохранить изменения";

            FillFields();
        }

        private void LoadStudents()
        {
            cmbStudent.Items.Clear();
            var students = db.GetUniqueStudents(); // ← используем новый метод

            foreach (var s in students)
            {
                cmbStudent.Items.Add(new StudentItem { Id = s.Id, Name = s.FullName });
            }
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
        }
        private void LoadSubjects()
        {
            cmbSubject.Items.Clear();
            var subjects = db.GetUniqueSubjects();
            foreach (var subject in subjects)
            {
                cmbSubject.Items.Add(subject);
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

                // 3. Предмет
                if (cmbSubject.Items.Contains(lesson.Subject))
                {
                    cmbSubject.SelectedItem = lesson.Subject;
                }
                else
                {
                    cmbSubject.Items.Add(lesson.Subject);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem == null)
            {
                MessageBox.Show("Выберите ученика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStudent.Focus();
                return;
            }
            if (cmbSubject.SelectedItem == null)
            {
                MessageBox.Show("Выберите предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }

            try
            {
                int studentId = ((StudentItem)cmbStudent.SelectedItem).Id;
                string subject = cmbSubject.SelectedItem.ToString();
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
    }

    // Класс для элементов выпадающего списка
    public class StudentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}