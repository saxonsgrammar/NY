using System;
using System.Windows.Forms;

namespace NY
{
    public partial class Form1 : Form
    {
        private static Timer vTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowTime);
            vTimer.Interval = 30;
            vTimer.Start();
        }
        private void ShowTime(object vObj, EventArgs e)
        {
            labelTime.Text = Convert.ToString((new DateTime(2024, 1, 1) - DateTime.Now).TotalSeconds);
        }
    }
}