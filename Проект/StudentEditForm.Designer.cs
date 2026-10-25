namespace Проект
{
    partial class StudentEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;

        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblSubject;
        private TextBox txtSubject;
        private Label lblClassLevel;
        private TextBox txtClassLevel;
        private Label lblNotes;
        private TextBox txtNotes;

        private Panel pnlBottom;
        private Button btnSave;
        private Button btnCancel;

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
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblSubject = new Label();
            txtSubject = new TextBox();
            lblClassLevel = new Label();
            txtClassLevel = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            pnlBottom = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(700, 120);
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
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.ForeColor = Color.FromArgb(94, 53, 177);
            lblLastName.Location = new Point(40, 150);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Фамилия *";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.ForeColor = Color.FromArgb(60, 40, 100);
            txtLastName.Location = new Point(200, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 30);
            txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.ForeColor = Color.FromArgb(94, 53, 177);
            lblFirstName.Location = new Point(40, 190);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(56, 23);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Имя *";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.FromArgb(60, 40, 100);
            txtFirstName.Location = new Point(200, 187);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 30);
            txtFirstName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 10F);
            lblMiddleName.ForeColor = Color.FromArgb(94, 53, 177);
            lblMiddleName.Location = new Point(40, 230);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(83, 23);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Segoe UI", 10F);
            txtMiddleName.ForeColor = Color.FromArgb(60, 40, 100);
            txtMiddleName.Location = new Point(200, 227);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(300, 30);
            txtMiddleName.TabIndex = 8;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(94, 53, 177);
            lblPhone.Location = new Point(40, 270);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 23);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Телефон";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(60, 40, 100);
            txtPhone.Location = new Point(200, 267);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 30);
            txtPhone.TabIndex = 10;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10F);
            lblSubject.ForeColor = Color.FromArgb(94, 53, 177);
            lblSubject.Location = new Point(40, 310);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(90, 23);
            lblSubject.TabIndex = 11;
            lblSubject.Text = "Предмет *";
            // 
            // txtSubject
            // 
            txtSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSubject.Font = new Font("Segoe UI", 10F);
            txtSubject.ForeColor = Color.FromArgb(60, 40, 100);
            txtSubject.Location = new Point(200, 307);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(300, 30);
            txtSubject.TabIndex = 12;
            // 
            // lblClassLevel
            // 
            lblClassLevel.AutoSize = true;
            lblClassLevel.Font = new Font("Segoe UI", 10F);
            lblClassLevel.ForeColor = Color.FromArgb(94, 53, 177);
            lblClassLevel.Location = new Point(40, 350);
            lblClassLevel.Name = "lblClassLevel";
            lblClassLevel.Size = new Size(136, 23);
            lblClassLevel.TabIndex = 13;
            lblClassLevel.Text = "Класс / уровень";
            // 
            // txtClassLevel
            // 
            txtClassLevel.BorderStyle = BorderStyle.FixedSingle;
            txtClassLevel.Font = new Font("Segoe UI", 10F);
            txtClassLevel.ForeColor = Color.FromArgb(60, 40, 100);
            txtClassLevel.Location = new Point(200, 347);
            txtClassLevel.Name = "txtClassLevel";
            txtClassLevel.Size = new Size(300, 30);
            txtClassLevel.TabIndex = 14;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F);
            lblNotes.ForeColor = Color.FromArgb(94, 53, 177);
            lblNotes.Location = new Point(40, 390);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(74, 23);
            lblNotes.TabIndex = 15;
            lblNotes.Text = "Заметки";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.ForeColor = Color.FromArgb(60, 40, 100);
            txtNotes.Location = new Point(200, 387);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(300, 80);
            txtNotes.TabIndex = 16;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnSave);
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 490);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(700, 70);
            pnlBottom.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(124, 77, 255);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(94, 53, 177);
            btnCancel.Location = new Point(260, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 560);
            Controls.Add(txtNotes);
            Controls.Add(txtClassLevel);
            Controls.Add(txtSubject);
            Controls.Add(txtPhone);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblNotes);
            Controls.Add(lblClassLevel);
            Controls.Add(lblSubject);
            Controls.Add(lblPhone);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(94, 53, 177);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ученик";
            pnlTop.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
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