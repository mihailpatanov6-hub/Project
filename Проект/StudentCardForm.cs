using System;
using System.Drawing;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class StudentCardForm : Form
    {
        private DatabaseHelper db;

        public StudentCardForm(Student student)
        {
            InitializeComponent();
            db = new DatabaseHelper();

            btnBack.Click += (s, e) => this.Close();

            if (student != null)
            {
                // Заполняем поля данными из БД
                valLastName.Text = student.LastName ?? "—";
                valFirstName.Text = student.FirstName ?? "—";
                valMiddleName.Text = string.IsNullOrEmpty(student.MiddleName) ? "—" : student.MiddleName;
                valPhone.Text = string.IsNullOrEmpty(student.Phone) ? "—" : student.Phone;
                valSubject.Text = student.Subject ?? "—";
                valClassLevel.Text = string.IsNullOrEmpty(student.ClassLevel) ? "—" : student.ClassLevel;
                valNotes.Text = string.IsNullOrEmpty(student.Notes) ? "—" : student.Notes;

                // Загружаем историю занятий
                LoadLessons(student.Id);
            }
        }

        private void LoadLessons(int studentId)
        {
            dgvLessons.Rows.Clear();

            // Получаем занятия из БД
            var lessons = db.GetLessonsByStudent(studentId);

            foreach (var l in lessons)
            {
                // Форматируем дату из "yyyy-MM-dd" в "dd.MM.yyyy"
                string formattedDate = DateTime.TryParse(l.LessonDate, out var d)
                    ? d.ToString("dd.MM.yyyy")
                    : l.LessonDate;

                string timeStr = l.StartTime + (l.EndTime != null ? " - " + l.EndTime : "");

                // Добавляем строку в таблицу
                dgvLessons.Rows.Add(formattedDate, timeStr, l.Subject, l.Status);
            }
        }
    }
}