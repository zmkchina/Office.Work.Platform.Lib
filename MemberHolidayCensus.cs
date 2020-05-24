namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 职工假期信息统计
    /// </summary>
    public class MemberHolidayCensus
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
        public int Year { get; set; }

        /// <summary>
        /// 假期总天数
        /// </summary>
        public int HolidayCount { get; set; }
    }
}
