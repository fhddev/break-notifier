using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BreakNotifier.WinForm.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            FetchSettings();
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.BreakTimeInMilliseconds = TimeSpan.FromMinutes((double)breakTime.Value).TotalMilliseconds;

            Properties.Settings.Default.TimeBetweenBreaksInMilliseconds = TimeSpan.FromMinutes((double)timeBetweenBreaks.Value).TotalMilliseconds;

            Properties.Settings.Default.PlaySoundOnBreakStart = PlaySoundOnBreakStart.Checked;

            Properties.Settings.Default.PlaySoundOnBreakAboutEnding = playSoundOnBreakIsAboutToEnd.Checked;

            Properties.Settings.Default.PlaySoundOnBreakEnd = playSoundOnBreakEnd.Checked;

            HandleStartAtLogonSetting();

            Properties.Settings.Default.DisableWhenWinLock = disableWhenWinLocked.Checked;

            Properties.Settings.Default.EnableWhenWinUnlocked = enableWhenWindowsUnlocked.Checked;

            Properties.Settings.Default.Save();
        }

        private void FetchSettings()
        {
            breakTime.Value = (int)TimeSpan.FromMilliseconds(Properties.Settings.Default.BreakTimeInMilliseconds).TotalMinutes;

            timeBetweenBreaks.Value = (int)TimeSpan.FromMilliseconds(Properties.Settings.Default.TimeBetweenBreaksInMilliseconds).TotalMinutes;

            PlaySoundOnBreakStart.Checked = Properties.Settings.Default.PlaySoundOnBreakStart;

            playSoundOnBreakIsAboutToEnd.Checked = Properties.Settings.Default.PlaySoundOnBreakAboutEnding;

            playSoundOnBreakEnd.Checked = Properties.Settings.Default.PlaySoundOnBreakEnd;

            startAtLogon.Checked = Properties.Settings.Default.StartAtLogon;

            disableWhenWinLocked.Checked = Properties.Settings.Default.DisableWhenWinLock;

            enableWhenWindowsUnlocked.Checked = Properties.Settings.Default.EnableWhenWinUnlocked;
        }

        private void HandleStartAtLogonSetting()
        {
            Properties.Settings.Default.StartAtLogon = startAtLogon.Checked;

            // HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run
            var regKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            var regValue = "fhddev_BreakNotifier";

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(regKey, true);

            if (Properties.Settings.Default.StartAtLogon)
            {
                if (registryKey.GetValue(regValue) == null)
                    registryKey.SetValue(regValue, Application.ExecutablePath.ToString());

                return;
            }

            if (registryKey.GetValue(regValue) != null)
                registryKey.DeleteValue(regValue);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void btnEndBreak_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
