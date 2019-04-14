using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class TimerLauncher : Form
    {
        private TimerGui _gui;

        public TimerLauncher()
        {
            InitializeComponent();
        }

        public TimerLauncher(TimerGui gui)
        {
            InitializeComponent();
            _gui = gui;
        }

        private void TimerLauncher_Load(object sender, EventArgs e)
        {

        }

        private bool ReadUi(out TimerPreferences prefs)
        {
            prefs = new TimerPreferences();
            
            // Reading action
            if (NoActionRadbut.Checked)
                prefs.Action = TimerPreferences.FinalAction.None;
            else if (HibernationRadbut.Checked)
                prefs.Action = TimerPreferences.FinalAction.Hibernation;
            else
                prefs.Action = TimerPreferences.FinalAction.ShutDown;

            bool parsingOk = true;

            parsingOk &= Int32.TryParse(HoursBox.Text, out prefs.DurationHours);
            parsingOk &= Int32.TryParse(MinutesBox.Text, out prefs.DurationMinutes);
            parsingOk &= Int32.TryParse(SecondsBox.Text, out prefs.DurationSeconds);

            prefs.MakeWarning = WarningBox.Checked;
            if (prefs.MakeWarning)
            {
                parsingOk &= Int32.TryParse(WarningTimeBox.Text, out prefs.WarningSecondsBeforeEnd);
            }
            else
            {
                prefs.WarningSecondsBeforeEnd = 0;
            }

            prefs.MakeSoundSignal = SignalBox.Checked;

            prefs.HiddenLaunchEnabled = HiddenLaunchBox.Checked;

            return parsingOk;
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            TimerPreferences prefs;
            bool readingGuiOk = ReadUi(out prefs);

            if (readingGuiOk)
            {
                _gui.Launch(prefs);
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect data format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WarningBox_CheckedChanged(object sender, EventArgs e)
        {
            WarningTimeBox.Enabled = WarningBox.Checked;
        }
    }
}
