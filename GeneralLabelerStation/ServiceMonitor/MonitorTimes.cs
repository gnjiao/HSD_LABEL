using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLabelerStation.ServiceMonitor
{

    public class MonitorTimes : ServiceItem
    {
        /// <summary>
        /// 可使用次数
        /// </summary>
        public int ForbitTimes = 10000;

        /// <summary>
        /// 当前项目使用次数
        /// </summary>
        public int Times = 0;

        public override bool NeedService()
        {
            return Times >= ForbitTimes;
        }

        public override string Remark()
        {
            return $"[{this.ItemName}] 使用超过使用{this.ForbitTimes}次 请维护!!!";
        }

        public override void Update()
        {
            this.Times = 0;
        }
    }
}
