namespace Проект
{
    partial class Main_page
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem miHelp;
        private ToolStripMenuItem miAbout;

        private Panel pnlTop;
        private Label lblTitle;
        private Label lblSubtitle;

        private TableLayoutPanel pnlCards;

        private Panel pnlStudents;
        private PictureBox picStudentsIcon;
        private Label lblStudentsTitle;
        private Label lblStudentsDesc;

        private Panel pnlSchedule;
        private PictureBox picScheduleIcon;
        private Label lblScheduleTitle;
        private Label lblScheduleDesc;

        private Panel pnlSummary;
        private PictureBox picSummaryIcon;
        private Label lblSummaryTitle;
        private Label lblSummaryDesc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            miFile = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            miHelp = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            pnlTop = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlCards = new TableLayoutPanel();
            pnlStudents = new Panel();
            lblStudentsDesc = new Label();
            lblStudentsTitle = new Label();
            picStudentsIcon = new PictureBox();
            pnlSchedule = new Panel();
            lblScheduleDesc = new Label();
            lblScheduleTitle = new Label();
            picScheduleIcon = new PictureBox();
            pnlSummary = new Panel();
            lblSummaryDesc = new Label();
            lblSummaryTitle = new Label();
            picSummaryIcon = new PictureBox();
            руководствоToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlCards.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentsIcon).BeginInit();
            pnlSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).BeginInit();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSummaryIcon).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.White;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { miFile, miHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(12, 4, 0, 4);
            menuStrip.Size = new Size(1000, 27);
            menuStrip.TabIndex = 0;
            // 
            // miFile
            // 
            miFile.DropDownItems.AddRange(new ToolStripItem[] { miExit });
            miFile.ForeColor = Color.FromArgb(94, 53, 177);
            miFile.Name = "miFile";
            miFile.Size = new Size(48, 19);
            miFile.Text = "Файл";
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(108, 22);
            miExit.Text = "Выход";
            // 
            // miHelp
            // 
            miHelp.DropDownItems.AddRange(new ToolStripItem[] { руководствоToolStripMenuItem, miAbout });
            miHelp.ForeColor = Color.FromArgb(94, 53, 177);
            miHelp.Name = "miHelp";
            miHelp.Size = new Size(65, 19);
            miHelp.Text = "Справка";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(180, 22);
            miAbout.Text = "О программе";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 27);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1000, 130);
            pnlTop.TabIndex = 1;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(43, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(388, 20);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Управляйте учениками и расписанием в одном месте";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(437, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Учёт репетиторских занятий";
            // 
            // pnlCards
            // 
            pnlCards.BackColor = Color.FromArgb(245, 240, 255);
            pnlCards.ColumnCount = 3;
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pnlCards.Controls.Add(pnlStudents, 0, 0);
            pnlCards.Controls.Add(pnlSchedule, 1, 0);
            pnlCards.Controls.Add(pnlSummary, 2, 0);
            pnlCards.Dock = DockStyle.Fill;
            pnlCards.Location = new Point(0, 157);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(40, 30, 40, 40);
            pnlCards.RowCount = 1;
            pnlCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            pnlCards.Size = new Size(1000, 443);
            pnlCards.TabIndex = 0;
            // 
            // pnlStudents
            // 
            pnlStudents.BackColor = Color.White;
            pnlStudents.Controls.Add(lblStudentsDesc);
            pnlStudents.Controls.Add(lblStudentsTitle);
            pnlStudents.Controls.Add(picStudentsIcon);
            pnlStudents.Cursor = Cursors.Hand;
            pnlStudents.Dock = DockStyle.Fill;
            pnlStudents.Location = new Point(52, 42);
            pnlStudents.Margin = new Padding(12, 12, 12, 12);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(282, 349);
            pnlStudents.TabIndex = 0;
            pnlStudents.Paint += Card_Paint;
            // 
            // lblStudentsDesc
            // 
            lblStudentsDesc.Font = new Font("Segoe UI", 10F);
            lblStudentsDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblStudentsDesc.Location = new Point(30, 140);
            lblStudentsDesc.Name = "lblStudentsDesc";
            lblStudentsDesc.Size = new Size(230, 60);
            lblStudentsDesc.TabIndex = 0;
            lblStudentsDesc.Text = "Добавляйте, редактируйте и удаляйте учеников";
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentsTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblStudentsTitle.Location = new Point(28, 105);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(105, 30);
            lblStudentsTitle.TabIndex = 1;
            lblStudentsTitle.Text = "Ученики";
            // 
            // picStudentsIcon
            // 
            picStudentsIcon.BackColor = Color.Transparent;
            picStudentsIcon.Image = Properties.Resources.people;
            picStudentsIcon.Location = new Point(30, 30);
            picStudentsIcon.Name = "picStudentsIcon";
            picStudentsIcon.Size = new Size(56, 56);
            picStudentsIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudentsIcon.TabIndex = 2;
            picStudentsIcon.TabStop = false;
            // 
            // pnlSchedule
            // 
            pnlSchedule.BackColor = Color.White;
            pnlSchedule.Controls.Add(lblScheduleDesc);
            pnlSchedule.Controls.Add(lblScheduleTitle);
            pnlSchedule.Controls.Add(picScheduleIcon);
            pnlSchedule.Cursor = Cursors.Hand;
            pnlSchedule.Dock = DockStyle.Fill;
            pnlSchedule.Location = new Point(358, 42);
            pnlSchedule.Margin = new Padding(12, 12, 12, 12);
            pnlSchedule.Name = "pnlSchedule";
            pnlSchedule.Size = new Size(282, 349);
            pnlSchedule.TabIndex = 1;
            pnlSchedule.Paint += Card_Paint;
            // 
            // lblScheduleDesc
            // 
            lblScheduleDesc.Font = new Font("Segoe UI", 10F);
            lblScheduleDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblScheduleDesc.Location = new Point(30, 140);
            lblScheduleDesc.Name = "lblScheduleDesc";
            lblScheduleDesc.Size = new Size(230, 60);
            lblScheduleDesc.TabIndex = 0;
            lblScheduleDesc.Text = "Составляйте расписание и следите за занятиями";
            // 
            // lblScheduleTitle
            // 
            lblScheduleTitle.AutoSize = true;
            lblScheduleTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblScheduleTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblScheduleTitle.Location = new Point(28, 105);
            lblScheduleTitle.Name = "lblScheduleTitle";
            lblScheduleTitle.Size = new Size(138, 30);
            lblScheduleTitle.TabIndex = 1;
            lblScheduleTitle.Text = "Расписание";
            // 
            // picScheduleIcon
            // 
            picScheduleIcon.BackColor = Color.Transparent;
            picScheduleIcon.Image = Properties.Resources.schedule;
            picScheduleIcon.Location = new Point(30, 30);
            picScheduleIcon.Name = "picScheduleIcon";
            picScheduleIcon.Size = new Size(56, 56);
            picScheduleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picScheduleIcon.TabIndex = 2;
            picScheduleIcon.TabStop = false;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.Controls.Add(lblSummaryDesc);
            pnlSummary.Controls.Add(lblSummaryTitle);
            pnlSummary.Controls.Add(picSummaryIcon);
            pnlSummary.Cursor = Cursors.Hand;
            pnlSummary.Dock = DockStyle.Fill;
            pnlSummary.Location = new Point(664, 42);
            pnlSummary.Margin = new Padding(12, 12, 12, 12);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(284, 349);
            pnlSummary.TabIndex = 2;
            pnlSummary.Paint += Card_Paint;
            // 
            // lblSummaryDesc
            // 
            lblSummaryDesc.Font = new Font("Segoe UI", 10F);
            lblSummaryDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblSummaryDesc.Location = new Point(30, 140);
            lblSummaryDesc.Name = "lblSummaryDesc";
            lblSummaryDesc.Size = new Size(230, 60);
            lblSummaryDesc.TabIndex = 0;
            lblSummaryDesc.Text = "Смотрите количество занятий и часов за период";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblSummaryTitle.Location = new Point(28, 105);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(91, 30);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "Сводка";
            // 
            // picSummaryIcon
            // 
            picSummaryIcon.BackColor = Color.Transparent;
            picSummaryIcon.Image = Properties.Resources._string;
            picSummaryIcon.Location = new Point(30, 30);
            picSummaryIcon.Name = "picSummaryIcon";
            picSummaryIcon.Size = new Size(56, 56);
            picSummaryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picSummaryIcon.TabIndex = 2;
            picSummaryIcon.TabStop = false;
            // 
            // руководствоToolStripMenuItem
            // 
            руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            руководствоToolStripMenuItem.Size = new Size(180, 22);
            руководствоToolStripMenuItem.Text = "Руководство";
            руководствоToolStripMenuItem.Click += руководствоToolStripMenuItem_Click;
            // 
            // Main_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlCards);
            Controls.Add(pnlTop);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(900, 558);
            Name = "Main_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учёт репетиторских занятий";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCards.ResumeLayout(false);
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentsIcon).EndInit();
            pnlSchedule.ResumeLayout(false);
            pnlSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picScheduleIcon).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSummaryIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Градиент верхней панели: белый → светлый сиреневый
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

        // Отрисовка карточки: белый фон + мягкая сиреневая рамка + скруглённые углы
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Очищаем фон
            e.Graphics.Clear(panel.BackColor);

            // Рамка
            using (var pen = new System.Drawing.Pen(
                System.Drawing.Color.FromArgb(214, 198, 245), 1.5f))
            {
                var rect = new System.Drawing.Rectangle(0, 0,
                    panel.Width - 1, panel.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private ToolStripMenuItem руководствоToolStripMenuItem;
    }
}