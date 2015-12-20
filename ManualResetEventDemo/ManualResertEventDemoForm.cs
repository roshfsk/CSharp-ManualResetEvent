using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualResetEventDemo
{
    public partial class ManualResertEventDemoForm : Form
    {
        ThreadManager threadManager = null;

        public ManualResertEventDemoForm()
        {
            InitializeComponent();
            threadManager = new ThreadManager();
        }

        private void btnWithSleepStart_Click(object sender, EventArgs e)
        {
            threadManager.startThreadWithSleep();
        }

        private void btnWithSleepStop_Click(object sender, EventArgs e)
        {
            threadManager.stopThreadWithSleep();
        }

        private void btnWithManualResetEventStart_Click(object sender, EventArgs e)
        {
            threadManager.startThreadWithManualResetEvent();
        }

        private void btnWithManualResetEventStop_Click(object sender, EventArgs e)
        {
            threadManager.stopThreadWithManualResetEvent();
        }
    }
}
