using System;
using System.IO;
using System.Xml.Serialization;

namespace CountdownTimer
{
    [Serializable]
    public struct TimerPreferences
    {
        public enum FinalAction
        {
            None, Hibernation, ShutDown
        }

        // Finishing
        public FinalAction Action;

        // Main preferences
        public int DurationHours, DurationMinutes, DurationSeconds;
        public bool MakeSoundSignal;
        public bool HiddenLaunchEnabled;

        // Warning
        public bool MakeWarning;
        public int WarningSecondsBeforeEnd;

        public static TimerPreferences Deserialize(string xml)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(TimerPreferences));

            TextReader reader = new StringReader(xml);

            TimerPreferences prefs = (TimerPreferences) formatter.Deserialize(reader);

            return prefs;
        }

        public static string Serialize(TimerPreferences prefs)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(TimerPreferences));

            StringWriter writer = new StringWriter();

            formatter.Serialize(writer, prefs);

            return writer.ToString();
        }
    }
}
