using System;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace BreakNotifier.WinForm.Forms
{
    public partial class CountdownForm : Form
    {
        private string countdownStringFormat = "{0} : {1} : {2}";

        private TimeSpan _countdown { get; set; }

        public CountdownForm()
        {
            InitializeComponent();

            PlayStartSound();

            _countdown = TimeSpan.FromMilliseconds(Properties.Settings.Default.BreakTimeInMilliseconds);

            UpdateCountdownLabel();

            InitializeTimer();
        }

        private void PlayStartSound()
        {
            if (Properties.Settings.Default.PlaySoundOnBreakStart)
                Console.Beep();
        }

        private void PlayEndSound()
        {
            if (Properties.Settings.Default.PlaySoundOnBreakEnd)
                Console.Beep();
        }

        private void PlayEndingSound()
        {
            if(_countdown.TotalSeconds <= 10 && Properties.Settings.Default.PlaySoundOnBreakAboutEnding)
                Console.Beep();
        }

        private void UpdateCountdownLabel()
        {
            var hours = _countdown.Hours;

            var minutes = _countdown.Minutes;

            var seconds = _countdown.Seconds;

            PlayEndingSound();

            lbl_Countdown.Text = string.Format(countdownStringFormat,
                hours == 0 ? "00" : hours < 10 ? $"0{hours}" : hours,
                minutes == 0 ? "00" : minutes < 10 ? $"0{minutes}" : minutes,
                seconds == 0 ? "00" : seconds < 10 ? $"0{seconds}" : seconds);
        }

        private void InitializeTimer()
        {
            var countdownTimer = new System.Timers.Timer();

            countdownTimer.Interval = _countdown.TotalMilliseconds;
            countdownTimer.Elapsed += CountdownTimerElapsedEventHandler;
            countdownTimer.Enabled = true;
        }

        private void CountdownTimerElapsedEventHandler(object sender, ElapsedEventArgs e)
        {
            if (!InvokeRequired) return;

            PlayEndSound();

            Invoke((Action)(() => Close()));
        }

        private void timer_Countdown_Tick(object sender, EventArgs e)
        {
            _countdown = TimeSpan.FromSeconds(_countdown.TotalSeconds - 1);

            UpdateCountdownLabel();
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
