namespace Office.Work.Platform.Lib
{
    public class MemberSettings
    {
        public MemberSettings()
        {
            PayTableTypArr = new string[] { "月度工资表", "月度补贴表", "其他待遇表" };
            UnitNameArr = new string[] { "市港航事业发展中心", "市大柳巷船闸管理处", "市成子河船闸管理处", "市古泊河船闸管理处" };
            MemberPostArr = new string[] { "主任", "副主任", "科长", "副科长", "股长", "副股长", "办事员", "专技人员", "工会主席", "工会副主席" };
            MemberPartyPostArr = new string[] { "党总支书记", "党总支副书记", "党总支委员", "党支部书记", "党支部副书记", "党支部委员", "团总支书记", "团支部书记" };
            DepartmentArr = new string[] { "领导班子", "综合科", "政工科", "财务审计科", "发展计划科", "安全运行科", "航道养护科", "船闸事务科", "工程建设科", "港口业务科", "科技信息科", "工会", "政秘股", "养护股", "运调股", "财务股" };
            EducationArr = new string[] { "硕士", "研究生", "本科","专科", "中专", "高中", "初中" };
            DegreeArr = new string[] { "硕士", "研究生", "学士"};
            JobArr = new string[] { "专技岗", "管理岗", "工勤岗", "双肩挑" };
            JobGradeArr = new string[] { "管理4", "管理5", "管理6", "管理7", "管理8", "管理9", "管理10", "专技4", "专技5", "专技6", "专技7", "专技8", "专技9", "专技10", "专技11", "专技12", "技术员", "工勤1", "工勤2", "工勤3", "工勤4", "普通工" };
            EmploymentTypeArr = new string[] { "聘用合同制", "劳动合同制", "劳务派遣制", "离退休人员" };
        }
        /// <summary>
        /// 待遇表类型：月度工资表、月度补贴表、其他待遇表
        /// </summary>
        public string[] PayTableTypArr { get; set; }
        /// <summary>
        /// 员工所有单位：市港航事业发展中心、市大柳巷船闸管理处、市成子河船闸管理处、市古泊河船闸管理处
        /// </summary>
        public string[] UnitNameArr { get; set; }
        /// <summary>
        /// 员工职务:主任、副主任、科长、副科长、股长、副股长、办事员、专技人员、工会主席、工会副主席。
        /// </summary>
        public string[] MemberPostArr { get; set; }
        /// <summary>
        /// 党内务:党总支书记、党总支副书记、党总支委员、党支部书记、党支部副书记、党支部委员、团总支书记、团支部书记。
        /// </summary>
        public string[] MemberPartyPostArr { get; set; }
        /// <summary>
        /// 工作部门:综合科、信息科....
        /// </summary>
        public string[] DepartmentArr { get; set; }
        /// <summary>
        /// 学历列表
        /// </summary>
        public string[] EducationArr { get; set; }
        /// <summary>
        /// 学位列表
        /// </summary>
        public string[] DegreeArr { get; set; }
        /// <summary>
        /// 岗位性质：专技岗、管理岗、工勤岗、双肩挑
        /// </summary>
        public string[] JobArr { get; set; }
        /// <summary>
        /// 岗位级别：管理岗1-10级、专技岗1-13级、工勤岗1-5级及初级工
        /// </summary>
         public string[] JobGradeArr { get; set; }
        /// <summary>
        /// 用工性质：聘用合同制、劳动合同制、劳务派遣制、离退休人员
        /// </summary>
        public string[] EmploymentTypeArr { get; set; }
    }
}
