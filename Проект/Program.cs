using System;
using System.Windows.Forms;
using Проект.Data;

namespace Проект
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var db = new DatabaseHelper();
            db.InitializeDatabase();

            Application.Run(new Main_page());
        }
    }
}