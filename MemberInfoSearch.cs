using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工查询类
    /// </summary>
    public class MemberInfoSearch
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 员工性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        public string FixPhoneCode { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string MobileCode { get; set; }

        /// <summary>
        /// 参加工作时间
        /// </summary>
        public DateTime BeginWork { get; set; }

        /// <summary>
        /// 进入本单位时间
        /// </summary>
        public DateTime EnterOrganization { get; set; }

        /// <summary>
        /// 入党时间
        /// </summary>
        public DateTime JoinCPC { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticalStatus { get; set; }

        /// <summary>
        /// 全日制学历
        /// </summary>
        public string EducationDays { get; set; }

        /// <summary>
        /// 全日制学历毕业学校
        /// </summary>
        public string GraduationSchoolDays { get; set; }

        /// <summary>
        /// 全日制学历所学专业
        /// </summary>
        public string MajorDays { get; set; }

        /// <summary>
        /// 全日制学历毕业时间
        /// </summary>
        public DateTime GraduationDateDays { get; set; }

        /// <summary>
        /// 最高学历
        /// </summary>
        public string EducationTop { get; set; }

        /// <summary>
        /// 最高学历毕业学校
        /// </summary>
        public string GraduationSchoolTop { get; set; }

        /// <summary>
        /// 最高学历毕业时间
        /// </summary>
        public DateTime GraduationDateTop { get; set; }

        /// <summary>
        /// 最高学历所学专业
        /// </summary>
        public string MajorTop { get; set; }

        /// <summary>
        /// 最高学位
        /// </summary>
        public string DegreeTop { get; set; }

        /// <summary>
        /// 技术职称
        /// </summary>
        public string TechnicalTitle { get; set; }

        /// <summary>
        /// 已聘技术职称
        /// </summary>
        public string EmployTitle { get; set; }

        /// <summary>
        /// 部门:综合科、信息科....
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 单位名称：港航中心、大柳巷船闸、成子河船闸、古泊河船闸
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 行政职务:办事员（所有技术岗人员均是办事员，双肩挑除外）、科员、副科长、科长、副处长、处长。
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// 党内职务:总支书记、总支委员、支部书记、支部委员。
        /// </summary>
        public string PostInCPC { get; set; }

        /// <summary>
        /// 岗位性质：专技岗、管理岗、工勤岗、双肩挑
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// 岗位级别：管理岗1-10级、专技岗1-13级、工勤岗1-5级及初级工
        /// </summary>
        public string JobGrade { get; set; }

        /// <summary>
        /// 个人简历
        /// </summary>
        public string Resume { get; set; }

        /// <summary>
        /// 获奖情况
        /// </summary>
        public string Prize { get; set; }

        /// <summary>
        /// 受处罚情况
        /// </summary>
        public string Punish { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }

        /// <summary>
        /// 多字段查询 
        /// </summary>

        public string KeysInMultiple { get; set; }
    }
}
