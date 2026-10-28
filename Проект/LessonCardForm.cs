using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class LessonCardForm : Form
    {
        public LessonCardForm(Lesson lesson, string studentName)
        {
            InitializeComponent();

            btnBack.Click += (s, e) => this.Close();

            if (lesson != null)
            {
                // Форматируем дату
                string formattedDate = DateTime.TryParse(lesson.LessonDate, out var d)
                    ? d.ToString("dd.MM.yyyy")
                    : lesson.LessonDate;

                valDate.Text = formattedDate;
                valTime.Text = lesson.StartTime + (string.IsNullOrEmpty(lesson.EndTime) ? "" : " - " + lesson.EndTime);

                // Если имя ученика не передали, берем из базы (на всякий случай)
                valStudent.Text = !string.IsNullOrEmpty(studentName) ? studentName : $"ID {lesson.StudentId}";

                valSubject.Text = lesson.Subject ?? "—";
                valStatus.Text = lesson.Status ?? "—";
                valNotes.Text = string.IsNullOrEmpty(lesson.Notes) ? "—" : lesson.Notes;
            }
        }
    }
}