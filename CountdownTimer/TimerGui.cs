using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountdownTimer.Properties;

namespace CountdownTimer
{
    public partial class TimerGui : Form
    {
        private TimerPreferences _timerPreferences;
        private DateTime _finishingTime;
        private NotifyIcon _notifyIcon;

        private bool _prevNegative = false;
        private bool _wasWarning = false;

        public TimerGui()
        {
            InitializeComponent();
        }

        public void Launch (TimerPreferences preferences)
        {
            _timerPreferences = preferences;

            DateTime now = DateTime.Now;

            _finishingTime = now + new TimeSpan(preferences.DurationHours, preferences.DurationMinutes,
                                 preferences.DurationSeconds);

            MainCounter.Start();
        }

        private void MainCounter_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = _finishingTime - DateTime.Now;
            TimeSpan absDelta = delta.Duration();
            bool negative = delta.Ticks < 0;
            TimerDisplay.Text = GetStr(absDelta.Hours) + @":" + GetStr(absDelta.Minutes) + @":" + GetStr(absDelta.Seconds);
            if (negative)
                TimerDisplay.Text = "-" + TimerDisplay.Text;

            bool finish = negative && !_prevNegative;

            _prevNegative = negative;
            if (finish)
            {
                OnFinish();
            }

            if (_timerPreferences.MakeWarning && !_wasWarning &&
                delta.TotalSeconds < _timerPreferences.WarningSecondsBeforeEnd)
            {
                _wasWarning = true;
                OnWarning();
            }
        }

        private void OnFinish()
        {
            switch (_timerPreferences.Action)
            {
                case TimerPreferences.FinalAction.None:
                    MessageBox.Show("Finish!");
                    break;
                case TimerPreferences.FinalAction.Hibernation:
                    // TODO
                    break;
                case TimerPreferences.FinalAction.ShutDown:
                    // TODO
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnWarning()
        {
            ShowGui();

            MessageBox.Show("Timer warning!");
        }

        private static string GetStr(int number)
        {
            string val = number.ToString("00");
            return val;
        }

        private void TimerGui_Load(object sender, EventArgs e)
        {
            TimerLauncher launcher = new TimerLauncher(this);
            launcher.ShowDialog();

            if(MainCounter.Enabled == false)
                Application.Exit();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            ShowGui();
            Application.Exit();
        }

        private void HideGuiClick(object sender, EventArgs e)
        {
            _notifyIcon = new NotifyIcon()
            {
                Icon = Resources.icon, 
                ContextMenu = new ContextMenu(new MenuItem[]
                    {new MenuItem("Show", ShowGuiClick)}),
                Visible = true
            };

            _notifyIcon.DoubleClick += ShowGuiClick;

            Hide();
        }

        private void ShowGuiClick(object sender, EventArgs e)
        {
            ShowGui();
        }

        private void ShowGui()
        {
            Show();
            if (_notifyIcon != null)
            {
                _notifyIcon.Visible = false;
                _notifyIcon = null;
            }
        }
    }
}
