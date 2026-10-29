namespace Проект
{
    partial class Schedule_page
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlLeft;
        private MonthCalendar monthCalendar;

        private Panel pnlRight;
        private Label lblSelectedDate;
        private DataGridView dgvLessons;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colStudent;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colStatus;

        private Panel pnlBottom;
        private Button btnAddLesson;
        private Button btnEditLesson;
        private Button btnDeleteLesson;

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
            pnlLeft = new Panel();
            monthCalendar = new MonthCalendar();
            pnlRight = new Panel();
            dgvLessons = new DataGridView();
            colTime = new DataGridViewTextBoxColumn();
            colStudent = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblSelectedDate = new Label();
            pnlBottom = new Panel();
            btnAddLesson = new Button();
            btnEditLesson = new Button();
            btnDeleteLesson = new Button();
            pnlTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLessons).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1000, 120);
            pnlTop.TabIndex = 0;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(124, 77, 255);
            btnBack.Location = new Point(40, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 32);
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Text = "←  Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(221, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(190, 19);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "— календарь ваших занятий";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(40, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Расписание";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(245, 240, 255);
            pnlLeft.Controls.Add(monthCalendar);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 120);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(20);
            pnlLeft.Size = new Size(320, 480);
            pnlLeft.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.Dock = DockStyle.Top;
            monthCalendar.Font = new Font("Segoe UI", 10F);
            monthCalendar.Location = new Point(20, 20);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(dgvLessons);
            pnlRight.Controls.Add(lblSelectedDate);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(320, 120);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(30, 20, 30, 20);
            pnlRight.Size = new Size(680, 480);
            pnlRight.TabIndex = 2;
            // 
            // dgvLessons
            // 
            dgvLessons.AllowUserToAddRows = false;
            dgvLessons.AllowUserToResizeRows = false;
            dgvLessons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLessons.BackgroundColor = Color.White;
            dgvLessons.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 228, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(94, 53, 177);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLessons.ColumnHeadersHeight = 40;
            dgvLessons.Columns.AddRange(new DataGridViewColumn[] { colTime, colStudent, colSubject, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 198, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 40, 100);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLessons.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLessons.Dock = DockStyle.Bottom;
            dgvLessons.EnableHeadersVisualStyles = false;
            dgvLessons.GridColor = Color.FromArgb(237, 228, 255);
            dgvLessons.Location = new Point(30, 60);
            dgvLessons.MultiSelect = false;
            dgvLessons.Name = "dgvLessons";
            dgvLessons.ReadOnly = true;
            dgvLessons.RowHeadersVisible = false;
            dgvLessons.RowHeadersWidth = 51;
            dgvLessons.RowTemplate.Height = 36;
            dgvLessons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLessons.Size = new Size(620, 400);
            dgvLessons.TabIndex = 1;
            // 
            // colTime
            // 
            colTime.FillWeight = 30F;
            colTime.HeaderText = "Время";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colStudent
            // 
            colStudent.FillWeight = 40F;
            colStudent.HeaderText = "Ученик";
            colStudent.MinimumWidth = 6;
            colStudent.Name = "colStudent";
            colStudent.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.FillWeight = 30F;
            colSubject.HeaderText = "Предмет";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 30F;
            colStatus.HeaderText = "Статус";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSelectedDate.ForeColor = Color.FromArgb(94, 53, 177);
            lblSelectedDate.Location = new Point(30, 20);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(206, 25);
            lblSelectedDate.TabIndex = 0;
            lblSelectedDate.Text = "Выберите дату слева";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnAddLesson);
            pnlBottom.Controls.Add(btnEditLesson);
            pnlBottom.Controls.Add(btnDeleteLesson);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 600);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(40, 15, 40, 15);
            pnlBottom.Size = new Size(1000, 70);
            pnlBottom.TabIndex = 3;
            // 
            // btnAddLesson
            // 
            btnAddLesson.BackColor = Color.FromArgb(124, 77, 255);
            btnAddLesson.Cursor = Cursors.Hand;
            btnAddLesson.FlatAppearance.BorderSize = 0;
            btnAddLesson.FlatStyle = FlatStyle.Flat;
            btnAddLesson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddLesson.ForeColor = Color.White;
            btnAddLesson.Location = new Point(40, 15);
            btnAddLesson.Name = "btnAddLesson";
            btnAddLesson.Size = new Size(200, 40);
            btnAddLesson.TabIndex = 0;
            btnAddLesson.Text = "+  Добавить занятие";
            btnAddLesson.UseVisualStyleBackColor = false;
            btnAddLesson.Click += btnAddLesson_Click;
            // 
            // btnEditLesson
            // 
            btnEditLesson.BackColor = Color.White;
            btnEditLesson.Cursor = Cursors.Hand;
            btnEditLesson.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnEditLesson.FlatStyle = FlatStyle.Flat;
            btnEditLesson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditLesson.ForeColor = Color.FromArgb(94, 53, 177);
            btnEditLesson.Location = new Point(260, 15);
            btnEditLesson.Name = "btnEditLesson";
            btnEditLesson.Size = new Size(180, 40);
            btnEditLesson.TabIndex = 1;
            btnEditLesson.Text = "Редактировать";
            btnEditLesson.UseVisualStyleBackColor = false;
            btnEditLesson.Click += btnEditLesson_Click;
            // 
            // btnDeleteLesson
            // 
            btnDeleteLesson.BackColor = Color.White;
            btnDeleteLesson.Cursor = Cursors.Hand;
            btnDeleteLesson.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnDeleteLesson.FlatStyle = FlatStyle.Flat;
            btnDeleteLesson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteLesson.ForeColor = Color.FromArgb(94, 53, 177);
            btnDeleteLesson.Location = new Point(460, 15);
            btnDeleteLesson.Name = "btnDeleteLesson";
            btnDeleteLesson.Size = new Size(180, 40);
            btnDeleteLesson.TabIndex = 2;
            btnDeleteLesson.Text = "Удалить";
            btnDeleteLesson.UseVisualStyleBackColor = false;
            btnDeleteLesson.Click += btnDeleteLesson_Click;
            // 
            // Schedule_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 670);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            MinimumSize = new Size(900, 596);
            Name = "Schedule_page";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Расписание";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLessons).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}