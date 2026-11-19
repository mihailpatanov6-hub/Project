using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
            BuildUI();
            LoadGuideText();
        }
        private RichTextBox richTextBox;
        private Button btnClose;
        private void BuildUI()
        {
            Text = "Руководство пользователя";
            Size = new Size(900, 700);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimizeBox = false;
            MaximizeBox = true;

            // RichTextBox для текста
            richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.None,
                BackColor = Color.White
            };

            // Кнопка закрытия внизу
            btnClose = new Button
            {
                Text = "Закрыть",
                Size = new Size(150, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(124, 77, 255),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();
            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.FromArgb(94, 53, 177);
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.FromArgb(124, 77, 255);

            Controls.Add(richTextBox);
            Controls.Add(btnClose);

            // Позиционируем кнопку
            btnClose.Location = new Point(
                ClientSize.Width - btnClose.Width - 20,
                ClientSize.Height - btnClose.Height - 20
            );

            // Перемещаем кнопку при ресайзе
            Resize += (s, e) =>
            {
                btnClose.Location = new Point(
                    ClientSize.Width - btnClose.Width - 20,
                    ClientSize.Height - btnClose.Height - 20
                );
            };
        }
        private void LoadGuideText()
        {
            try
            {
                // Читаем текст прямо из ресурсов программы
                // "Руководство" — это имя, которое ты дал файлу в Resources.resx
                string guideText = Проект.Properties.Resources.Руководство;

                richTextBox.Text = guideText;
            }
            catch (Exception ex)
            {
                richTextBox.Text = "Ошибка загрузки руководства:\n" + ex.Message;
            }
        }
        private void GuideForm_Load(object sender, EventArgs e)
        {

        }
    }
}
