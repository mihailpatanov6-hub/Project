using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Проект.Class
{
    public class PurpleCalendar : Panel
    {
        private DateTime currentDate = DateTime.Today;
        private DateTime selectedDate = DateTime.Today;

        private Label lblMonthYear;
        private Button btnPrev;
        private Button btnNext;

        private Panel pnlViewport;
        private Panel pnlTrack;

        // Сетки для ДНЕЙ
        private TableLayoutPanel gridDatesCurrent;
        private TableLayoutPanel gridDatesNext;

        // Сетка для МЕСЯЦЕВ
        private TableLayoutPanel gridMonths;
        private bool isMonthView = false;

        private Timer animTimer;
        private int direction = 0;

        private const int GridWidth = 300;
        private const int GridHeight = 260;

        public event EventHandler<DateTime> DateSelected;
        public DateTime SelectedDate => selectedDate;

        public PurpleCalendar()
        {
            Size = new Size(320, 340);
            BackColor = Color.White;
            Padding = new Padding(10);
            DoubleBuffered = true;

            animTimer = new Timer { Interval = 15 };
            animTimer.Tick += AnimTimer_Tick;

            // 1. Шапка
            Panel pnlHeader = new Panel { Dock = DockStyle.Top, Height = 40, BackColor = Color.White };

            btnPrev = new Button
            {
                Text = "<",
                Dock = DockStyle.Left,
                Width = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(124, 77, 255),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TabStop = false
            };
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.Click += (s, e) => HandleNavigation(-1);

            btnNext = new Button
            {
                Text = ">",
                Dock = DockStyle.Right,
                Width = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(124, 77, 255),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TabStop = false
            };
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Click += (s, e) => HandleNavigation(1);

            lblMonthYear = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(94, 53, 177),
                Cursor = Cursors.Hand, // Делаем курсор "рукой"
                Text = "НОЯБРЬ 2026"
            };
            // КЛИК ПО ЗАГОЛОВКУ - ПЕРЕКЛЮЧАЕТ РЕЖИМ
            lblMonthYear.Click += (s, e) => ToggleView();

            pnlHeader.Controls.Add(lblMonthYear);
            pnlHeader.Controls.Add(btnPrev);
            pnlHeader.Controls.Add(btnNext);

            // 2. Дни недели
            TableLayoutPanel gridDays = new TableLayoutPanel { Dock = DockStyle.Top, Height = 30, ColumnCount = 7, RowCount = 1, BackColor = Color.White };
            string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
            for (int i = 0; i < 7; i++)
            {
                gridDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
                gridDays.Controls.Add(new Label
                {
                    Text = days[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.Gray
                }, i, 0);
            }

            // 3. Контейнер для слайдера
            pnlViewport = new BufferedPanel { Dock = DockStyle.Fill, BackColor = Color.White };
            pnlTrack = new BufferedPanel { Size = new Size(GridWidth * 2, GridHeight), Location = new Point(0, 0) };

            gridDatesCurrent = CreateGrid();
            gridDatesNext = CreateGrid();
            gridMonths = CreateGrid(); // Сетка для месяцев

            gridDatesCurrent.Location = new Point(0, 0);
            gridDatesNext.Location = new Point(GridWidth, 0);
            gridMonths.Location = new Point(0, 0);

            pnlTrack.Controls.Add(gridDatesNext);
            pnlTrack.Controls.Add(gridDatesCurrent);
            pnlViewport.Controls.Add(gridMonths); // Сетку месяцев кладем прямо в окно поверх трека
            pnlViewport.Controls.Add(pnlTrack);
            gridMonths.Visible = false;

            // Добавляем в обратном порядке, чтобы сетка месяцев была сверху
            Controls.Add(pnlViewport);
            Controls.Add(gridDays);
            Controls.Add(pnlHeader);

            InitGridButtons(gridDatesCurrent);
            InitGridButtons(gridDatesNext);
            InitMonthButtons(gridMonths);

            RenderGrid(gridDatesCurrent, currentDate);
            RenderGrid(gridDatesNext, currentDate.AddMonths(1));
        }

        private TableLayoutPanel CreateGrid()
        {
            var grid = new BufferedTableLayoutPanel
            {
                ColumnCount = 7,
                RowCount = 6,
                BackColor = Color.White,
                Size = new Size(GridWidth, GridHeight)
            };
            for (int i = 0; i < 7; i++) grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            for (int i = 0; i < 6; i++) grid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            return grid;
        }

        // === ЛОГИКА ПЕРЕКЛЮЧЕНИЯ РЕЖИМОВ ===
        private void ToggleView()
        {
            if (animTimer.Enabled) return;

            isMonthView = !isMonthView;

            if (isMonthView)
            {
                // Показываем месяцы
                pnlTrack.Visible = false;
                gridMonths.Visible = true;
                RenderMonths(); // Обновляем список месяцев
                lblMonthYear.Text = currentDate.Year.ToString(); // Показываем только год
            }
            else
            {
                // Показываем дни
                pnlTrack.Visible = true;
                gridMonths.Visible = false;
                lblMonthYear.Text = currentDate.ToString("MMMM yyyy").ToUpper();
                RenderGrid(gridDatesCurrent, currentDate);
                RenderGrid(gridDatesNext, currentDate.AddMonths(1));
            }
        }

        // === ЛОГИКА СТРЕЛОК ===
        private void HandleNavigation(int dir)
        {
            if (isMonthView)
            {
                // Если мы в режиме месяцев, стрелки меняют ГОД
                currentDate = currentDate.AddYears(dir);
                lblMonthYear.Text = currentDate.Year.ToString();
                RenderMonths();
            }
            else
            {
                // Если в режиме дней, стрелки меняют МЕСЯЦ (запускаем анимацию)
                StartSlide(dir);
            }
        }

        // === СОЗДАНИЕ СЕТКИ МЕСЯЦЕВ ===
        private void InitMonthButtons(TableLayoutPanel grid)
        {
            grid.Controls.Clear();

            // Очищаем старые настройки и задаем 3 колонки и 4 строки
            grid.ColumnStyles.Clear();
            grid.RowStyles.Clear();
            grid.ColumnCount = 3;
            grid.RowCount = 4;

            for (int i = 0; i < 3; i++) grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            for (int i = 0; i < 4; i++) grid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            string[] months = { "Янв", "Фев", "Мар", "Апр", "Май", "Июн", "Июл", "Авг", "Сен", "Окт", "Ноя", "Дек" };

            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button
                {
                    Text = months[i],
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold), // Чуть увеличили шрифт
                    Cursor = Cursors.Hand,
                    Margin = new Padding(5),
                    Tag = i
                };
                btn.FlatAppearance.BorderSize = 0;

                btn.MouseEnter += (s, e) => { if ((int)((Button)s).Tag != currentDate.Month - 1) ((Button)s).BackColor = Color.FromArgb(237, 228, 255); };
                btn.MouseLeave += (s, e) => { if ((int)((Button)s).Tag != currentDate.Month - 1) ((Button)s).BackColor = Color.White; };

                btn.Click += (s, e) =>
                {
                    int monthIndex = (int)((Button)s).Tag;
                    currentDate = new DateTime(currentDate.Year, monthIndex + 1, 1);

                    isMonthView = false;
                    pnlTrack.Visible = true;
                    gridMonths.Visible = false;

                    lblMonthYear.Text = currentDate.ToString("MMMM yyyy").ToUpper();
                    RenderGrid(gridDatesCurrent, currentDate);
                    RenderGrid(gridDatesNext, currentDate.AddMonths(1));
                };

                grid.Controls.Add(btn, i % 3, i / 3); // 3 колонки
            }
        }

        private void RenderMonths()
        {
            if (gridMonths.Controls.Count < 12) return;
            for (int i = 0; i < 12; i++)
            {
                Button btn = (Button)gridMonths.Controls[i];
                if (i == currentDate.Month - 1)
                {
                    btn.BackColor = Color.FromArgb(124, 77, 255);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(60, 40, 100);
                }
            }
        }

        // === СУЩЕСТВУЮЩАЯ ЛОГИКА ДНЕЙ ===
        private void InitGridButtons(TableLayoutPanel grid)
        {
            grid.Controls.Clear();
            for (int i = 0; i < 42; i++)
            {
                Button btn = new Button
                {
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(1)
                };
                btn.FlatAppearance.BorderSize = 0;

                btn.MouseEnter += (s, e) =>
                {
                    var b = (Button)s;
                    if (b.Tag is DateTime d && d.Date != selectedDate.Date)
                        b.BackColor = Color.FromArgb(237, 228, 255);
                };
                btn.MouseLeave += (s, e) =>
                {
                    var b = (Button)s;
                    if (b.Tag is DateTime d && d.Date != selectedDate.Date)
                        b.BackColor = Color.White;
                };

                btn.Click += (s, e) =>
                {
                    var b = (Button)s;
                    if (b.Tag is DateTime clickedDate)
                    {
                        selectedDate = clickedDate;
                        DateSelected?.Invoke(this, selectedDate);
                        RepaintColors();
                    }
                };

                grid.Controls.Add(btn);
            }
        }

        private void RenderGrid(TableLayoutPanel grid, DateTime dateToRender)
        {
            grid.Tag = dateToRender;
            DateTime firstDayOfMonth = new DateTime(dateToRender.Year, dateToRender.Month, 1);
            int offset = ((int)firstDayOfMonth.DayOfWeek + 6) % 7;
            DateTime startDate = firstDayOfMonth.AddDays(-offset);

            for (int i = 0; i < 42; i++)
            {
                Button btn = (Button)grid.Controls[i];
                DateTime date = startDate.AddDays(i);
                btn.Text = date.Day.ToString();
                btn.Tag = date;
            }
            RepaintColors();
        }

        private void RepaintColors()
        {
            RepaintGridColors(gridDatesCurrent);
            RepaintGridColors(gridDatesNext);
        }

        private void RepaintGridColors(TableLayoutPanel grid)
        {
            if (grid.Controls.Count < 42 || !(grid.Tag is DateTime gridMonth)) return;

            for (int i = 0; i < 42; i++)
            {
                Button btn = (Button)grid.Controls[i];
                if (!(btn.Tag is DateTime date)) continue;

                bool isCurrentMonth = date.Month == gridMonth.Month;

                if (date.Date == selectedDate.Date)
                {
                    btn.BackColor = Color.FromArgb(124, 77, 255);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.White;
                    if (!isCurrentMonth)
                        btn.ForeColor = Color.FromArgb(214, 198, 245);
                    else if (date.Date == DateTime.Today.Date)
                    {
                        btn.ForeColor = Color.FromArgb(124, 77, 255);
                        btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    }
                    else
                        btn.ForeColor = Color.FromArgb(60, 40, 100);
                }
            }
        }

        public void SetSelectedDate(DateTime date)
        {
            selectedDate = date;
            currentDate = date;
            lblMonthYear.Text = currentDate.ToString("MMMM yyyy").ToUpper();
            RenderGrid(gridDatesCurrent, currentDate);
            RenderGrid(gridDatesNext, currentDate.AddMonths(1));
        }

        private void StartSlide(int dir)
        {
            if (animTimer.Enabled) return;

            direction = dir;
            currentDate = currentDate.AddMonths(dir);
            lblMonthYear.Text = currentDate.ToString("MMMM yyyy").ToUpper();

            if (dir == 1)
            {
                RenderGrid(gridDatesNext, currentDate);
                gridDatesCurrent.Location = new Point(0, 0);
                gridDatesNext.Location = new Point(GridWidth, 0);
                pnlTrack.Left = 0;
            }
            else
            {
                RenderGrid(gridDatesNext, currentDate);
                gridDatesCurrent.Location = new Point(GridWidth, 0);
                gridDatesNext.Location = new Point(0, 0);
                pnlTrack.Left = -GridWidth;
            }

            animTimer.Start();
            Focus();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            int speed = 30;

            if (direction == 1)
            {
                pnlTrack.Left -= speed;
                if (pnlTrack.Left <= -GridWidth) FinishAnimation();
            }
            else
            {
                pnlTrack.Left += speed;
                if (pnlTrack.Left >= 0) FinishAnimation();
            }
        }

        private void FinishAnimation()
        {
            animTimer.Stop();
            pnlTrack.Left = 0;

            var temp = gridDatesCurrent;
            gridDatesCurrent = gridDatesNext;
            gridDatesNext = temp;

            gridDatesCurrent.Location = new Point(0, 0);
            gridDatesNext.Location = new Point(GridWidth, 0);

            RenderGrid(gridDatesNext, currentDate.AddMonths(1));
        }
    }

    public class BufferedPanel : Panel
    {
        public BufferedPanel() { DoubleBuffered = true; }
    }

    public class BufferedTableLayoutPanel : TableLayoutPanel
    {
        public BufferedTableLayoutPanel() { DoubleBuffered = true; }
    }
}