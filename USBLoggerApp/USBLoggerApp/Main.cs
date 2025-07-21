using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace USBLoggerApp
{
    public partial class Main : Form
    {
        private int eventCount = 0;
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        public Main()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DEVICECHANGE)
            {
                string message = "";
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                    message = "USB Connected";
                else if (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                    message = "USB Disconnected";
                else
                    return;

                eventCount++;
                string logLine = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + message;
                LogEvent(logLine);
                UpdateUI(message);
            }
        }

        private void LogEvent(string logLine)
        {
            string path = Application.StartupPath + @"\usb_log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.WriteLine(logLine);
        }

        private void UpdateUI(string eventText)
        {
            lblEvent.Text = "Event: " + eventText;
            lblTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
            lblCount.Text = "Total Events: " + eventCount.ToString();
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\usb_log.txt";
            if (File.Exists(path))
                Process.Start("notepad.exe", path);
            else
                MessageBox.Show("Log file not found.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
