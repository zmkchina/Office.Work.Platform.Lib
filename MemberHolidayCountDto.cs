using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 职工假期信息统计
    /// </summary>
    public class MemberHolidayCountDto
    {
        /// <summary>
        /// 所属职工的Id号（身份证号）
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 职工姓名
        /// </summary>
        public string MemberName { get; set; }
        
        /// <summary>
        /// 统计年份
        /// </summary>
        public string YearNumber { get; set; }

        /// <summary>
        /// 事假总天数
        /// </summary>
        public float PersonalLeaveCount { get; set; }

        /// <summary>
        /// 病假总天数
        /// </summary>
        public float SickLeaveCount { get; set; }

        /// <summary>
        /// 年休假总天数
        /// </summary>
        public float AnnualCount { get; set; }

        /// <summary>
        /// 考核单位
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 其他假期总天数
        /// </summary>
        public float OtherHolidayCount { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        public DateTime CountDate { get; set; }
    }
}
