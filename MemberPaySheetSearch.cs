using System.ComponentModel.DataAnnotations;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 员工待遇表查询类
    /// </summary>
    public class MemberPaySheetSearch
    {

        /// <summary>
        /// 发生年份
        /// </summary>
        public int PayYear { get; set; }

        /// <summary>
        /// 发生月份
        /// </summary>
        public int PayMonth { get; set; }
        /// <summary>
        /// 发放单位名称
        /// </summary>
        [Required]
        public string PayUnitName { get; set; }

        /// <summary>
        /// 用工性质
        /// </summary>
        public string MemberType { get; set; }
        /// <summary>
        /// 查询的待遇表类型
        /// </summary>
        public string PayTableType { get; set; }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        [Required]
        public string UserId { get; set; }
    }
}
