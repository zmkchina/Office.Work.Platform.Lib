using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 职工社会交纳记录查询条件类
    /// </summary>
    public class MemberPayMonthInsuranceSearch
    {

        public string Id { get; set; }
        public string MemberId { get; set; }
        /// 交纳年份
        /// </summary>
        public int PayYear { get; set; }
        /// <summary>
        /// 交纳月份
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
