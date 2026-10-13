using System;
using System.Windows.Forms;

namespace Проект
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main_page());
        }
    }
}