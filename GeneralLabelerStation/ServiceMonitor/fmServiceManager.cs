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
            if(this.cbMonitorType.Enabled)//add
            {

            }
            else
            {

            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.cbMonitorType.Enabled = true;
            this.tItemName.Text = string.Empty;
            this.tCurUse.Text = "0";
            this.cbEnable.Checked = true;
            this.cbMonitorType.SelectedIndex = 0;
            this.lMonitorValue.Text = "0";
            MessageBox.Show("已清空操作栏数据,输入操作栏的数据并点击 更新 按钮提交");
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

        private void dGVItem_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dGVItem.SelectedRows.Count > 0)
            {
                this.cbMonitorType.Enabled = false;
                var item = SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index];
                this.tItemName.Text = item.ItemName;
                //this.tCurUse.Text = item.LastServiceTime
            }
        }

        private void bServiced_Click(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }
    }
}
