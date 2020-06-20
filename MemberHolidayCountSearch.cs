namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 员工绩效考核信息查询类
    /// </summary>
    public class MemberHolidayCountSearch
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
        /// 单位名称
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
