using System;
using System.Drawing;
using System.Windows.Forms;

namespace Проект
{
    public partial class Schedule_page : Form
    {
        public Schedule_page()
        {
            InitializeComponent();

            // Чтобы календарь при открытии показывал список занятий на сегодня
            monthCalendar.DateSelected += (s, e) => UpdateDateLabel(e.Start);
        }

        private void UpdateDateLabel(DateTime date)
        {
            lblSelectedDate.Text = $"Занятия на {date:dd.MM.yyyy}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет открываться форма добавления занятия", "Заглушка");
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите занятие в списке", "Внимание");
                return;
            }
            MessageBox.Show("Здесь будет открываться форма редактирования", "Заглушка");
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите занятие в списке", "Внимание");
                return;
            }

            var result = MessageBox.Show("Удалить выбранное занятие?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Здесь будет удаление из базы", "Заглушка");
            }
        }
    }
}