namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义待遇发放配置信息查询条件类。
    /// </summary>
    public class MemberPaySetSearch
    {
        /// <summary>
        /// 单位名称：表明是哪个单位的待遇发放配置信息
        /// </summary>
        public string UnitName { get; set; }
        /// <summary>
        /// 主键 同时也是 外键：指向员工信息，表明该条配置是对哪个用户的。
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 发放哪些待遇项目，项目之间用,号分隔
        /// </summary>
        public string PayItemIds { get; set; }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
