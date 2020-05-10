using System.ComponentModel.DataAnnotations;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义待遇发放配置信息查询条件类。
    /// </summary>
    public class MemberPaySetSearch
    {
        /// <summary>
        /// 构造函数，至少需提供两个值。
        /// </summary>
        /// <param name="PayUnitName">单位名称,必须提供</param>
        /// <param name="UserId">操作人员ID,必须提供</param>
        public MemberPaySetSearch(string PayUnitName, string UserId)
        {
            this.PayUnitName = PayUnitName;
            this.UserId = UserId;
        }
        /// <summary>
        /// 单位名称：表明是哪个单位的待遇发放配置信息
        /// </summary>
        [Required]
        public string PayUnitName { get; set; }
        /// <summary>
        /// 主键 同时也是 外键：指向员工信息，表明该条配置是对哪个用户的。
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 发放哪些待遇项目，项目之间用,号分隔
        /// </summary>
        public string PayItemIds { get; set; }

        /// <summary>
        /// 人员身份性质
        /// </summary>
        public string MemberType { get; set; }

        /// <summary>
        /// 操作人员ID
        /// </summary>
        [Required]
        public string UserId { get; set; }
    }
}
