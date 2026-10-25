using System;
using System.Drawing;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class Students_page : Form
    {
        private DatabaseHelper db;

        public Students_page()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            LoadStudents();

            // Кнопки, которых нет в дизайнере
            btnBack.Click += (s, e) => this.Close();

            dgvStudents.CellDoubleClick += dgvStudents_CellDoubleClick;
            // Поиск
            txtSearch.TextChanged += (s, e) => FilterStudents();

            // Наведение на кнопки
            foreach (var b in new[] { btnAdd, btnEdit, btnDelete })
            {
                b.MouseEnter += (s, e) => HoverButton((Button)s, true);
                b.MouseLeave += (s, e) => HoverButton((Button)s, false);
            }

            btnBack.MouseEnter += (s, e) =>
                btnBack.ForeColor = Color.FromArgb(94, 53, 177);
            btnBack.MouseLeave += (s, e) =>
                btnBack.ForeColor = Color.FromArgb(124, 77, 255);
        }

        private void HoverButton(Button b, bool hover)
        {
            if (b == btnAdd)
                b.BackColor = hover ? Color.FromArgb(94, 53, 177) : Color.FromArgb(124, 77, 255);
            else
                b.BackColor = hover ? Color.FromArgb(237, 228, 255) : Color.White;
        }

        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();
            var students = db.GetAllStudents();

            foreach (var s in students)
            {
                int rowIndex = dgvStudents.Rows.Add(
                    s.FullName, s.Phone ?? "", s.Subject,
                    s.ClassLevel ?? "", s.Notes ?? ""
                );
                dgvStudents.Rows[rowIndex].Tag = s.Id;
            }

            this.Text = $"Ученики — Всего: {students.Count}";
        }

        private void FilterStudents()
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadStudents();
                return;
            }

            dgvStudents.Rows.Clear();
            var students = db.SearchStudents(query);

            foreach (var s in students)
            {
                int rowIndex = dgvStudents.Rows.Add(
                    s.FullName, s.Phone ?? "", s.Subject,
                    s.ClassLevel ?? "", s.Notes ?? ""
                );
                dgvStudents.Rows[rowIndex].Tag = s.Id;
            }

            this.Text = $"Ученики — Найдено: {students.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new StudentEditForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadStudents();
        }
        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Игнорируем клики по заголовкам
            if (e.RowIndex < 0) return;

            // Получаем ID ученика
            var row = dgvStudents.Rows[e.RowIndex];
            if (row.Tag == null) return;

            int id = Convert.ToInt32(row.Tag);
            var student = db.GetStudentById(id);

            if (student != null)
            {
                // Открываем карточку
                using var form = new StudentCardForm(student);
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.Tag == null)
            {
                MessageBox.Show("Выберите ученика");
                return;
            }

            int id = Convert.ToInt32(dgvStudents.CurrentRow.Tag);
            var student = db.GetStudentById(id);
            if (student == null) return;

            using var form = new StudentEditForm(student);
            if (form.ShowDialog() == DialogResult.OK)
                LoadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.Tag == null)
            {
                MessageBox.Show("Выберите ученика в таблице", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvStudents.CurrentRow.Tag);
            string fio = dgvStudents.CurrentRow.Cells["colFio"].Value?.ToString() ?? "";

            var result = MessageBox.Show(
                $"Удалить ученика \"{fio}\" навсегда?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.DeleteStudent(id);
                LoadStudents();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Пустой, так как подписка в конструкторе
        }
    }
}