using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stream_Counter
{
    public partial class Form1 : Form
    {
        bool format;
        int outSeconds;
        string timeLeftText = "Time left: ";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (outSeconds<=0)
            {
                timer1.Stop();
                if (format)
                    hours.Enabled = true;
                else
                    hours.Enabled = false;
                minutes.Enabled = true;
                seconds.Enabled = true;
                minutesRadio.Enabled = true;
                hoursRadio.Enabled = true;
                endingTitle.Enabled = true;
                outSeconds = 0;
                hours.Value = 0;
                minutes.Value = 0;
                seconds.Value = 0;
                if(format)
                    timeLeft.Text = timeLeftText + "00:00:00";
                else
                    timeLeft.Text = timeLeftText + "00:00";
                StreamWriter sw = new StreamWriter("streamCounterOutput.txt", false, Encoding.ASCII);
                sw.Write(endingTitle.Text);
                sw.Close();
            }
            else
            {
                if (format)
                    formatTime1(outSeconds);
                else
                    formatTime2(outSeconds);
                outSeconds--;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {            
            calcTime();
            hours.Enabled = false;
            minutes.Enabled = false;
            seconds.Enabled = false;
            endingTitle.Enabled = false;
            minutesRadio.Enabled = false;
            hoursRadio.Enabled = false;
            timer1.Start();
            stopButton.Enabled = true;
            startButton.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(format)
                hours.Enabled = true;
            else
                hours.Enabled = false;
            minutes.Enabled = true;
            seconds.Enabled = true;
            endingTitle.Enabled = true;
            minutesRadio.Enabled = true;
            hoursRadio.Enabled = true;
            hours.Value = 0;
            minutes.Value = 0;
            seconds.Value = 0;
            if (format)
                timeLeft.Text = timeLeftText + "00:00:00";
            else
                timeLeft.Text = timeLeftText + "00:00";
            StreamWriter sw = new StreamWriter("streamCounterOutput.txt", false, Encoding.ASCII);
            sw.Write(endingTitle.Text);
            sw.Close();
            outSeconds = 0;
            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void mmRadio(object sender, EventArgs e)
        {
            hours.Enabled = false;
            hours.Value = 0;
            format = false;
            timeLeft.Text = timeLeftText + "00:00";
        }

        private void hhRadio(object sender, EventArgs e)
        {
            hours.Enabled = true;
            hours.Value = 0;
            format = true;
            timeLeft.Text = timeLeftText + "00:00:00";
        }

        public void calcTime()
        {
            int _hours = Convert.ToInt32(hours.Value);
            int _minutes = Convert.ToInt32(minutes.Value);
            int _seconds = Convert.ToInt32(seconds.Value);
            outSeconds = _hours * 3600 + _minutes * 60 + _seconds;
        }

        public void formatTime1(int _time)
        {
            StreamWriter sw = new StreamWriter("streamCounterOutput.txt", false, Encoding.ASCII);
            string _hours = (_time / 3600).ToString();
            int _remTime = _time - Convert.ToInt32(_hours) * 3600;
            string _minutes = (_remTime / 60).ToString();
            string _seconds = (_remTime - Convert.ToInt32(_minutes) * 60).ToString();

            if (Convert.ToInt32(_hours) < 10)
                _hours = "0" + _hours;
            if (Convert.ToInt32(_minutes) < 10)
                _minutes = "0" + _minutes;
            if (Convert.ToInt32(_seconds) < 10)
                _seconds = "0" + _seconds;
            string outputTime = _hours + ":" + _minutes + ":" + _seconds;
            timeLeft.Text = timeLeftText + outputTime;
            sw.Write(outputTime);
            sw.Close();
        }

        public void formatTime2(int _time)
        {
            StreamWriter sw = new StreamWriter("streamCounterOutput.txt", false, Encoding.ASCII);
            string _minutes = (_time / 60).ToString();
            string _seconds = (_time - Convert.ToInt32(_minutes) * 60).ToString();
            if (Convert.ToInt32(_minutes) < 10)
                _minutes = "0" + _minutes;
            if (Convert.ToInt32(_seconds) < 10)
                _seconds = "0" + _seconds;
            string outputTime = _minutes + ":" + _seconds;
            timeLeft.Text = timeLeftText + outputTime;
            sw.Write(outputTime);
            sw.Close();
        }
    }
}
