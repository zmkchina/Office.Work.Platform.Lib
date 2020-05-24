namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 职工休假信息查询条件类
    /// </summary>
    public class MemberHolidaySearch
    {

        /// <summary>
        /// 记录Id号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 所属职工的Id号（身份证号）
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 假期开始时间年份
        /// </summary>
        public int OccurYear { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 假期类型
        /// </summary>
        public string HolidayType { get; set; }
        /// <summary>
        /// 更新记录的人员
        /// </summary>
        public string UserId { get; set; }


    }
}
