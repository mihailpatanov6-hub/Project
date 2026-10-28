using System;
using System.Drawing;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class LessonEditForm : Form
    {
        private DatabaseHelper db;
        private Lesson lesson;

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnBack;
        private Button btnSave;
        private Button btnCancel;

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

        public LessonEditForm(DateTime date)
        {
            InitializeComponent();
            db = new DatabaseHelper();
            BuildUI();
            LoadStudents();
            LoadSubjects();
            cmbStatus.SelectedIndex = 0;
            dtpDate.Value = date;
        }

        public LessonEditForm(Lesson existingLesson)
        {
            InitializeComponent();
            db = new DatabaseHelper();
            lesson = existingLesson;
            BuildUI();
            LoadStudents();
            LoadSubjects();
            FillFields();
        }

        private void BuildUI()
        {
            Text = lesson == null ? "Добавить занятие" : "Редактировать занятие";
            Size = new Size(720, 720);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(245, 240, 255);

            int x = 30, lx = 200, w = 470, y = 150, step = 55;

            // Заголовок
            lblTitle = new Label
            {
                Text = lesson == null ? "Добавить занятие" : "Редактировать занятие",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(94, 53, 177),
                Location = new Point(x, 25),
                AutoSize = true
            };

            lblSubtitle = new Label
            {
                Text = "— заполните данные занятия",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(124, 77, 255),
                Location = new Point(lblTitle.Right + 15, lblTitle.Top + 12),
                AutoSize = true
            };

            // Кнопка Назад
            btnBack = new Button
            {
                Text = "← Назад",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(124, 77, 255),
                BackColor = BackColor,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(x, 75),
                Size = new Size(100, 30),
                Cursor = Cursors.Hand
            };
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += BtnBack_Click;
            btnBack.MouseEnter += (s, e) => btnBack.ForeColor = Color.FromArgb(94, 53, 177);
            btnBack.MouseLeave += (s, e) => btnBack.ForeColor = Color.FromArgb(124, 77, 255);

            // Разделитель
            var sep1 = new Label
            {
                BackColor = Color.FromArgb(124, 77, 255),
                Location = new Point(0, 120),
                Size = new Size(Width, 2)
            };

            Controls.AddRange(new Control[] { lblTitle, lblSubtitle, btnBack, sep1 });

            // Дата
            lblDate = CreateLabel("Дата *", x, y);
            dtpDate = new DateTimePicker
            {
                Location = new Point(lx, y),
                Size = new Size(w, 30),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd.MM.yyyy",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White
            };
            Controls.AddRange(new Control[] { lblDate, dtpDate });
            y += step;

            // Ученик
            lblStudent = CreateLabel("Ученик *", x, y);
            cmbStudent = new ComboBox
            {
                Location = new Point(lx, y),
                Size = new Size(w, 30),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White
            };
            Controls.AddRange(new Control[] { lblStudent, cmbStudent });
            y += step;

            // Предмет
            lblSubject = CreateLabel("Предмет *", x, y);
            cmbSubject = new ComboBox
            {
                Location = new Point(lx, y),
                Size = new Size(w, 30),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White
            };
            Controls.AddRange(new Control[] { lblSubject, cmbSubject });
            y += step;

            // Время начала
            lblStartTime = CreateLabel("Время начала *", x, y);
            dtpStartTime = new DateTimePicker
            {
                Location = new Point(lx, y),
                Size = new Size(220, 30),
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White
            };
            Controls.AddRange(new Control[] { lblStartTime, dtpStartTime });
            y += step;

            // Время окончания
            lblEndTime = CreateLabel("Время окончания", x, y);
            dtpEndTime = new DateTimePicker
            {
                Location = new Point(lx, y),
                Size = new Size(220, 30),
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White
            };
            Controls.AddRange(new Control[] { lblEndTime, dtpEndTime });
            y += step;

            // Статус
            lblStatus = CreateLabel("Статус", x, y);
            cmbStatus = new ComboBox
            {
                Location = new Point(lx, y),
                Size = new Size(w, 30),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White
            };
            cmbStatus.Items.AddRange(new object[] { "Запланировано", "Проведено", "Отменено", "Перенесено" });
            Controls.AddRange(new Control[] { lblStatus, cmbStatus });
            y += step + 10;

            // Заметки
            lblNotes = CreateLabel("Заметки", x, y);
            txtNotes = new TextBox
            {
                Location = new Point(lx, y),
                Size = new Size(w, 100),
                Multiline = true,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.AddRange(new Control[] { lblNotes, txtNotes });

            // Разделитель перед кнопками
            var sep2 = new Label
            {
                BackColor = Color.FromArgb(124, 77, 255),
                Location = new Point(0, Height - 130),
                Size = new Size(Width, 2)
            };

            // Кнопка Сохранить
            btnSave = new Button
            {
                Text = "Сохранить",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(124, 77, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(x, Height - 100),
                Size = new Size(170, 50),
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += (s, e) => btnSave.BackColor = Color.FromArgb(94, 53, 177);
            btnSave.MouseLeave += (s, e) => btnSave.BackColor = Color.FromArgb(124, 77, 255);

            // Кнопка Отмена
            btnCancel = new Button
            {
                Text = "Отмена",
                Font = new Font("Segoe UI", 11),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(124, 77, 255),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(220, Height - 100),
                Size = new Size(170, 50),
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(124, 77, 255);
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.Click += BtnCancel_Click;
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(237, 228, 255);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.White;

            Controls.AddRange(new Control[] { sep2, btnSave, btnCancel });
        }

        private Label CreateLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(94, 53, 177),
                Location = new Point(x, y),
                Size = new Size(150, 25),
                AutoSize = false
            };
        }

        private void LoadStudents()
        {
            cmbStudent.Items.Clear();
            var students = db.GetAllStudents();
            foreach (var s in students)
            {
                cmbStudent.Items.Add(new StudentItem { Id = s.Id, Name = s.FullName });
            }
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
        }

        private void LoadSubjects()
        {
            cmbSubject.Items.Clear();
            var subjects = db.GetUniqueSubjects();
            foreach (var subject in subjects)
            {
                cmbSubject.Items.Add(subject);
            }
        }

        private void FillFields()
        {
            if (lesson != null)
            {
                lblTitle.Text = "Редактировать занятие";
                lblSubtitle.Text = "— измените данные занятия";
                btnSave.Text = "Сохранить изменения";

                dtpDate.Value = DateTime.Parse(lesson.LessonDate);
                cmbStudent.SelectedValue = lesson.StudentId;
                cmbSubject.SelectedItem = lesson.Subject;
                dtpStartTime.Value = DateTime.Parse(lesson.StartTime);
                if (lesson.EndTime != null)
                    dtpEndTime.Value = DateTime.Parse(lesson.EndTime);
                cmbStatus.Text = lesson.Status;
                txtNotes.Text = lesson.Notes;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem == null)
            {
                MessageBox.Show("Выберите ученика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStudent.Focus();
                return;
            }
            if (cmbSubject.SelectedItem == null)
            {
                MessageBox.Show("Выберите предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }

            try
            {
                int studentId = ((StudentItem)cmbStudent.SelectedItem).Id;
                string subject = cmbSubject.SelectedItem.ToString();
                string date = dtpDate.Value.ToString("yyyy-MM-dd");
                string startTime = dtpStartTime.Value.ToString("HH:mm");
                string endTime = dtpEndTime.Value.ToString("HH:mm");
                string status = cmbStatus.Text;

                if (lesson == null)
                {
                    db.AddLesson(studentId, subject, date, startTime, endTime, status, txtNotes.Text.Trim());
                    MessageBox.Show("Занятие добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.UpdateLesson(lesson.Id, studentId, subject, date, startTime, endTime, status, txtNotes.Text.Trim());
                    MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }

    public class StudentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}