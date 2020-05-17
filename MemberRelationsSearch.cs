namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 员工社会关系查询条件类
    /// </summary>
    public class MemberRelationsSearch
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
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 更新记录的人员
        /// </summary>
        public string UserId { get; set; }


    }
}
