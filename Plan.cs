using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private string _PlanType;
        private string _FinishNote;
        private string _Content;
        private string _Caption;
        private string _Department;
        private Uri _PlanStateImage;

        /// <summary>
        /// 计划ID号，格式yyyyMMddHHmmssfff
        /// </summary>
        [Key]
        [Required, Column(TypeName = "varchar(20)")]
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
        public string PlanType
        {
            get { return _PlanType; }
            set { _PlanType = value; OnPropertyChanged(); }
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
        [Required, Column(TypeName = "varchar(500)")]
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
            set { _CurrectState = value; PlanStateImage = GetPlanStateImage(CurrectState); OnPropertyChanged(); }
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
        /// 该计划所拥有的附件。
        /// </summary>
        public ObservableCollection<PlanFile> Files { get; set; }
        /// <summary>
        /// 该计划状态图标URI，不映射到数据库
        /// </summary>
        [NotMapped]
        public Uri PlanStateImage
        {
            get { return _PlanStateImage; }
            set
            {
                //判断一下：防止JsonConvert.DeserializeObject<T>过程中，此值被重新赋值为空
                //因为不映射到数据库，故从数据表中查询数据时，此值总为空。
                if (value != null)
                {
                    _PlanStateImage = value; OnPropertyChanged();
                }
            }
        }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法        
        public Plan()
        {
            Files = new ObservableCollection<PlanFile>();
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Uri GetPlanStateImage(string PlanState)
        {
            Uri V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/PlanStateErr.png", UriKind.Relative);
            switch (PlanState)
            {
                case "等待执行":
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/PlanNew.png", UriKind.Relative);
                    break;
                case "正在实施":
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/PlanHandle.png", UriKind.Relative);
                    break;
                case "已经完成":
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/PlanFinish.png", UriKind.Relative);
                    break;
                case "计划取消":
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocRar.png", UriKind.Relative);
                    break;
            }
            return V_DefaultDocImg;
        }
        #endregion
    }


    public static class PlanStatus
    {
        public static string WaitBegin { get; set; }
        public static string Running { get; set; }
        public static string Finished { get; set; }
        public static string Canceled { get; set; }
        static PlanStatus()
        {
            WaitBegin = "等待执行"; Running = "正在进行"; Finished = "已经完结"; Canceled = "计划取消";
        }
        public static string[] PlanStatusArr
        {
            get
            {
                return new string[] { WaitBegin, Running, Finished, Canceled };
            }
        }
    }
}
