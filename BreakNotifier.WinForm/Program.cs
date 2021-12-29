using BreakNotifier.WinForm.Forms;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace BreakNotifier.WinForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeSettings();
            Application.Run(new Components.AppContext());
        }

        private static void InitializeSettings()
        {
            if (Properties.Settings.Default.FirstRun == false)
                return;

            var settingsForm = new SettingsForm();

            settingsForm.SaveSettings();
            settingsForm.Close();

            Properties.Settings.Default.FirstRun = false;
            Properties.Settings.Default.Save();
        }
    }
}
