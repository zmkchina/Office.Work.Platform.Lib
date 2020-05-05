using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工类
    /// </summary>
    public class MemberPaySearch
    {
        /// <summary>
        /// 记录Id号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 员工Id号
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 待遇项目Id号
        /// </summary>
        public string MemberPayItemId { get; set; }

        /// <summary>
        /// 发生年份
        /// </summary>
        public int PayYear { get; set; }

        /// <summary>
        /// 发生月份
        /// </summary>
        public int PayMonth { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
