namespace Проект
{
    partial class StudentEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSubtitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtPhone = new TextBox();
            txtSubject = new TextBox();
            txtClassLevel = new TextBox();
            txtNotes = new TextBox();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblSubtitle.Location = new Point(13, 11);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(144, 19);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "— заполните данные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 1;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 103);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 3;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 197);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 4;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 252);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 5;
            label5.Text = "Предмет";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 307);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 6;
            label6.Text = "Класс / уровень";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 48);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 7;
            label7.Text = "Заметки";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(124, 77, 255);
            btnSave.Location = new Point(343, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(124, 77, 255);
            btnCancel.Location = new Point(517, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 43);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(124, 77, 255);
            btnBack.Location = new Point(173, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 43);
            btnBack.TabIndex = 10;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(135, 58);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 25);
            txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(135, 102);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 25);
            txtFirstName.TabIndex = 12;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(135, 152);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(179, 25);
            txtMiddleName.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 200);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(179, 25);
            txtPhone.TabIndex = 14;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(135, 251);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(179, 25);
            txtSubject.TabIndex = 15;
            // 
            // txtClassLevel
            // 
            txtClassLevel.Location = new Point(135, 307);
            txtClassLevel.Name = "txtClassLevel";
            txtClassLevel.Size = new Size(179, 25);
            txtClassLevel.TabIndex = 16;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(517, 45);
            txtNotes.MinimumSize = new Size(4, 90);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(258, 120);
            txtNotes.TabIndex = 17;
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(txtNotes);
            Controls.Add(txtClassLevel);
            Controls.Add(txtSubject);
            Controls.Add(txtPhone);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSubtitle);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(94, 53, 177);
            Name = "StudentEditForm";
            Text = "Добавить ученика";
            Load += StudentEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtPhone;
        private TextBox txtSubject;
        private TextBox txtClassLevel;
        private TextBox txtNotes;
    }
}