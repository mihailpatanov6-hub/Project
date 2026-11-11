using System;
using System.Drawing;
using System.Windows.Forms;
using Проект.Class;
using Проект.Data;

namespace Проект
{
    public partial class Summary_page : Form
    {
        private DatabaseHelper db;
        private Button activeButton;

        // Переменные для работы с датами и календарем
        private PurpleCalendar popupCalendar;
        private DateTime currentFrom = DateTime.Today;
        private DateTime currentTo = DateTime.Today;
        private bool isSelectingFrom = true;

        public Summary_page()
        {
            InitializeComponent();
            db = new DatabaseHelper();

            // 1. Создаем выпадающий календарь (прячем его)
            popupCalendar = new PurpleCalendar();
            popupCalendar.Size = new Size(320, 340);
            popupCalendar.Visible = false;
            popupCalendar.BorderStyle = BorderStyle.FixedSingle;
            popupCalendar.DateSelected += PopupCalendar_DateSelected;

            this.Controls.Add(popupCalendar);
            popupCalendar.BringToFront();

            // 2. Подписки на кнопки фильтров
            btnCurrentMonth.Click += (s, e) => SetFilter("Month");
            btnLastMonth.Click += (s, e) => SetFilter("LastMonth");
            btnCurrentYear.Click += (s, e) => SetFilter("Year");
            btnAllTime.Click += (s, e) => SetFilter("All");

            // 3. Подписки на кнопки выбора дат
            btnDateFrom.Click += (s, e) => ShowCalendarPopup(true);
            btnDateTo.Click += (s, e) => ShowCalendarPopup(false);

            // 4. Ховеры для кнопок-таблеток
            foreach (var b in new[] { btnCurrentMonth, btnLastMonth, btnCurrentYear, btnAllTime })
            {
                b.MouseEnter += (s, e) => { if (b != activeButton) b.BackColor = Color.FromArgb(237, 228, 255); };
                b.MouseLeave += (s, e) => { if (b != activeButton) b.BackColor = Color.White; };
            }

            // 5. Двойной клик по таблице для открытия карточки ученика
            dgvStats.CellDoubleClick += dgvStats_CellDoubleClick;

            // 6. Скрываем календарь при клике в любое место формы
            this.Click += (s, e) => { if (popupCalendar.Visible) popupCalendar.Visible = false; };

            // Кнопка Назад
            btnBack.MouseEnter += (s, e) => btnBack.ForeColor = Color.FromArgb(94, 53, 177);
            btnBack.MouseLeave += (s, e) => btnBack.ForeColor = Color.FromArgb(124, 77, 255);

            // Устанавливаем фильтр по умолчанию (Этот месяц)
            SetFilter("Month");
        }

        // === ЛОГИКА ВЫПАДАЮЩЕГО КАЛЕНДАРЯ ===
        private void ShowCalendarPopup(bool isFrom)
        {
            if (popupCalendar.Visible && isSelectingFrom == isFrom)
            {
                popupCalendar.Visible = false;
                return;
            }

            isSelectingFrom = isFrom;
            popupCalendar.SetSelectedDate(isFrom ? currentFrom : currentTo);

            var activeBtn = isFrom ? btnDateFrom : btnDateTo;
            Point p = this.PointToClient(activeBtn.PointToScreen(new Point(0, activeBtn.Height)));

            if (p.X + popupCalendar.Width > this.ClientSize.Width)
                p.X = this.ClientSize.Width - popupCalendar.Width - 10;

            popupCalendar.Location = p;
            popupCalendar.Visible = true;
            popupCalendar.BringToFront();
        }

        private void PopupCalendar_DateSelected(object sender, DateTime date)
        {
            if (isSelectingFrom)
            {
                currentFrom = date;
                btnDateFrom.Text = currentFrom.ToString("dd.MM.yyyy");
            }
            else
            {
                currentTo = date;
                btnDateTo.Text = currentTo.ToString("dd.MM.yyyy");
            }

            popupCalendar.Visible = false;
            ResetFilterButtons();
            LoadData(currentFrom, currentTo);
        }

        // === ЛОГИКА ФИЛЬТРОВ ===
        private void SetFilter(string filterType)
        {
            switch (filterType)
            {
                case "Month":
                    currentFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    currentTo = currentFrom.AddMonths(1).AddDays(-1);
                    activeButton = btnCurrentMonth;
                    break;
                case "LastMonth":
                    currentFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                    currentTo = currentFrom.AddMonths(1).AddDays(-1);
                    activeButton = btnLastMonth;
                    break;
                case "Year":
                    currentFrom = new DateTime(DateTime.Today.Year, 1, 1);
                    currentTo = new DateTime(DateTime.Today.Year, 12, 31);
                    activeButton = btnCurrentYear;
                    break;
                case "All":
                    currentFrom = db.GetFirstLessonDate();
                    currentTo = DateTime.Today;
                    activeButton = btnAllTime;
                    break;
            }

            btnDateFrom.Text = currentFrom.ToString("dd.MM.yyyy");
            btnDateTo.Text = currentTo.ToString("dd.MM.yyyy");

            HighlightActiveButton();
            LoadData(currentFrom, currentTo);
        }

        private void HighlightActiveButton()
        {
            foreach (var btn in new[] { btnCurrentMonth, btnLastMonth, btnCurrentYear, btnAllTime })
            {
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(124, 77, 255);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(94, 53, 177);
                    btn.FlatAppearance.BorderSize = 1;
                }
            }
        }

        private void ResetFilterButtons()
        {
            activeButton = null;
            foreach (var btn in new[] { btnCurrentMonth, btnLastMonth, btnCurrentYear, btnAllTime })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(94, 53, 177);
                btn.FlatAppearance.BorderSize = 1;
            }
        }

        // === ЗАГРУЗКА ДАННЫХ ===
        private void LoadData(DateTime from, DateTime to)
        {
            var data = db.GetSummaryData(from, to);

            // 1. Заполняем карточки
            lblLessonsValue.Text = data.TotalLessons.ToString();
            lblHoursValue.Text = $"{data.TotalHours} ч.";
            lblMissedValue.Text = data.TotalMissed.ToString();

            if (data.ActiveDayCount > 0)
            {
                lblActiveDayValue.Text = data.ActiveDay;
                lblActiveDaySub.Text = $"{data.ActiveDayCount} зан.";
            }
            else
            {
                lblActiveDayValue.Text = "—";
                lblActiveDaySub.Text = "";
            }

            // 2. Заполняем таблицу
            dgvStats.Rows.Clear();
            foreach (var stat in data.StudentStats)
            {
                int rowIndex = dgvStats.Rows.Add(stat.Name, stat.Done, stat.Missed, $"{stat.Hours} ч.");
                dgvStats.Rows[rowIndex].Tag = stat.Id;
            }
        }

        // === ОТКРЫТИЕ КАРТОЧКИ УЧЕНИКА ===
        private void dgvStats_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvStats.Rows[e.RowIndex];
            if (row.Tag == null) return;

            int studentId = Convert.ToInt32(row.Tag);
            var student = db.GetStudentById(studentId);

            if (student != null)
            {
                using var form = new StudentCardForm(student);
                form.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}