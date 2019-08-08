using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralLabelerStation.ServiceMonitor
{
    public partial class fmServiceManager : Form
    {
        public fmServiceManager()
        {
            InitializeComponent();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (this.cbMonitorType.SelectedIndex == 0)
            {
                MonitorTimeSpan timeSpan = new MonitorTimeSpan();
            }
            else if (this.cbMonitorType.SelectedIndex == 1)
            {
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void cbMonitorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbMonitorType.SelectedIndex == 0)
            {
                this.lMonitor.Text = "监控时长(小时)";
            }else if(this.cbMonitorType.SelectedIndex == 1)
            {
                this.lMonitor.Text = "监控次数(pcs)";
            }
        }
    }
}
