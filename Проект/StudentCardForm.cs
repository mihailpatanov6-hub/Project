using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    public partial class StudentCardForm : Form
    {
        public StudentCardForm(Student student)
        {
            InitializeComponent();

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
            }
        }
    }
}