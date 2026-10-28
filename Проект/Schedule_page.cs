using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Проект.Data;
namespace Проект
{
    public partial class Schedule_page : Form
    {
        private DatabaseHelper db;
        private DateTime selectedDate;
        public Schedule_page()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            selectedDate = DateTime.Today;

            // Оставляем только одну подписку
            monthCalendar.DateSelected += Calendar_DateSelected;

            btnBack.Click += (s, e) => this.Close();
            dgvLessons.CellDoubleClick += dgvLessons_CellDoubleClick;

            UpdateDateLabel(selectedDate); // Обновляем заголовок при старте
            LoadLessons();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start.Date;
            UpdateDateLabel(selectedDate); // <-- ОБНОВЛЯЕМ ЗАГОЛОВОК
            LoadLessons();
        }
        private void LoadLessons()
        {
            dgvLessons.Rows.Clear();
            string dateStr = selectedDate.ToString("yyyy-MM-dd");

            var lessons = db.GetLessonsByDate(dateStr);

            foreach (var l in lessons)
            {
                int rowIndex = dgvLessons.Rows.Add(
                    l.StartTime + (l.EndTime != null ? " - " + l.EndTime : ""),
                    l.StudentName,
                    l.Subject,
                    l.Status
                );
                dgvLessons.Rows[rowIndex].Tag = l.Id;
            }
        }
        private void UpdateDateLabel(DateTime date)
        {
            lblSelectedDate.Text = $"Занятия на {date:dd.MM.yyyy}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            // Откладываем открытие, чтобы кнопка успела "отпуститься"
            this.BeginInvoke(new Action(() =>
            {
                using var form = new LessonEditForm(selectedDate);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadLessons();
            }));
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null)
            {
                MessageBox.Show("Выберите занятие в таблице", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvLessons.CurrentRow.Tag);
            var lesson = db.GetLessonById(id);
            if (lesson == null) return;

            this.BeginInvoke(new Action(() =>
            {
                using var form = new LessonEditForm(lesson);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadLessons();
            }));
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null)
            {
                MessageBox.Show("Выберите занятие в таблице", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvLessons.CurrentRow.Tag);
            string info = $"{dgvLessons.CurrentRow.Cells["colStudent"].Value} — {dgvLessons.CurrentRow.Cells["colSubject"].Value}";

            var result = MessageBox.Show($"Удалить занятие \"{info}\"?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.DeleteLesson(id);
                LoadLessons();
            }
        }
        private void dgvLessons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Игнорируем клики по заголовкам
            if (e.RowIndex < 0) return;

            var row = dgvLessons.Rows[e.RowIndex];
            if (row.Tag == null) return;

            // Получаем ID занятия
            int lessonId = Convert.ToInt32(row.Tag);

            // Загружаем полную информацию из БД
            var lesson = db.GetLessonById(lessonId);

            // Имя ученика уже есть в таблице (в колонке colStudent)
            string studentName = row.Cells["colStudent"].Value?.ToString() ?? "";

            if (lesson != null)
            {
                // Открываем карточку занятия
                using var form = new LessonCardForm(lesson, studentName);
                form.ShowDialog();
            }
        }
    }
}