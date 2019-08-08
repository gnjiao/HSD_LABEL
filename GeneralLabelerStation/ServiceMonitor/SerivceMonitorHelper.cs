using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLabelerStation.ServiceMonitor
{
    public class SerivceMonitorHelper:Common.SingletionProvider<SerivceMonitorHelper>
    {
        /// <summary>
        /// 寿命监控列表
        /// </summary>
        public List<ServiceItem> MonitorList = new List<ServiceItem>();

        public void Monitor()
        {
            while(!Form_Main.Instance.bSystemExit)
            {
                if(Form_Main.Instance.RunMode == 1)
                {
                    for (int i = 0; i < MonitorList.Count; ++i)
                    {
                        if (this.MonitorList[i].Enable && this.MonitorList[i].NeedService())
                        {
                            //Form_Main.Instance.Invoke();
                        }
                    }
                }
            }
        }
    }
}
