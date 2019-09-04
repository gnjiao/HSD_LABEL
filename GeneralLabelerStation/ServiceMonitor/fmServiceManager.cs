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
            if(this.tItemName.Text == string.Empty)
            {
                MessageBox.Show("监控名称不能为空!!");
                return;
            }

            ServiceItem item = null;
            if (IsAdd)
            {
                item = new ServiceItem();
                item.LastServiceTime = DateTime.Now;
            }
            else
            {
                item = SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index];
            }

            item.ItemName = this.tItemName.Text;
            item.Span = new TimeSpan(int.Parse(this.lMonitorValue.Text), 0, 0);
            item.Enable = this.cbEnable.Checked;

            if(IsAdd)
            {
                SerivceMonitorHelper.Instance.MonitorList.Add(item);
                this.AddRow(item);
            }
            else
            {
                SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index] = item;
                UpdateRow(this.dGVItem.SelectedRows[0].Index, item);
            }

            SerivceMonitorHelper.Save();
            this.bUpdate.Enabled = false;
        }

        public bool IsAdd = false;

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.tItemName.Text = string.Empty;
            this.tCurUse.Text = "0";
            this.cbEnable.Checked = true;
            this.lMonitorValue.Text = "24";
            this.bUpdate.Enabled = true;
            IsAdd = true;
            MessageBox.Show("已清空操作栏数据,输入操作栏的数据并点击 更新 按钮提交");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该监控项目!!!", "警告", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var item = SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index];
            SerivceMonitorHelper.Instance.MonitorList.Remove(item);
            this.dGVItem.Rows.RemoveAt(this.dGVItem.SelectedRows[0].Index);
            SerivceMonitorHelper.Save();
            this.bUpdate.Enabled = false;
        }

        private void dGVItem_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dGVItem.SelectedRows.Count > 0)
            {
                var item = SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index];
                IsAdd = false;
                this.bUpdate.Enabled = true;
                this.tItemName.Text = item.ItemName;
                this.cbEnable.Checked = item.Enable;
                this.tCurUse.Text = ToSpan(DateTime.Now - item.LastServiceTime);
                this.lMonitorValue.Text = item.Span.TotalHours.ToString();
            }
        }

        private void bServiced_Click(object sender, EventArgs e)
        {
            var item = SerivceMonitorHelper.Instance.MonitorList[this.dGVItem.SelectedRows[0].Index];
            item.LastServiceTime = DateTime.Now;
            SerivceMonitorHelper.Save();
        }

        private void FmServiceManager_Load(object sender, EventArgs e)
        {
            if(SerivceMonitorHelper.Instance.MonitorList.Count > 0)
            {
                for (int i = 0; i < SerivceMonitorHelper.Instance.MonitorList.Count; ++i)
                {
                    var item = SerivceMonitorHelper.Instance.MonitorList[i];
                    this.AddRow(item);
                }
            }
        }

        private void AddRow(ServiceItem item)
        {
            int i = this.dGVItem.Rows.Add();
            this.dGVItem.Rows[i].Cells[0].Value = item.Enable;
            this.dGVItem.Rows[i].Cells[1].Value = item.ItemName;
            this.dGVItem.Rows[i].Cells[2].Value = ToSpan(DateTime.Now - item.LastServiceTime);
            this.dGVItem.Rows[i].Cells[3].Value = ToSpan(item.Span);
            this.dGVItem.Rows[i].Cells[4].Value = (item.LastServiceTime).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void UpdateRow(int i, ServiceItem item)
        {
            this.dGVItem.Rows[i].Cells[0].Value = item.Enable;
            this.dGVItem.Rows[i].Cells[1].Value = item.ItemName;
            this.dGVItem.Rows[i].Cells[2].Value = ToSpan(DateTime.Now - item.LastServiceTime);
            this.dGVItem.Rows[i].Cells[3].Value = ToSpan(item.Span);
            this.dGVItem.Rows[i].Cells[4].Value = (item.LastServiceTime).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private string ToSpan(TimeSpan span)
        {
            return $"{span.TotalHours:N0}小时 {span.Minutes:N0}分";
        }
    }
}
