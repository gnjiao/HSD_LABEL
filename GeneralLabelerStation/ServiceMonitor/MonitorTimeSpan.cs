using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLabelerStation.ServiceMonitor
{
    public class MonitorTimeSpan : ServiceItem
    {
        public TimeSpan Span = new TimeSpan(12, 0, 0);

        public override bool NeedService()
        {
            return ((DateTime.Now - this.LastServiceTime) > Span);
        }

        public override string Remark()
        {
            return $"[{this.ItemName}] 已使用超过 {Span} 时间 请维护!!!";
        }

        public override void Update()
        {
            this.LastServiceTime = DateTime.Now;
        }
    }
}
