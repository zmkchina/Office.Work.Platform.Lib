using System;
using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义员工发放记录表
    /// </summary>
    public class MemberSalaryDto : ModelBaseClass
    {
        /// <summary>
        /// 记录的Id号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 发放单位名称
        /// </summary>
        public string PayUnitName { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        public string TableType { get; set; }

        /// <summary>
        /// 发生年份
        /// </summary>
        public int PayYear { get; set; }

        /// <summary>
        /// 发生月份
        /// </summary>
        public int PayMonth { get; set; }

        /// <summary>
        /// 员工Id号
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 发放的待遇项目明细
        /// </summary>
        public List<SalaryItem> SalaryItems { get; set; }

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
    /// <summary>
    /// 本类定义发放的具体项目及金额
    /// </summary>
    public class SalaryItem
    {
        /// <summary>
        /// 已发放的待遇项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 已发放的待遇项目金额
        /// </summary>
        public float Amount { get; set; }
    }
}
