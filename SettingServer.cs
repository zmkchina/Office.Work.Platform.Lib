using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 系统服务器的相关设置（一般只有管理员才能修改）
    /// </summary>
    public class SettingServer : ModelBaseClass
    {
        private string _WorkContentType;
        private int _IntervalOne;
        private int _IntervalTwo;
        private string _HolidayTypes;
        private string _UnitNames;
        private string _Deparments;
        private string _PayTableTypes;
        private string _MemberPosts;
        private string _MemberPartyPosts;
        private string _Educations;
        private string _Degrees;
        private string _Jobs;
        private string _JobGrades;
        private string _MemberTypes;
        private string _NationTypes;
        private string _PrizrOrPunishTypes;
        private string _PrizrOrPunishNames;
        private string _Relations;
        private string _MemberScoreTypes;
        private string _Appraises;
        private string _PrizrOrPunishGrades;

        /// <summary>
        /// Id号，就一条记录，没有意义，为使用 efcore设置
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        ///工作内容类型："总支议事，党的建设,党风廉政,意识形态,组织人事,劳动工资，制度建设、绩效考核,其他类别"
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string WorkContentType
        {
            get { return _WorkContentType; }
            set { _WorkContentType = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 使用本系统的所有部门:政工科、综合科、养护科等
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Departments
        {
            get { return _Deparments; }
            set { _Deparments = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 假期类型
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string HolidayTypes
        {
            get { return _HolidayTypes; }
            set { _HolidayTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 单位名称
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string UnitNames
        {
            get { return _UnitNames; }
            set { _UnitNames = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 待遇表类型：月度工资表、月度补贴表、其他待遇表
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string PayTableTypes
        {
            get { return _PayTableTypes; }
            set { _PayTableTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 员工职务:主任、副主任、科长、副科长、股长、副股长、办事员、专技人员、工会主席、工会副主席。
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string MemberPosts
        {
            get { return _MemberPosts; }
            set { _MemberPosts = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 党内职务:党总支书记、党总支副书记、党总支委员、党支部书记、党支部副书记、党支部委员、团总支书记、团支部书记。
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string MemberPartyPosts
        {
            get { return _MemberPartyPosts; }
            set { _MemberPartyPosts = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 学历列表: "硕士", "研究生", "本科", "专科", "中专", "高中", "初中及以下"
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Educations
        {
            get { return _Educations; }
            set { _Educations = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 学位列表: "无", "硕士", "研究生", "学士" 
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Degrees
        {
            get { return _Degrees; }
            set { _Degrees = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 岗位性质：专技岗、管理岗、工勤岗、双肩挑
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 岗位级别：管理岗1-10级、专技岗1-13级、工勤岗1-5级及初级工
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string JobGrades
        {
            get { return _JobGrades; }
            set { _JobGrades = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 用工性质：聘用合同制、劳动合同制、劳务派遣制、离退休人员
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string MemberTypes
        {
            get { return _MemberTypes; }
            set { _MemberTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 民族：汉族、满族、维吾尔族、苗族、蒙古族、羌族、白族
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string NationTypes
        {
            get { return _NationTypes; }
            set { _NationTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 奖惩类型: "奖励", "处理", "处分"
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string PrizrOrPunishTypes
        {
            get { return _PrizrOrPunishTypes; }
            set { _PrizrOrPunishTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 奖惩级别: 县级、市级、省级、国家级
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string PrizrOrPunishGrades
        {
            get { return _PrizrOrPunishGrades; }
            set { _PrizrOrPunishGrades = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 奖惩类型具体名称: "先进工作者", "劳动模范", "嘉奖", "记功", "批评教育", "提醒谈话", "诫勉谈话", "警示谈话", "责令检讨", "通报批评", "政务警告", "政务记过", "政务记大过", "政务降级", "政务撤职", "政务开除", "党内警告", "党内严重警告", "撤销党内职务", "留党察看", "开除党籍" 
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string PrizrOrPunishNames
        {
            get { return _PrizrOrPunishNames; }
            set { _PrizrOrPunishNames = value; OnPropertyChanged(); }
        }

        /// <summary>
        ///主要社会关系        
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Relations
        {
            get { return _Relations; }
            set { _Relations = value; OnPropertyChanged(); }
        }

        /// <summary>
        ///绩效得分原由        
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string MemberScoreTypes
        {
            get { return _MemberScoreTypes; }
            set { _MemberScoreTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 计划、附件总数变化信息提示时间
        /// </summary>
        public int IntervalOne
        {
            get { return _IntervalOne; }
            set { _IntervalOne = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 快过期计划提示时间间隔
        /// </summary>
        public int IntervalTwo
        {
            get { return _IntervalTwo; }
            set { _IntervalTwo = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 考核结果种类
        /// </summary>
        [Required, Column(TypeName = "text")]
        public string Appraises
        {
            get { return _Appraises; }
            set { _Appraises = value; OnPropertyChanged(); }
        }


        [NotMapped]
        public ReadOnlyCollection<string> UnitNameArr
        {
            get { return new ReadOnlyCollection<string>(UnitNames?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> DepartmentArr
        {
            get { return new ReadOnlyCollection<string>(Departments?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> WorkContentTypeArr
        {
            get { return new ReadOnlyCollection<string>(WorkContentType?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> HolidayTypeArr
        {
            get { return new ReadOnlyCollection<string>(HolidayTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> PayTableTypeArr
        {
            get { return new ReadOnlyCollection<string>(PayTableTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> MemberPostArr
        {
            get { return new ReadOnlyCollection<string>(MemberPosts?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> MemberPartyPostArr
        {
            get { return new ReadOnlyCollection<string>(MemberPartyPosts?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> EducationArr
        {
            get { return new ReadOnlyCollection<string>(Educations?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> DegreeArr
        {
            get { return new ReadOnlyCollection<string>(Degrees?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }


        [NotMapped]
        public ReadOnlyCollection<string> JobArr
        {
            get { return new ReadOnlyCollection<string>(Jobs?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> JobGradeArr
        {
            get { return new ReadOnlyCollection<string>(JobGrades?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> MemberTypeArr
        {
            get { return new ReadOnlyCollection<string>(MemberTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> NationTypeArr
        {
            get { return new ReadOnlyCollection<string>(NationTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> PrizrOrPunishTypeArr
        {
            get { return new ReadOnlyCollection<string>(PrizrOrPunishTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> PrizrOrPunishGradeArr
        {
            get { return new ReadOnlyCollection<string>(PrizrOrPunishGrades?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> PrizrOrPunishNameArr
        {
            get { return new ReadOnlyCollection<string>(PrizrOrPunishNames?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> RelationArr
        {
            get { return new ReadOnlyCollection<string>(Relations?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> MemberScoreTypeArr
        {
            get { return new ReadOnlyCollection<string>(MemberScoreTypes?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        [NotMapped]
        public ReadOnlyCollection<string> AppraiseTypeArr
        {
            get { return new ReadOnlyCollection<string>(Appraises?.Split(",", StringSplitOptions.RemoveEmptyEntries)); }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SettingServer()
        {
            Id = 1;
            WorkContentType = "总支议事,党的建设,党风廉政,意识形态,组织人事,劳动工资,制度建设,绩效考核,其他类别";
            UnitNames = "市港航事业发展中心,市大柳巷船闸管理处,市成子河船闸管理处,市古泊河船闸管理处";
            Departments = "领导班子,综合科,政工科,财务审计科,发展计划科,安全运行科,航道养护科,船闸事务科,工程建设科,港口业务科,科技信息科,工会,政秘股,养护股,运调股,财务股";
            HolidayTypes = "事假,病假,调休假,年休假,婚假,产假,小产假,陪产假,探亲假,丧假,其他假期";
            PayTableTypes = "月度工资表,月度补贴表,其他待遇表";
            MemberPosts = "无,主任,副主任,科长,副科长,股长,副股长,办事员,专技人员,工会主席,工会副主席";
            MemberPartyPosts = "无,党总支书记,党总支副书记,党总支委员,党支部书记,党支部副书记,党支部委员,团总支书记,团支部书记";
            Educations = "硕士,研究生,本科,专科,中专,高中,初中及以下";
            Degrees = "无,硕士,研究生,学士";
            Jobs = "专技岗,管理岗,工勤岗,双肩挑";
            JobGrades = "管理4,管理5,管理6,管理7,管理8,管理9,管理10,专技4,专技5,专技6,专技7,专技8,专技9,专技10,专技11,专技12,技术员,工勤1,工勤2,工勤3,工勤4,普通工";
            MemberTypes = "聘用合同制,劳动合同制,劳务派遣制,离退休人员";
            NationTypes = "汉族,满族,维吾尔族,苗族,蒙古族,羌族,白族";
            PrizrOrPunishTypes = "奖励,处理,处分";
            PrizrOrPunishGrades = "县级,市级,省级,国家级";
            PrizrOrPunishNames = "先进工作者,劳动模范,嘉奖,记功,批评教育,提醒谈话,诫勉谈话,警示谈话,责令检讨,通报批评,政务警告,政务记过,政务记大过,政务降级,政务撤职,政务开除,党内警告,党内严重警告,撤销党内职务,留党察看,开除党籍";
            Relations = "父亲,母亲,岳父,岳母,丈夫,妻子,女儿,儿子";
            MemberScoreTypes = "新闻信息,政务信息,表彰奖励,迟到早退,政务处理,政务处分,党纪处理,党纪处分,其他情形";
            Appraises = "优秀,合格,基本合格,不合格";
            IntervalOne = 20;
            IntervalTwo = 30;
        }
    }
}
