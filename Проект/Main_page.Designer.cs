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
            menuStrip.Padding = new Padding(14, 5, 0, 5);
            menuStrip.Size = new Size(1143, 34);
            menuStrip.TabIndex = 0;
            // 
            // miFile
            // 
            miFile.DropDownItems.AddRange(new ToolStripItem[] { miExit });
            miFile.ForeColor = Color.FromArgb(94, 53, 177);
            miFile.Name = "miFile";
            miFile.Size = new Size(59, 24);
            miFile.Text = "Файл";
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(136, 26);
            miExit.Text = "Выход";
            // 
            // miHelp
            // 
            miHelp.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            miHelp.ForeColor = Color.FromArgb(94, 53, 177);
            miHelp.Name = "miHelp";
            miHelp.Size = new Size(81, 24);
            miHelp.Text = "Справка";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(187, 26);
            miAbout.Text = "О программе";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 34);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1143, 173);
            pnlTop.TabIndex = 1;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(49, 107);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(482, 25);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Управляйте учениками и расписанием в одном месте";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(46, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(539, 50);
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
            pnlCards.Location = new Point(0, 207);
            pnlCards.Margin = new Padding(3, 4, 3, 4);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(46, 40, 46, 53);
            pnlCards.RowCount = 1;
            pnlCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlCards.Size = new Size(1143, 593);
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
            pnlStudents.Location = new Point(60, 56);
            pnlStudents.Margin = new Padding(14, 16, 14, 16);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(322, 468);
            pnlStudents.TabIndex = 0;
            pnlStudents.Paint += Card_Paint;
            // 
            // lblStudentsDesc
            // 
            lblStudentsDesc.Font = new Font("Segoe UI", 10F);
            lblStudentsDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblStudentsDesc.Location = new Point(34, 187);
            lblStudentsDesc.Name = "lblStudentsDesc";
            lblStudentsDesc.Size = new Size(263, 80);
            lblStudentsDesc.TabIndex = 0;
            lblStudentsDesc.Text = "Добавляйте, редактируйте и удаляйте учеников";
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentsTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblStudentsTitle.Location = new Point(32, 140);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(131, 37);
            lblStudentsTitle.TabIndex = 1;
            lblStudentsTitle.Text = "Ученики";
            // 
            // picStudentsIcon
            // 
            picStudentsIcon.BackColor = Color.Transparent;
            picStudentsIcon.Image = Properties.Resources.people;
            picStudentsIcon.Location = new Point(34, 40);
            picStudentsIcon.Margin = new Padding(3, 4, 3, 4);
            picStudentsIcon.Name = "picStudentsIcon";
            picStudentsIcon.Size = new Size(64, 75);
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
            pnlSchedule.Location = new Point(410, 56);
            pnlSchedule.Margin = new Padding(14, 16, 14, 16);
            pnlSchedule.Name = "pnlSchedule";
            pnlSchedule.Size = new Size(322, 468);
            pnlSchedule.TabIndex = 1;
            pnlSchedule.Paint += Card_Paint;
            // 
            // lblScheduleDesc
            // 
            lblScheduleDesc.Font = new Font("Segoe UI", 10F);
            lblScheduleDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblScheduleDesc.Location = new Point(34, 187);
            lblScheduleDesc.Name = "lblScheduleDesc";
            lblScheduleDesc.Size = new Size(263, 80);
            lblScheduleDesc.TabIndex = 0;
            lblScheduleDesc.Text = "Составляйте расписание и следите за занятиями";
            // 
            // lblScheduleTitle
            // 
            lblScheduleTitle.AutoSize = true;
            lblScheduleTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblScheduleTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblScheduleTitle.Location = new Point(32, 140);
            lblScheduleTitle.Name = "lblScheduleTitle";
            lblScheduleTitle.Size = new Size(172, 37);
            lblScheduleTitle.TabIndex = 1;
            lblScheduleTitle.Text = "Расписание";
            // 
            // picScheduleIcon
            // 
            picScheduleIcon.BackColor = Color.Transparent;
            picScheduleIcon.Image = Properties.Resources.schedule;
            picScheduleIcon.Location = new Point(34, 40);
            picScheduleIcon.Margin = new Padding(3, 4, 3, 4);
            picScheduleIcon.Name = "picScheduleIcon";
            picScheduleIcon.Size = new Size(64, 75);
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
            pnlSummary.Location = new Point(760, 56);
            pnlSummary.Margin = new Padding(14, 16, 14, 16);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(323, 468);
            pnlSummary.TabIndex = 2;
            pnlSummary.Paint += Card_Paint;
            // 
            // lblSummaryDesc
            // 
            lblSummaryDesc.Font = new Font("Segoe UI", 10F);
            lblSummaryDesc.ForeColor = Color.FromArgb(124, 77, 255);
            lblSummaryDesc.Location = new Point(34, 187);
            lblSummaryDesc.Name = "lblSummaryDesc";
            lblSummaryDesc.Size = new Size(263, 80);
            lblSummaryDesc.TabIndex = 0;
            lblSummaryDesc.Text = "Смотрите количество занятий и часов за период";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblSummaryTitle.Location = new Point(32, 140);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(114, 37);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "Сводка";
            // 
            // picSummaryIcon
            // 
            picSummaryIcon.BackColor = Color.Transparent;
            picSummaryIcon.Image = Properties.Resources._string;
            picSummaryIcon.Location = new Point(34, 40);
            picSummaryIcon.Margin = new Padding(3, 4, 3, 4);
            picSummaryIcon.Name = "picSummaryIcon";
            picSummaryIcon.Size = new Size(64, 75);
            picSummaryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picSummaryIcon.TabIndex = 2;
            picSummaryIcon.TabStop = false;
            // 
            // Main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 800);
            Controls.Add(pnlCards);
            Controls.Add(pnlTop);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 731);
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
    }
}