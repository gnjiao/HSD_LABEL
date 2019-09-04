using GeneralLabelerStation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneralLabelerStation.ServiceMonitor
{
    public class SerivceMonitorHelper:Common.SingletionProvider<SerivceMonitorHelper>
    {
        /// <summary>
        /// 寿命监控列表
        /// </summary>
        public List<ServiceItem> MonitorList = new List<ServiceItem>();

        public void StartMonitor()
        {
            Task.Factory.StartNew(Monitor);
        }

        public void Monitor()
        {
            while(!Form_Main.Instance.bSystemExit)
            {
                Thread.Sleep(500);
                if(Form_Main.Instance.RunMode == 1)
                {
                    for (int i = 0; i < MonitorList.Count; ++i)
                    {
                        if (this.MonitorList[i].Enable && this.MonitorList[i].NeedService())
                        {
                            Form_Main.Instance.AlarmInfoInvoke($"[{this.MonitorList[i].ItemName}] 已超过使用时长 请维护后继续!!!", Form_Main.AlarmLevel.Err);
                        }
                    }
                }
            }
        }

        public static void Save()
        {
            SerializableHelper<List<ServiceItem>> helper = new SerializableHelper<List<ServiceItem>>(SerivceMonitorHelper.Instance.MonitorList);
            helper.JsonSerialize(Variable.sPath_Configure + "耗材管控.cfg");
        }

        public static void Load()
        {
            SerializableHelper<List<ServiceItem>> helper = new SerializableHelper<List<ServiceItem>>();
            var list = helper.DeJsonSerialize(Variable.sPath_Configure + "耗材管控.cfg");
            if (list != null)
                SerivceMonitorHelper.Instance.MonitorList = list;
        }
    }
}
