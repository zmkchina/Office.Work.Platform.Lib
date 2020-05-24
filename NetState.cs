using System;

namespace Office.Work.Platform.Lib
{
    public class NetState
    {
        public NetState()
        {
            NoteCount = PlanCount = State = 0;
        }
        /// <summary>
        /// 服务器返回的状态200：表示正常。
        /// </summary>
        public int State { get; set; }
        public DateTime ServerTime { get; set; }
        /// <summary>
        /// 系统计划总数
        /// </summary>
        public int PlanCount { get; set; }
        /// <summary>
        /// 系统备忘总数
        /// </summary>
        public int NoteCount { get; set; }
    }
}
