using System;
using System.Windows.Forms;
using AgendaContactos.GUI.Autenticacion;

namespace AgendaContactos.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
