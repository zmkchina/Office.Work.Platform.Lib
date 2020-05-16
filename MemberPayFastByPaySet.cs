namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义快速发放记录的条件信息类。
    /// </summary>
    public class MemberPayFastByPaySet
    {
        /// <summary>
        /// 欲发放年份
        /// </summary>
        public int PayYear { get; set; }
        /// <summary>
        /// 欲发放月份
        /// </summary>
        public int PayMonth { get; set; }
        /// <summary>
        /// 单位名称：表明是哪个单位的待遇发放配置信息
        /// </summary>
        public string PayUnitName { get; set; }
        /// <summary>
        /// 主键 同时也是 外键：指向员工信息，表明该条配置是对哪个用户的。
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 人员身份性质
        /// </summary>
        public string MemberType { get; set; }

        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
