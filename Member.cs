using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工类
    /// </summary>
    public class Member : INotifyPropertyChanged
    {
        private string _Id;
        private string _Name;
        private string _Sex;
        private DateTime _Birthday = DateTime.Now;
        private string _TechnicalTitle;
        private DateTime _UpDateTime = DateTime.Now;
        private string _EducationDays;
        private string _GraduationSchoolDays;
        private string _MajorDays;
        private DateTime _GraduationDateDays = DateTime.Now;
        private string _EducationTop;
        private string _GraduationSchoolTop;
        private DateTime _GraduationDateTop = DateTime.Now;
        private string _MajorTop;
        private string _DegreeTop;
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
        private string _MemberType;
        private string _UserId;
        private int _OrderIndex;

        /// <summary>
        /// 身份证号
        /// </summary>
        [Key]
        [Required, Column(TypeName = "varchar(20)")]
        public string Id { get { return _Id; } set { _Id = value; OnPropertyChanged(); } }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged(); } }

        /// <summary>
        /// 员工性别
        /// </summary>
        [Column(TypeName = "varchar(5)")]
        public string Sex { get { return _Sex; } set { _Sex = value; OnPropertyChanged(); } }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get { return _Birthday; } set { _Birthday = value; OnPropertyChanged(); } }

        /// <summary>
        /// 固定电话
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string FixPhoneCode { get { return _FixPhoneCode; } set { _FixPhoneCode = value; OnPropertyChanged(); } }

        /// <summary>
        /// 移动电话
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string MobileCode { get { return _MobileCode; } set { _MobileCode = value; OnPropertyChanged(); } }

        /// <summary>
        /// 参加工作时间
        /// </summary>
        public DateTime BeginWork { get { return _BeginWork; } set { _BeginWork = value; OnPropertyChanged(); } }

        /// <summary>
        /// 进入本单位时间
        /// </summary>
        public DateTime EnterOrganization { get { return _EnterOrganization; } set { _EnterOrganization = value; OnPropertyChanged(); } }

        /// <summary>
        /// 用工性质：聘用合同制、劳动合同制、劳务派遣制
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string MemberType { get { return _MemberType; } set { _MemberType = value; OnPropertyChanged(); } }

        /// <summary>
        /// 入党时间
        /// </summary>
        public DateTime JoinCPC { get { return _JoinCPC; } set { _JoinCPC = value; OnPropertyChanged(); } }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PoliticalStatus { get { return _PoliticalStatus; } set { _PoliticalStatus = value; OnPropertyChanged(); } }

        /// <summary>
        /// 全日制学历
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string EducationDays { get { return _EducationDays; } set { _EducationDays = value; OnPropertyChanged(); } }

        /// <summary>
        /// 全日制学历毕业学校
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string GraduationSchoolDays { get { return _GraduationSchoolDays; } set { _GraduationSchoolDays = value; OnPropertyChanged(); } }

        /// <summary>
        /// 全日制学历所学专业
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string MajorDays { get { return _MajorDays; } set { _MajorDays = value; OnPropertyChanged(); } }

        /// <summary>
        /// 全日制学历毕业时间
        /// </summary>
        public DateTime GraduationDateDays { get { return _GraduationDateDays; } set { _GraduationDateDays = value; OnPropertyChanged(); } }

        /// <summary>
        /// 最高学历
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string EducationTop { get { return _EducationTop; } set { _EducationTop = value; OnPropertyChanged(); } }

        /// <summary>
        /// 最高学历毕业学校
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string GraduationSchoolTop { get { return _GraduationSchoolTop; } set { _GraduationSchoolTop = value; OnPropertyChanged(); } }

        /// <summary>
        /// 最高学历毕业时间
        /// </summary>
        public DateTime GraduationDateTop { get { return _GraduationDateTop; } set { _GraduationDateTop = value; OnPropertyChanged(); } }

        /// <summary>
        /// 最高学历所学专业
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string MajorTop { get { return _MajorTop; } set { _MajorTop = value; OnPropertyChanged(); } }

        /// <summary>
        /// 最高学位
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string DegreeTop { get { return _DegreeTop; } set { _DegreeTop = value; OnPropertyChanged(); } }

        /// <summary>
        /// 技术职称
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string TechnicalTitle { get { return _TechnicalTitle; } set { _TechnicalTitle = value; OnPropertyChanged(); } }

        /// <summary>
        /// 已聘技术职称
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string EmployTitle { get { return _EmployTitle; } set { _EmployTitle = value; OnPropertyChanged(); } }

        /// <summary>
        /// 部门:综合科、信息科....
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Department { get { return _Department; } set { _Department = value; OnPropertyChanged(); } }

        /// <summary>
        /// 单位名称：港航中心、大柳巷船闸、成子河船闸、古泊河船闸
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string UnitName { get { return _UnitName; } set { _UnitName = value; OnPropertyChanged(); } }

        /// <summary>
        /// 职务:无（所有技术岗人员均无职务，双肩挑除外），办事员、科员、副科长、科长、副处长、处长。
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Post { get { return _Post; } set { _Post = value; OnPropertyChanged(); } }

        /// <summary>
        /// 党内职务
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string PostInCPC { get { return _PostInCPC; } set { _PostInCPC = value; OnPropertyChanged(); } }

        /// <summary>
        /// 岗位性质：专技岗、管理岗、工勤岗、双肩挑
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Job { get { return _Job; } set { _Job = value; OnPropertyChanged(); } }

        /// <summary>
        /// 岗位级别：管理岗1-10级、专技岗1-13级、工勤岗1-5级及初级工
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string JobGrade { get { return _JobGrade; } set { _JobGrade = value; OnPropertyChanged(); } }

        /// <summary>
        /// 内部人员排序
        /// </summary>
        public int OrderIndex { get { return _OrderIndex; } set { _OrderIndex = value; OnPropertyChanged(); } }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(2000)")]
        public string Remarks { get { return _Remarks; } set { _Remarks = value; OnPropertyChanged(); } }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }

        }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        /// <summary>
        /// 绑定通知机制
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
