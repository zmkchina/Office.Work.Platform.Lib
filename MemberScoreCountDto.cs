using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义员工绩效统计信息
    /// </summary>
    public class MemberScoreCountDto 
    {
        /// <summary>
        /// 员工 Id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 统计年份
        /// </summary>
        public string YearNumber { get; set; }

        /// <summary>
        /// 具体得分
        /// </summary>
        public float ScoreCount { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        public DateTime CountDate { get; set; }

        /// <summary>
        /// 内部人员排序(此字段值来源于Member表）
        /// </summary>
        public int MemberIndex { get; set; }

        /// <summary>
        /// 考核单位
        /// </summary>
        public string ScoreUnitName { get; set; }

        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
