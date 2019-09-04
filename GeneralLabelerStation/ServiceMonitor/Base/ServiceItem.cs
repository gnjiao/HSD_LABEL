using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLabelerStation.ServiceMonitor
{
    /// <summary>
    /// 寿命管控项
    /// </summary>
    public class ServiceItem
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable = true;

        /// <summary>
        /// 上一次保养的时间
        /// </summary>
        public DateTime LastServiceTime = new DateTime();

        /// <summary>
        /// 可使用时长
        /// </summary>
        public TimeSpan Span = new TimeSpan(12, 0, 0);

        /// <summary>
        /// 管控项目名称
        /// </summary>
        public string ItemName
        {
            get; set;
        } = "名称";

        /// <summary>
        /// 是否需要维护
        /// </summary>
        /// <returns></returns>
        public bool NeedService()
        {
            return (DateTime.Now - this.LastServiceTime) > this.Span;
        }

        /// <summary>
        /// 维护
        /// </summary>
        public void Update()
        {
            this.LastServiceTime = DateTime.Now;
        }
    }
}
