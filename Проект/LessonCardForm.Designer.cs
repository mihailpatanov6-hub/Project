namespace Проект
{
    partial class LessonCardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;

        private Label lblDate;
        private Label valDate;
        private Label lblTime;
        private Label valTime;
        private Label lblStudent;
        private Label valStudent;
        private Label lblSubject;
        private Label valSubject;
        private Label lblStatus;
        private Label valStatus;
        private Label lblNotes;
        private Label valNotes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            lblDate = new Label();
            valDate = new Label();
            lblTime = new Label();
            valTime = new Label();
            lblStudent = new Label();
            valStudent = new Label();
            lblSubject = new Label();
            valSubject = new Label();
            lblStatus = new Label();
            valStatus = new Label();
            lblNotes = new Label();
            valNotes = new Label();

            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(600, 120);
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
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(94, 53, 177);
            lblTitle.Location = new Point(40, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Карточка занятия";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(94, 53, 177);
            lblDate.Location = new Point(40, 150);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 23);
            lblDate.TabIndex = 0;
            lblDate.Text = "Дата:";
            // 
            // valDate
            // 
            valDate.AutoSize = true;
            valDate.Font = new Font("Segoe UI", 10F);
            valDate.ForeColor = Color.FromArgb(60, 40, 100);
            valDate.Location = new Point(200, 150);
            valDate.Name = "valDate";
            valDate.Size = new Size(27, 23);
            valDate.TabIndex = 1;
            valDate.Text = "—";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(94, 53, 177);
            lblTime.Location = new Point(40, 190);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(70, 23);
            lblTime.TabIndex = 2;
            lblTime.Text = "Время:";
            // 
            // valTime
            // 
            valTime.AutoSize = true;
            valTime.Font = new Font("Segoe UI", 10F);
            valTime.ForeColor = Color.FromArgb(60, 40, 100);
            valTime.Location = new Point(200, 190);
            valTime.Name = "valTime";
            valTime.Size = new Size(27, 23);
            valTime.TabIndex = 3;
            valTime.Text = "—";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(94, 53, 177);
            lblStudent.Location = new Point(40, 230);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(83, 23);
            lblStudent.TabIndex = 4;
            lblStudent.Text = "Ученик:";
            // 
            // valStudent
            // 
            valStudent.AutoSize = true;
            valStudent.Font = new Font("Segoe UI", 10F);
            valStudent.ForeColor = Color.FromArgb(60, 40, 100);
            valStudent.Location = new Point(200, 230);
            valStudent.Name = "valStudent";
            valStudent.Size = new Size(27, 23);
            valStudent.TabIndex = 5;
            valStudent.Text = "—";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubject.ForeColor = Color.FromArgb(94, 53, 177);
            lblSubject.Location = new Point(40, 270);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(89, 23);
            lblSubject.TabIndex = 6;
            lblSubject.Text = "Предмет:";
            // 
            // valSubject
            // 
            valSubject.AutoSize = true;
            valSubject.Font = new Font("Segoe UI", 10F);
            valSubject.ForeColor = Color.FromArgb(60, 40, 100);
            valSubject.Location = new Point(200, 270);
            valSubject.Name = "valSubject";
            valSubject.Size = new Size(27, 23);
            valSubject.TabIndex = 7;
            valSubject.Text = "—";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(94, 53, 177);
            lblStatus.Location = new Point(40, 310);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Статус:";
            // 
            // valStatus
            // 
            valStatus.AutoSize = true;
            valStatus.Font = new Font("Segoe UI", 10F);
            valStatus.ForeColor = Color.FromArgb(60, 40, 100);
            valStatus.Location = new Point(200, 310);
            valStatus.Name = "valStatus";
            valStatus.Size = new Size(27, 23);
            valStatus.TabIndex = 9;
            valStatus.Text = "—";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(94, 53, 177);
            lblNotes.Location = new Point(40, 350);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(85, 23);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Заметки:";
            // 
            // valNotes
            // 
            valNotes.AutoSize = true;
            valNotes.Font = new Font("Segoe UI", 10F);
            valNotes.ForeColor = Color.FromArgb(60, 40, 100);
            valNotes.Location = new Point(200, 350);
            valNotes.MaximumSize = new Size(350, 0);
            valNotes.Name = "valNotes";
            valNotes.Size = new Size(27, 23);
            valNotes.TabIndex = 11;
            valNotes.Text = "—";
            // 
            // LessonCardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 480);
            Controls.Add(lblDate);
            Controls.Add(valDate);
            Controls.Add(lblTime);
            Controls.Add(valTime);
            Controls.Add(lblStudent);
            Controls.Add(valStudent);
            Controls.Add(lblSubject);
            Controls.Add(valSubject);
            Controls.Add(lblStatus);
            Controls.Add(valStatus);
            Controls.Add(lblNotes);
            Controls.Add(valNotes);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(94, 53, 177);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LessonCardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Карточка занятия";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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