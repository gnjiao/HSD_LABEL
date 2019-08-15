﻿using GeneralLabelerStation.Common;
using GeneralLabelerStation.Param;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralLabelerStation.IO
{
    /// <summary>
    /// IO 管理者
    /// </summary>
    public class IOManager: Singleton<IOManager>
    {
        public ConcurrentDictionary<ushort, Axis_RunParam> Card = new ConcurrentDictionary<ushort, Axis_RunParam>();

        public  IOManager()
        {
        }
        
        /// <summary>
        /// 释放所有IO点
        /// </summary>
        public void ResetAllOut()
        {
            foreach(var card in Card.Values)
            {
                card.ResetAllIO_Out();
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetAllAxis()
        {
            foreach (var card in Card.Values)
            {
                card.StopAxis();
                Thread.Sleep(100);
                card.CleSts(true);
            }
        }

        /// <summary>
        /// 刷新IO
        /// </summary>
        public void updateIO()
        {
            while (!Form_Main.Instance.bSystemExit)
            {
                Thread.Sleep(5);

                for (ushort i = 0; i < Card.Count; ++i)
                {
                    Card[i].GetIO_IN();
                    Card[i].GetIO_Out();

                    if(Form_Main.Instance.RunMode != 1)
                    {
                        Card[i].GetAxisPos();
                        Card[i].GetAxisSts();
                    }
                }

                #region Feeder 状态
                Form_Main.Instance.bArr_IO_IN_Status.bIN_AfterRequest = Card[5].bArrIO_In[0];// R2.bArrIO_In[0];
                Form_Main.Instance.bArr_IO_IN_Status.bIN_Conveyor_BeforeReady = Card[5].bArrIO_In[1];// R2.bArrIO_In[1];
                Form_Main.Instance.bArr_IO_IN_Status.bIN_WorkSpace_IN = Card[5].bArrIO_In[2]; //R2.bArrIO_In[2];
                Form_Main.Instance.bArr_IO_IN_Status.bIN_WorkSpace_Out = Card[5].bArrIO_In[3]; //R2.bArrIO_In[3];
                Form_Main.Instance.bArr_IO_IN_Status.bIN_WorkSpace_Reach = Card[1].bArrIO_In[2];
                Form_Main.Instance.bArr_IO_IN_Status.bIN_WorkSpace_Reach = Card[1].bArrIO_In[2];

                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[0] = Card[1].bArrIO_In[0] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[1] = Card[6].bArrIO_In[0] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[2] = Card[6].bArrIO_In[2] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[3] = Card[6].bArrIO_In[3] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[4] = Card[2].bArrIO_In[0] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[5] = Card[7].bArrIO_In[0] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[6] = Card[7].bArrIO_In[2] == true ? 1 : 0;
                Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[7] = Card[7].bArrIO_In[3] == true ? 1 : 0;

                // Feeder 出料时间监控
                for (int i = 0; i < 2; ++i)
                {
                    FDExitLabel[i] = false;
                    for (int j = 0; j < 4; ++j)
                    {
                        if (Form_Main.Instance.bArr_IO_IN_Status.bIN_LabelReach[i * 4 + j] > 0)
                        {
                            if ((DateTime.Now - this.FDMonitor[i]).TotalMilliseconds > 500) // 间隔大于500ms认为新出一排料
                                FDReInputLabel[i] = true;

                            this.FDMonitor[i] = DateTime.Now;
                            FDExitLabel[i] = true;
                            break;
                        }
                    }
                }
                #endregion
            }
        }

        /// <summary>
        /// 设置 输出点
        /// </summary>
        /// <param name="axisNo">轴号</param>
        /// <param name="output">输出点</param>
        public short SetIO(ushort axisNo, ushort output)
        {
            return Card[axisNo].SetIO_OUT(output);
        }

        /// <summary>
        /// 设置 输出点
        /// </summary>
        /// <param name="axisNo">轴号</param>
        /// <param name="output">输出点</param>
        public short ResetIO(ushort axisNo, ushort output)
        {
            return Card[axisNo].ResetIO_OUT(output);
        }

        /// <summary>
        /// 获得 输入点状态
        /// </summary>
        /// <param name="axisNo">轴号0-7 8-15</param>
        /// <param name="input">输入点0-3</param>
        /// <returns></returns>
        public bool GetInput(ushort axisNo, ushort input)
        {
            return Card[axisNo].bArrIO_In[input];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="axisNo">轴号0-7 8-15</param>
        /// <param name="output">输出点4-7</param>
        /// <returns></returns>
        public bool GetOutput(ushort axisNo, ushort output)
        {
            output -= 4;
            return Card[axisNo].bArrIO_Out[output];
        }

        public DateTime[] FDMonitor = new DateTime[2];
        public bool[] FDExitLabel = new bool[2];

        /// <summary>
        /// FD新出一排料
        /// </summary>
        public bool[] FDReInputLabel = new bool[2];

        /// <summary>
        /// FD 获取状态锁
        /// </summary>
        public object FDLock = new object();
    }
}
