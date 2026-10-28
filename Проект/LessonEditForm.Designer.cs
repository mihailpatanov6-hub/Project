namespace Проект
{
    partial class LessonEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblDate;
        private DateTimePicker dtpDate;

        private Label lblStudent;
        private ComboBox cmbStudent;

        private Label lblSubject;
        private ComboBox cmbSubject;

        private Label lblStartTime;
        private DateTimePicker dtpStartTime;

        private Label lblEndTime;
        private DateTimePicker dtpEndTime;

        private Label lblStatus;
        private ComboBox cmbStatus;

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
            lblSubtitle = new Label();
            lblTitle = new Label();

            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblStudent = new Label();
            cmbStudent = new ComboBox();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblNotes = new Label();
            txtNotes = new TextBox();

            pnlBottom = new Panel();
            btnSave = new Button();
            btnCancel = new Button();

            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();

            // pnlTop
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblSubtitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(700, 120);
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
            btnBack.TabIndex = 0;
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
            lblTitle.Size = new Size(250, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Добавить занятие";

            // lblDate
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.FromArgb(94, 53, 177);
            lblDate.Location = new Point(40, 150);
            lblDate.Text = "Дата *";

            // dtpDate
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd.MM.yyyy";
            dtpDate.Font = new Font("Segoe UI", 10F);
            dtpDate.Location = new Point(200, 147);
            dtpDate.Size = new Size(450, 30);
            dtpDate.TabIndex = 3;

            // lblStudent
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 10F);
            lblStudent.ForeColor = Color.FromArgb(94, 53, 177);
            lblStudent.Location = new Point(40, 195);
            lblStudent.Text = "Ученик *";

            // cmbStudent
            cmbStudent.Font = new Font("Segoe UI", 10F);
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.Location = new Point(200, 192);
            cmbStudent.Size = new Size(450, 31);
            cmbStudent.TabIndex = 4;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10F);
            lblSubject.ForeColor = Color.FromArgb(94, 53, 177);
            lblSubject.Location = new Point(40, 240);
            lblSubject.Text = "Предмет *";

            // cmbSubject
            cmbSubject.Font = new Font("Segoe UI", 10F);
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.Location = new Point(200, 237);
            cmbSubject.Size = new Size(450, 31);
            cmbSubject.TabIndex = 5;

            // lblStartTime
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 10F);
            lblStartTime.ForeColor = Color.FromArgb(94, 53, 177);
            lblStartTime.Location = new Point(40, 285);
            lblStartTime.Text = "Время начала *";

            // dtpStartTime
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Font = new Font("Segoe UI", 10F);
            dtpStartTime.Location = new Point(200, 282);
            dtpStartTime.Size = new Size(220, 30);
            dtpStartTime.TabIndex = 6;

            // lblEndTime
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 10F);
            lblEndTime.ForeColor = Color.FromArgb(94, 53, 177);
            lblEndTime.Location = new Point(40, 330);
            lblEndTime.Text = "Время окончания";

            // dtpEndTime
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Font = new Font("Segoe UI", 10F);
            dtpEndTime.Location = new Point(200, 327);
            dtpEndTime.Size = new Size(220, 30);
            dtpEndTime.TabIndex = 7;

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(94, 53, 177);
            lblStatus.Location = new Point(40, 375);
            lblStatus.Text = "Статус";

            // cmbStatus
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(200, 372);
            cmbStatus.Size = new Size(450, 31);
            cmbStatus.TabIndex = 8;
            cmbStatus.Items.AddRange(new object[] { "Запланировано", "Проведено", "Отменено", "Перенесено" });

            // lblNotes
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F);
            lblNotes.ForeColor = Color.FromArgb(94, 53, 177);
            lblNotes.Location = new Point(40, 420);
            lblNotes.Text = "Заметки";

            // txtNotes
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Multiline = true;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(200, 417);
            txtNotes.Size = new Size(450, 80);
            txtNotes.TabIndex = 9;

            // pnlBottom
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnSave);
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 530);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(700, 70);
            pnlBottom.TabIndex = 10;

            // btnSave
            btnSave.BackColor = Color.FromArgb(124, 77, 255);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 245);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(94, 53, 177);
            btnCancel.Location = new Point(260, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // LessonEditForm
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 600);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpEndTime);
            Controls.Add(lblEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblStartTime);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(cmbStudent);
            Controls.Add(lblStudent);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(94, 53, 177);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LessonEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Занятие";

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
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