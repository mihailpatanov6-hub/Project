namespace Проект
{
    partial class Summary_page
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSubtitle;

        // Панель фильтров
        private Panel pnlFilters;
        private Button btnCurrentMonth;
        private Button btnLastMonth;
        private Button btnCurrentYear;
        private Button btnAllTime;

        // Кнопки для выбора дат (вместо DateTimePicker)
        private Button btnDateFrom;
        private Button btnDateTo;

        // Карточки
        private TableLayoutPanel pnlCards;
        private Panel cardLessons;
        private Label lblLessonsTitle;
        private Label lblLessonsValue;

        private Panel cardHours;
        private Label lblHoursTitle;
        private Label lblHoursValue;

        private Panel cardMissed;
        private Label lblMissedTitle;
        private Label lblMissedValue;

        private Panel cardActiveDay;
        private Label lblActiveDayTitle;
        private Label lblActiveDayValue;
        private Label lblActiveDaySub;

        // Таблица
        private Panel pnlGrid;
        private DataGridView dgvStats;
        private DataGridViewTextBoxColumn colStudent;
        private DataGridViewTextBoxColumn colDone;
        private DataGridViewTextBoxColumn colMissed;
        private DataGridViewTextBoxColumn colHours;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            pnlTop = new Panel();
            btnBack = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();

            pnlFilters = new Panel();
            btnCurrentMonth = new Button();
            btnLastMonth = new Button();
            btnCurrentYear = new Button();
            btnAllTime = new Button();
            btnDateFrom = new Button();
            btnDateTo = new Button();

            pnlCards = new TableLayoutPanel();
            cardLessons = new Panel();
            lblLessonsTitle = new Label();
            lblLessonsValue = new Label();

            cardHours = new Panel();
            lblHoursTitle = new Label();
            lblHoursValue = new Label();

            cardMissed = new Panel();
            lblMissedTitle = new Label();
            lblMissedValue = new Label();

            cardActiveDay = new Panel();
            lblActiveDayTitle = new Label();
            lblActiveDayValue = new Label();
            lblActiveDaySub = new Label();

            pnlGrid = new Panel();
            dgvStats = new DataGridView();
            colStudent = new DataGridViewTextBoxColumn();
            colDone = new DataGridViewTextBoxColumn();
            colMissed = new DataGridViewTextBoxColumn();
            colHours = new DataGridViewTextBoxColumn();

            pnlTop.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlCards.SuspendLayout();
            cardLessons.SuspendLayout();
            cardHours.SuspendLayout();
            cardMissed.SuspendLayout();
            cardActiveDay.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();

            // pnlTop
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1100, 120);
            pnlTop.TabIndex = 0;
            pnlTop.Paint += pnlTop_Paint;

            // btnBack
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(124, 77, 255);
            btnBack.Location = new Point(40, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 32);
            btnBack.TabStop = false;
            btnBack.Text = "←  Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(40, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Сводка";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(180, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(210, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "— статистика ваших занятий";

            // pnlFilters
            pnlFilters.BackColor = Color.FromArgb(245, 240, 255);
            pnlFilters.Controls.Add(btnCurrentMonth);
            pnlFilters.Controls.Add(btnLastMonth);
            pnlFilters.Controls.Add(btnCurrentYear);
            pnlFilters.Controls.Add(btnAllTime);
            pnlFilters.Controls.Add(btnDateFrom);
            pnlFilters.Controls.Add(btnDateTo);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 120);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(40, 15, 40, 15);
            pnlFilters.Size = new Size(1100, 70);
            pnlFilters.TabIndex = 1;

            // Кнопки-фильтры
            SetupFilterButton(btnCurrentMonth, "Этот месяц", 40);
            SetupFilterButton(btnLastMonth, "Прошлый месяц", 170);
            SetupFilterButton(btnCurrentYear, "Этот год", 320);
            SetupFilterButton(btnAllTime, "Всё время", 440);

            // Кнопки выбора дат
            SetupDateButton(btnDateFrom, "С даты...", 580);
            SetupDateButton(btnDateTo, "По дату...", 710);

            // pnlCards
            pnlCards.BackColor = Color.White;
            pnlCards.ColumnCount = 4;
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.Controls.Add(cardLessons, 0, 0);
            pnlCards.Controls.Add(cardHours, 1, 0);
            pnlCards.Controls.Add(cardMissed, 2, 0);
            pnlCards.Controls.Add(cardActiveDay, 3, 0);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 190);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(40, 20, 40, 20);
            pnlCards.RowCount = 1;
            pnlCards.Size = new Size(1100, 140);
            pnlCards.TabIndex = 2;

            // Настройка карточек
            SetupCard(cardLessons, lblLessonsTitle, lblLessonsValue, "Всего занятий", "0", 0);
            SetupCard(cardHours, lblHoursTitle, lblHoursValue, "Отработано часов", "0 ч.", 1);
            SetupCard(cardMissed, lblMissedTitle, lblMissedValue, "Пропущено / Отменено", "0", 2);

            // 4-я карточка (Активный день)
            cardActiveDay.BackColor = Color.White;
            cardActiveDay.Dock = DockStyle.Fill;
            cardActiveDay.Margin = new Padding(10);
            cardActiveDay.Paint += Card_Paint;

            lblActiveDayTitle.Text = "Активный день";
            lblActiveDayTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiveDayTitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblActiveDayTitle.Dock = DockStyle.Top;
            lblActiveDayTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblActiveDayTitle.Height = 30;

            lblActiveDayValue.Text = "—";
            lblActiveDayValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblActiveDayValue.ForeColor = Color.FromArgb(94, 53, 177);
            lblActiveDayValue.Dock = DockStyle.Fill;
            lblActiveDayValue.TextAlign = ContentAlignment.MiddleCenter;

            lblActiveDaySub.Text = "";
            lblActiveDaySub.Font = new Font("Segoe UI", 9F);
            lblActiveDaySub.ForeColor = Color.Gray;
            lblActiveDaySub.Dock = DockStyle.Bottom;
            lblActiveDaySub.TextAlign = ContentAlignment.MiddleCenter;
            lblActiveDaySub.Height = 25;

            cardActiveDay.Controls.Add(lblActiveDayValue);
            cardActiveDay.Controls.Add(lblActiveDaySub);
            cardActiveDay.Controls.Add(lblActiveDayTitle);

            // pnlGrid
            pnlGrid.BackColor = Color.FromArgb(245, 240, 255);
            pnlGrid.Controls.Add(dgvStats);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 330);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(40, 10, 40, 40);
            pnlGrid.Size = new Size(1100, 370);
            pnlGrid.TabIndex = 3;

            // dgvStats
            dgvStats.AllowUserToAddRows = false;
            dgvStats.AllowUserToResizeRows = false;
            dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStats.BackgroundColor = Color.White;
            dgvStats.BorderStyle = BorderStyle.None;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 228, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(94, 53, 177);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStats.ColumnHeadersHeight = 40;
            dgvStats.Columns.AddRange(new DataGridViewColumn[] { colStudent, colDone, colMissed, colHours });

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 198, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStats.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStats.Dock = DockStyle.Fill;
            dgvStats.EnableHeadersVisualStyles = false;
            dgvStats.Font = new Font("Segoe UI", 10F);
            dgvStats.GridColor = Color.FromArgb(237, 228, 255);
            dgvStats.MultiSelect = false;
            dgvStats.Name = "dgvStats";
            dgvStats.ReadOnly = true;
            dgvStats.RowHeadersVisible = false;
            dgvStats.RowTemplate.Height = 36;
            dgvStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStats.TabIndex = 0;

            // Колонки
            colStudent.HeaderText = "Ученик";
            colStudent.Name = "colStudent";
            colDone.HeaderText = "Проведено";
            colDone.Name = "colDone";
            colMissed.HeaderText = "Пропущено";
            colMissed.Name = "colMissed";
            colHours.HeaderText = "Часы";
            colHours.Name = "colHours";

            // Summary_page
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlGrid);
            Controls.Add(pnlCards);
            Controls.Add(pnlFilters);
            Controls.Add(pnlTop);
            MinimumSize = new Size(1000, 600);
            Name = "Summary_page";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Сводка";

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlCards.ResumeLayout(false);
            cardLessons.ResumeLayout(false);
            cardHours.ResumeLayout(false);
            cardMissed.ResumeLayout(false);
            cardActiveDay.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
        }

        // Вспомогательные методы
        private void SetupFilterButton(Button btn, string text, int x)
        {
            btn.BackColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(94, 53, 177);
            btn.Location = new Point(x, 17);
            btn.Size = new Size(120, 36);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
        }

        private void SetupDateButton(Button btn, string text, int x)
        {
            btn.BackColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F);
            btn.ForeColor = Color.FromArgb(60, 40, 100);
            btn.Location = new Point(x, 17);
            btn.Size = new Size(120, 36);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
        }

        private void SetupCard(Panel card, Label title, Label value, string titleText, string valText, int col)
        {
            card.BackColor = Color.White;
            card.Dock = DockStyle.Fill;
            card.Margin = new Padding(10);
            card.Paint += Card_Paint;

            title.Text = titleText;
            title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(124, 77, 255);
            title.Dock = DockStyle.Top;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Height = 30;

            value.Text = valText;
            value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            value.ForeColor = Color.FromArgb(94, 53, 177);
            value.Dock = DockStyle.Fill;
            value.TextAlign = ContentAlignment.MiddleCenter;

            card.Controls.Add(value);
            card.Controls.Add(title);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlTop.ClientRectangle,
                System.Drawing.Color.White,
                System.Drawing.Color.FromArgb(237, 228, 255),
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlTop.ClientRectangle);
            }
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(panel.BackColor);
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(214, 198, 245), 1.5f))
            {
                var rect = new System.Drawing.Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}