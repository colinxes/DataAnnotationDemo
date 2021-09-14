using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace DataAnnotationDemo
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            Application.Run(new MainForm());
        }
    }
}
