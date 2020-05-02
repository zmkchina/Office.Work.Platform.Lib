using System;
namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工月度待遇发放查询类
    /// </summary>
    public class MemberPayMonthOfficialSearch
    {
        public string Id { get; set; }
        public string MemberId { get; set; }
        /// 发放年份
        /// </summary>
        public int PayYear { get; set; }
        /// <summary>
        /// 发放月份
        /// </summary>
        public int PayMonth { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 本月备注
        /// </summary>
        public string Remark { get; set; }
    }
}
