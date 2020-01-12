using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工类
    /// </summary>
    public class ModelMember : INotifyPropertyChanged
    {
        private string _Id;
        private string _Name;
        private string _Sex;
        private DateTime _Birthday = DateTime.Now;
        private string _TechnicalTitle;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Punish;
        private string _EducationDays;
        private string _GraduationSchoolDays;
        private string _MajorDays;
        private DateTime _GraduationDateDays = DateTime.Now;
        private string _EducationTop;
        private string _GraduationSchoolTop;
        private DateTime _GraduationDateTop = DateTime.Now;
        private string _MajorTop;
        private string _DegreeTop;
        private string _Prize;
        private string _Resume;
        private string _Remarks;
        private string _Job;
        private string _JobGrade;
        private string _Post;
        private DateTime _BeginWork;
        private DateTime _EnterOrganization;
        private DateTime _JoinCPC;
        private string _PoliticalStatus;
        private string _Department;
        private string _MobileCode;
        private string _FixPhoneCode;
        private string _EmployTitle;
        private string _UnitName;
        private string _PostInCPC;

        /// <summary>
        /// 身份证号
        /// </summary>
        [Key]
        public string Id { get { return _Id; } set { _Id = value; OnPropertyChanged("Punish"); } }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged("Name"); } }

        /// <summary>
        /// 员工性别
        /// </summary>
        public string Sex { get { return _Sex; } set { _Sex = value; OnPropertyChanged("Sex"); } }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get { return _Birthday; } set { _Birthday = value; OnPropertyChanged("Birthday"); } }

        /// <summary>
        /// 固定电话
        /// </summary>
        public string FixPhoneCode { get { return _FixPhoneCode; } set { _FixPhoneCode = value; OnPropertyChanged("FixPhoneCode"); } }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string MobileCode { get { return _MobileCode; } set { _MobileCode = value; OnPropertyChanged("MobileCode"); } }

        /// <summary>
        /// 参加工作时间
        /// </summary>
        public DateTime BeginWork { get { return _BeginWork; } set { _BeginWork = value; OnPropertyChanged("BeginWork"); } }

        /// <summary>
        /// 进入本单位时间
        /// </summary>
        public DateTime EnterOrganization { get { return _EnterOrganization; } set { _EnterOrganization = value; OnPropertyChanged("EnterOrganization"); } }

        /// <summary>
        /// 入党时间
        /// </summary>
        public DateTime JoinCPC { get { return _JoinCPC; } set { _JoinCPC = value; OnPropertyChanged("JoinCPC"); } }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticalStatus { get { return _PoliticalStatus; } set { _PoliticalStatus = value; OnPropertyChanged("PoliticalStatus"); } }

        /// <summary>
        /// 全日制学历
        /// </summary>
        public string EducationDays { get { return _EducationDays; } set { _EducationDays = value; OnPropertyChanged("EducationDays"); } }

        /// <summary>
        /// 全日制学历毕业学校
        /// </summary>
        public string GraduationSchoolDays { get { return _GraduationSchoolDays; } set { _GraduationSchoolDays = value; OnPropertyChanged("GraduationSchoolDays"); } }

        /// <summary>
        /// 全日制学历所学专业
        /// </summary>
        public string MajorDays { get { return _MajorDays; } set { _MajorDays = value; OnPropertyChanged("MajorDays"); } }

        /// <summary>
        /// 全日制学历毕业时间
        /// </summary>
        public DateTime GraduationDateDays { get { return _GraduationDateDays; } set { _GraduationDateDays = value; OnPropertyChanged("GraduationDateDays"); } }

        /// <summary>
        /// 最高学历
        /// </summary>
        public string EducationTop { get { return _EducationTop; } set { _EducationTop = value; OnPropertyChanged("EducationTop"); } }

        /// <summary>
        /// 最高学历毕业学校
        /// </summary>
        public string GraduationSchoolTop { get { return _GraduationSchoolTop; } set { _GraduationSchoolTop = value; OnPropertyChanged("GraduationSchoolTop"); } }

        /// <summary>
        /// 最高学历毕业时间
        /// </summary>
        public DateTime GraduationDateTop { get { return _GraduationDateTop; } set { _GraduationDateTop = value; OnPropertyChanged("GraduationDateTop"); } }

        /// <summary>
        /// 最高学历所学专业
        /// </summary>
        public string MajorTop { get { return _MajorTop; } set { _MajorTop = value; OnPropertyChanged("MajorTop"); } }

        /// <summary>
        /// 最高学位
        /// </summary>
        public string DegreeTop { get { return _DegreeTop; } set { _DegreeTop = value; OnPropertyChanged("DegreeTop"); } }

        /// <summary>
        /// 技术职称
        /// </summary>
        public string TechnicalTitle { get { return _TechnicalTitle; } set { _TechnicalTitle = value; OnPropertyChanged("TechnicalTitle"); } }

        /// <summary>
        /// 已聘技术职称
        /// </summary>
        public string EmployTitle { get { return _EmployTitle; } set { _EmployTitle = value; OnPropertyChanged("EmployTitle"); } }

        /// <summary>
        /// 部门:综合科、信息科....
        /// </summary>
        public string Department { get { return _Department; } set { _Department = value; OnPropertyChanged("Department"); } }

        /// <summary>
        /// 单位名称：港航中心、大柳巷船闸、成子河船闸、古泊河船闸
        /// </summary>
        public string UnitName { get { return _UnitName; } set { _UnitName = value; OnPropertyChanged("UnitName"); } }

        /// <summary>
        /// 职务:办事员（所有技术岗人员均是办事员，双肩挑除外）、科员、副科长、科长、副处长、处长。
        /// </summary>
        public string Post { get { return _Post; } set { _Post = value; OnPropertyChanged("Post"); } }

        /// <summary>
        /// 党内职务
        ///</summary>
        public string PostInCPC { get { return _PostInCPC; } set { _PostInCPC = value; OnPropertyChanged("PostInCPC"); } }

        /// <summary>
        /// 岗位性质：专技岗、管理岗、工勤岗、双肩挑
        /// </summary>
        public string Job { get { return _Job; } set { _Job = value; OnPropertyChanged("Job"); } }

        /// <summary>
        /// 岗位级别：管理岗1-10级、专技岗1-13级、工勤岗1-5级及初级工
        /// </summary>
        public string JobGrade { get { return _JobGrade; } set { _JobGrade = value; OnPropertyChanged("JobGrade"); } }

        /// <summary>
        /// 个人简历
        /// </summary>
        public string Resume { get { return _Resume; } set { _Resume = value; OnPropertyChanged("Resume"); } }

        /// <summary>
        /// 获奖情况
        /// </summary>
        public string Prize
        {
            get { return _Prize; }
            set { _Prize = value; OnPropertyChanged("Prize"); }
        }

        /// <summary>
        /// 受处罚情况
        /// </summary>
        public string Punish
        {
            get { return _Punish; }
            set { _Punish = value; OnPropertyChanged("Punish"); }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get { return _Remarks; } set { _Remarks = value; OnPropertyChanged("Remarks"); } }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged("UpDateTime"); }
        }

        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
