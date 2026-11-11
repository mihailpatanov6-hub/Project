using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Проект.Class;
using Проект.Data;

namespace Проект
{
    public partial class Schedule_page : Form
    {
        private DatabaseHelper db;
        private DateTime selectedDate;

        // Элементы для переключения День/Неделя
        private ToggleSwitch toggleSwitch;
        private Label lblToggleText;
        private bool isWeekView = false;

        private PurpleCalendar calendar;

        public Schedule_page()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            selectedDate = DateTime.Today;

            // === НАСТРОЙКА КАСТОМНОГО КАЛЕНДАРЯ ===
            calendar = new PurpleCalendar();
            calendar.Location = new Point(20, 20);
            calendar.SetSelectedDate(selectedDate);
            pnlLeft.Controls.Add(calendar);

            calendar.DateSelected += (s, date) =>
            {
                selectedDate = date;
                UpdateDateLabel();
                LoadLessons();
            };

            // === НАСТРОЙКА ТУМБЛЕРА ===
            SetupToggleSwitch();

            // === ПОДПИСКИ НА СОБЫТИЯ ===
            btnBack.Click += (s, e) => this.Close();
            dgvLessons.CellDoubleClick += dgvLessons_CellDoubleClick;
            dgvLessons.CellMouseDown += DgvLessons_CellMouseDown;

            // Загружаем начальные данные
            UpdateDateLabel();
            LoadLessons();
        }

        // Создание и настройка тумблера
        private void SetupToggleSwitch()
        {
            toggleSwitch = new ToggleSwitch();
            toggleSwitch.Location = new Point(360, 22);
            pnlRight.Controls.Add(toggleSwitch);

            lblToggleText = new Label
            {
                Text = "День",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(124, 77, 255),
                Location = new Point(415, 25)
            };
            pnlRight.Controls.Add(lblToggleText);

            // Событие переключения
            toggleSwitch.CheckedChanged += (s, e) =>
            {
                isWeekView = toggleSwitch.Checked;
                lblToggleText.Text = isWeekView ? "Неделя" : "День";

                UpdateDateLabel();
                LoadLessons();
            };

            toggleSwitch.BringToFront();
            lblToggleText.BringToFront();
        }

        // Обновление заголовка (Дата или Неделя)
        private void UpdateDateLabel()
        {
            if (isWeekView)
            {
                int diff = (7 + (selectedDate.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime monday = selectedDate.AddDays(-diff);
                DateTime sunday = monday.AddDays(6);
                lblSelectedDate.Text = $"Неделя: {monday:dd.MM} — {sunday:dd.MM.yyyy}";
            }
            else
            {
                lblSelectedDate.Text = $"Занятия на {selectedDate:dd.MM.yyyy}";
            }
        }

        // Загрузка занятий из БД (за день или за неделю)
        private void LoadLessons()
        {
            dgvLessons.Rows.Clear();
            List<Lesson> lessons;

            if (isWeekView)
            {
                // Ищем понедельник и воскресенье текущей выбранной недели
                int diff = (7 + (selectedDate.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime monday = selectedDate.AddDays(-diff);
                DateTime sunday = monday.AddDays(6);
                lessons = db.GetLessonsByPeriod(monday, sunday);
            }
            else
            {
                lessons = db.GetLessonsByDate(selectedDate.ToString("yyyy-MM-dd"));
            }

            foreach (var l in lessons)
            {
                int rowIndex = dgvLessons.Rows.Add(
                    isWeekView ? $"{DateTime.Parse(l.LessonDate):dd.MM} {l.StartTime}" : l.StartTime + (l.EndTime != null ? " - " + l.EndTime : ""),
                    l.StudentName,
                    l.Subject,
                    l.Status
                );
                dgvLessons.Rows[rowIndex].Tag = l.Id;
            }
        }

        // === ОБРАБОТЧИКИ СОБЫТИЙ ===

        // Открытие карточки занятия по двойному клику
        private void dgvLessons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvLessons.Rows[e.RowIndex];
            if (row.Tag == null) return;

            int lessonId = Convert.ToInt32(row.Tag);
            var lesson = db.GetLessonById(lessonId);
            string studentName = row.Cells["colStudent"].Value?.ToString() ?? "";

            if (lesson != null)
            {
                using var form = new LessonCardForm(lesson, studentName);
                form.ShowDialog();
            }
        }

        // Контекстное меню для смены статуса (правый клик по колонке "Статус")
        private void DgvLessons_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0) return;
            if (dgvLessons.Columns[e.ColumnIndex].Name != "colStatus") return;

            dgvLessons.ClearSelection();
            dgvLessons.Rows[e.RowIndex].Selected = true;
            dgvLessons.CurrentCell = dgvLessons.Rows[e.RowIndex].Cells[0];

            int id = Convert.ToInt32(dgvLessons.Rows[e.RowIndex].Tag);
            string currentStatus = dgvLessons.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString() ?? "";

            ContextMenuStrip menu = new ContextMenuStrip();
            string[] statuses = { "Запланировано", "Проведено", "Отменено", "Перенесено" };

            foreach (string status in statuses)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(status);
                if (status == currentStatus)
                {
                    item.Checked = true;
                    item.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                item.Click += (s, args) =>
                {
                    db.UpdateLessonStatus(id, status);
                    dgvLessons.Rows[e.RowIndex].Cells["colStatus"].Value = status;
                };
                menu.Items.Add(item);
            }
            menu.Show(dgvLessons, dgvLessons.PointToClient(Cursor.Position));
        }

        // Добавление занятия
        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                using var form = new LessonEditForm(selectedDate);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadLessons();
            }));
        }

        // Редактирование занятия
        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null) return;
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

        // Удаление занятия
        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvLessons.CurrentRow.Tag);
            string info = $"{dgvLessons.CurrentRow.Cells["colStudent"].Value} — {dgvLessons.CurrentRow.Cells["colSubject"].Value}";

            var result = MessageBox.Show($"Удалить занятие \"{info}\"?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                db.DeleteLesson(id);
                LoadLessons();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}