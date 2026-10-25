using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Проект
{
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();

            // Обработка наведения на карточки
            foreach (var card in new[] { pnlStudents, pnlSchedule, pnlSummary })
            {
                card.MouseEnter += (s, e) => HoverCard((Panel)s, true);
                card.MouseLeave += (s, e) => HoverCard((Panel)s, false);
            }

            // Клики по карточкам 
            pnlStudents.Click += (s, e) => OpenStudents();
            lblStudentsTitle.Click += (s, e) => OpenStudents();
            lblStudentsDesc.Click += (s, e) => OpenStudents();
            picStudentsIcon.Click += (s, e) => OpenStudents();

            pnlSchedule.Click += (s, e) => OpenSchedule();
            lblScheduleTitle.Click += (s, e) => OpenSchedule();
            lblScheduleDesc.Click += (s, e) => OpenSchedule();
            picScheduleIcon.Click += (s, e) => OpenSchedule();

            pnlSummary.Click += (s, e) => OpenSummary();
            lblSummaryTitle.Click += (s, e) => OpenSummary();
            lblSummaryDesc.Click += (s, e) => OpenSummary();
            picSummaryIcon.Click += (s, e) => OpenSummary();

            // Меню
            miExit.Click += (s, e) => this.Close();
            miAbout.Click += (s, e) => ShowAbout();
        }

        private void HoverCard(Panel card, bool hover)
        {
            card.BackColor = hover
                ? Color.FromArgb(237, 228, 255) 
                : Color.White;
        }

        private void OpenStudents()
        {
            var f = new Students_page();
            f.ShowDialog();
        }

        private void OpenSchedule()
        {
            var f = new Schedule_page();
            f.ShowDialog();
        }

        private void OpenSummary()
        {
            MessageBox.Show("Открыть окно «Сводка»", "Заглушка");
        }

        private void ShowAbout()
        {
            MessageBox.Show(
                "Система учёта репетиторских занятий\n" +
                "Версия 0.1\n\n" +
                "Разработчики: студенты 2 курса\n" +
                "2025 год",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}