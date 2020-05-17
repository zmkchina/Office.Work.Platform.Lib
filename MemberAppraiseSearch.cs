namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工年度考核情况查询条件类
    /// </summary>
    public class MemberAppraiseSearch
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
        /// 考核年份
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// 考核结果
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 更新记录的人员
        /// </summary>
        public string UserId { get; set; }

    }
}
