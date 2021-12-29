using BreakNotifier.WinForm.Forms;
using BreakNotifier.WinForm.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace BreakNotifier.WinForm.Components
{
    public class AppContext : ApplicationContext
    {
        private NotifyIcon _notifyIcon;

        private System.Timers.Timer _timer;

        private ToolStripItem _toggleMenuItem;

        public AppContext()
        {
            InitializeComponents();

            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SessionSwitchHandler);
        }

        private void InitializeComponents()
        {
            _notifyIcon = new NotifyIcon();

            _timer = new System.Timers.Timer();

            var menu = new ContextMenuStrip();

            _toggleMenuItem = menu.Items.Add("Disable", null, Toggle);
            menu.Items.Add("-");
            menu.Items.Add("Preferences", null, Settings);
            menu.Items.Add("-");
            menu.Items.Add("Exit", null, Exit);

            _notifyIcon.ContextMenuStrip = menu;
            _notifyIcon.Icon = new Icon(Resources.BN_Logo, 100, 100);
            _notifyIcon.Visible = true;

            UpdateTimer();
            _timer.Enabled = true;
            _timer.Elapsed += TimerElapsedEventHandler;

            if(Properties.Settings.Default.StartAtLogon)
            {

            }
        }

        private void UpdateTimer()
        {
            _timer.Interval = (int)Properties.Settings.Default.TimeBetweenBreaksInMilliseconds;
        }

        private void TimerElapsedEventHandler(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();

            var countdownForm = new CountdownForm();

            countdownForm.ShowDialog();

            _timer.Start();
        }

        private void SessionSwitchHandler(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock && Properties.Settings.Default.DisableWhenWinLock)
            {
                _timer.Stop();

                _toggleMenuItem.Text = "Enable";
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock && Properties.Settings.Default.EnableWhenWinUnlocked)
            {
                _timer.Start();

                _toggleMenuItem.Text = "Disable";
            }
        }

        private void Toggle(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;

            if (_timer.Enabled)
                _timer.Stop();
            else
                _timer.Start();

            item.Text = _timer.Enabled ? "Disable" : "Enable";
        }

        private void Settings(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms)
                if (form is SettingsForm) return;

            (new SettingsForm()).ShowDialog();

            UpdateTimer();
        }

        private void Exit(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }

    }
}
