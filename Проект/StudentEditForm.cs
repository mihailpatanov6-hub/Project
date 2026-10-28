using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class StudentEditForm : Form
    {
        private DatabaseHelper db;
        private Student student;
        private void SetupAutoComplete()
        {
            // Фамилия
            var lastNames = db.GetExistingLastNames();
            txtLastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtLastName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            txtLastName.AutoCompleteCustomSource.AddRange(lastNames.ToArray());

            // Имя
            var firstNames = db.GetExistingFirstNames();
            txtFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFirstName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            txtFirstName.AutoCompleteCustomSource.AddRange(firstNames.ToArray());

            // Предмет
            var subjects = db.GetUniqueSubjects(); // ← теперь вернёт разбитые по запятой предметы
            txtSubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSubject.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSubject.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            txtSubject.AutoCompleteCustomSource.AddRange(subjects.ToArray());
        }
        public StudentEditForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            SetupAutoComplete();
        }
        public StudentEditForm(Student existingStudent)
        {
            InitializeComponent();
            db = new DatabaseHelper();
            student = existingStudent;
            FillFields();
            SetupAutoComplete();
        }

        private void FillFields()
        {
            if (student != null)
            {
                txtLastName.Text = student.LastName;
                txtFirstName.Text = student.FirstName;
                txtMiddleName.Text = student.MiddleName;
                txtPhone.Text = student.Phone;
                txtSubject.Text = student.Subject;
                txtClassLevel.Text = student.ClassLevel;
                txtNotes.Text = student.Notes;
            }
        }
        private void StudentEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("Введите хотя бы один предмет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject.Focus();
                return;
            }

            try
            {
                if (student == null)
                {
                    db.AddStudent(
                        txtLastName.Text.Trim(),
                        txtFirstName.Text.Trim(),
                        txtMiddleName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtSubject.Text.Trim(),
                        txtClassLevel.Text.Trim(),
                        txtNotes.Text.Trim()
                    );
                    MessageBox.Show("Ученик добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.UpdateStudent(
                        student.Id,
                        txtLastName.Text.Trim(),
                        txtFirstName.Text.Trim(),
                        txtMiddleName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtSubject.Text.Trim(),
                        txtClassLevel.Text.Trim(),
                        txtNotes.Text.Trim()
                    );
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
