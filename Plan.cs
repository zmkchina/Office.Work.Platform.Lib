using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 计划类
    /// </summary>
    public class Plan : INotifyPropertyChanged
    {
        private string _Id;
        private string _ReadGrant;
        private string _CurrectState;
        private string _CreateUserId;
        private DateTime _FinishDate;
        private DateTime _EndDate;
        private DateTime _BeginDate;
        private string _Helpers;
        private string _ResponsiblePerson;
        private string _FinishNote;
        private string _Content;
        private string _Caption;
        private string _Department;
        private DateTime _UpDateTime;
        private string _ContentType;

        /// <summary>
        /// 计划ID号，格式yyyyMMddHHmmssfff
        /// </summary>
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 标题。
        /// </summary>
        [Required, Column(TypeName = "varchar(100)")]
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 内容与要求
        /// </summary>
        [Required, Column(TypeName = "varchar(2000)")]
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 完成情况
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string FinishNote
        {
            get { return _FinishNote; }
            set { _FinishNote = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 类型：纪检监察、新闻宣传、总支议题等。
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划所属部门。
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string Department
        {
            get { return _Department; }
            set { _Department = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 责任人员
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string ResponsiblePerson
        {
            get { return _ResponsiblePerson; }
            set { _ResponsiblePerson = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 协助人员
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Helpers
        {
            get { return _Helpers; }
            set { _Helpers = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 完成日期
        /// </summary>
        public DateTime FinishDate
        {
            get { return _FinishDate; }
            set { _FinishDate = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 创建人员
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string CreateUserId
        {
            get { return _CreateUserId; }
            set { _CreateUserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string CurrectState
        {
            get { return _CurrectState; }
            set { _CurrectState = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划读取权限(此字段存储用户ID列表)
        /// </summary>
        [Column(TypeName = "varchar(1000)")]
        public string ReadGrant
        {
            get { return _ReadGrant; }
            set { _ReadGrant = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(); }
        }
       
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public Plan()
        {
        }
        /// <summary>
        /// 验证模型是否符合要求。
        /// </summary>
        /// <returns></returns>
        public bool ModelIsValid()
        {
            if (string.IsNullOrWhiteSpace(CreateUserId) || string.IsNullOrWhiteSpace(Caption)
                || string.IsNullOrWhiteSpace(Content) || string.IsNullOrWhiteSpace(ContentType) || string.IsNullOrWhiteSpace(ResponsiblePerson)
                || string.IsNullOrWhiteSpace(Department))
            {
                return false;
            }
            if (BeginDate > EndDate) { return false; }
            return true;
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public static class PlanStatus
    {
        /// <summary>
        /// 等待执行
        /// </summary>
        public const string WaitBegin = "等待执行";
        /// <summary>
        /// 正在实施
        /// </summary>
        public const string Running = "正在实施";
        /// <summary>
        /// 已经完结
        /// </summary>
        public const string Finished = "已经完结";
        /// <summary>
        /// 计划取消
        /// </summary>
        public const string Canceled = "计划取消";

        public static string[] PlanStatusArr
        {
            get
            {
                return new string[] { WaitBegin, Running, Finished, Canceled };
            }
        }
    }
}
