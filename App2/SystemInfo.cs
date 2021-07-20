using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class SystemInfo : UserControl
    {
        public Timer timer = new Timer();
        Process proc = Process.GetCurrentProcess();
        public SystemInfo()
        {
            InitializeComponent();
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Bar1.Value = proc.PrivateMemorySize64 / 2;
        }
    }
}
