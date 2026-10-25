namespace Проект
{
    partial class StudentCardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;

        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblPhone;
        private Label lblSubject;
        private Label lblClassLevel;
        private Label lblNotes;

        private Label valLastName;
        private Label valFirstName;
        private Label valMiddleName;
        private Label valPhone;
        private Label valSubject;
        private Label valClassLevel;
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
            lblLastName = new Label();
            valLastName = new Label();
            lblFirstName = new Label();
            valFirstName = new Label();
            lblMiddleName = new Label();
            valMiddleName = new Label();
            lblPhone = new Label();
            valPhone = new Label();
            lblSubject = new Label();
            valSubject = new Label();
            lblClassLevel = new Label();
            valClassLevel = new Label();
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
            lblTitle.Size = new Size(283, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Карточка ученика";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(94, 53, 177);
            lblLastName.Location = new Point(40, 150);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 23);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Фамилия:";
            // 
            // valLastName
            // 
            valLastName.AutoSize = true;
            valLastName.Font = new Font("Segoe UI", 10F);
            valLastName.ForeColor = Color.FromArgb(60, 40, 100);
            valLastName.Location = new Point(200, 150);
            valLastName.Name = "valLastName";
            valLastName.Size = new Size(27, 23);
            valLastName.TabIndex = 1;
            valLastName.Text = "—";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(94, 53, 177);
            lblFirstName.Location = new Point(40, 190);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(51, 23);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Имя:";
            // 
            // valFirstName
            // 
            valFirstName.AutoSize = true;
            valFirstName.Font = new Font("Segoe UI", 10F);
            valFirstName.ForeColor = Color.FromArgb(60, 40, 100);
            valFirstName.Location = new Point(200, 190);
            valFirstName.Name = "valFirstName";
            valFirstName.Size = new Size(27, 23);
            valFirstName.TabIndex = 3;
            valFirstName.Text = "—";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMiddleName.ForeColor = Color.FromArgb(94, 53, 177);
            lblMiddleName.Location = new Point(40, 230);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(91, 23);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Отчество:";
            // 
            // valMiddleName
            // 
            valMiddleName.AutoSize = true;
            valMiddleName.Font = new Font("Segoe UI", 10F);
            valMiddleName.ForeColor = Color.FromArgb(60, 40, 100);
            valMiddleName.Location = new Point(200, 230);
            valMiddleName.Name = "valMiddleName";
            valMiddleName.Size = new Size(27, 23);
            valMiddleName.TabIndex = 5;
            valMiddleName.Text = "—";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(94, 53, 177);
            lblPhone.Location = new Point(40, 270);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(85, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Телефон:";
            // 
            // valPhone
            // 
            valPhone.AutoSize = true;
            valPhone.Font = new Font("Segoe UI", 10F);
            valPhone.ForeColor = Color.FromArgb(60, 40, 100);
            valPhone.Location = new Point(200, 270);
            valPhone.Name = "valPhone";
            valPhone.Size = new Size(27, 23);
            valPhone.TabIndex = 7;
            valPhone.Text = "—";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubject.ForeColor = Color.FromArgb(94, 53, 177);
            lblSubject.Location = new Point(40, 310);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(89, 23);
            lblSubject.TabIndex = 8;
            lblSubject.Text = "Предмет:";
            // 
            // valSubject
            // 
            valSubject.AutoSize = true;
            valSubject.Font = new Font("Segoe UI", 10F);
            valSubject.ForeColor = Color.FromArgb(60, 40, 100);
            valSubject.Location = new Point(200, 310);
            valSubject.Name = "valSubject";
            valSubject.Size = new Size(27, 23);
            valSubject.TabIndex = 9;
            valSubject.Text = "—";
            // 
            // lblClassLevel
            // 
            lblClassLevel.AutoSize = true;
            lblClassLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClassLevel.ForeColor = Color.FromArgb(94, 53, 177);
            lblClassLevel.Location = new Point(40, 350);
            lblClassLevel.Name = "lblClassLevel";
            lblClassLevel.Size = new Size(149, 23);
            lblClassLevel.TabIndex = 10;
            lblClassLevel.Text = "Класс / уровень:";
            // 
            // valClassLevel
            // 
            valClassLevel.AutoSize = true;
            valClassLevel.Font = new Font("Segoe UI", 10F);
            valClassLevel.ForeColor = Color.FromArgb(60, 40, 100);
            valClassLevel.Location = new Point(200, 350);
            valClassLevel.Name = "valClassLevel";
            valClassLevel.Size = new Size(27, 23);
            valClassLevel.TabIndex = 11;
            valClassLevel.Text = "—";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(94, 53, 177);
            lblNotes.Location = new Point(40, 390);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(85, 23);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Заметки:";
            // 
            // valNotes
            // 
            valNotes.AutoSize = true;
            valNotes.Font = new Font("Segoe UI", 10F);
            valNotes.ForeColor = Color.FromArgb(60, 40, 100);
            valNotes.Location = new Point(200, 390);
            valNotes.MaximumSize = new Size(350, 0);
            valNotes.Name = "valNotes";
            valNotes.Size = new Size(27, 23);
            valNotes.TabIndex = 13;
            valNotes.Text = "—";
            // 
            // StudentCardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 500);
            Controls.Add(lblLastName);
            Controls.Add(valLastName);
            Controls.Add(lblFirstName);
            Controls.Add(valFirstName);
            Controls.Add(lblMiddleName);
            Controls.Add(valMiddleName);
            Controls.Add(lblPhone);
            Controls.Add(valPhone);
            Controls.Add(lblSubject);
            Controls.Add(valSubject);
            Controls.Add(lblClassLevel);
            Controls.Add(valClassLevel);
            Controls.Add(lblNotes);
            Controls.Add(valNotes);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(94, 53, 177);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentCardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Карточка ученика";
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