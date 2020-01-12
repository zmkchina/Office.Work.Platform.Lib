using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 计划类
    /// </summary>
    public class ModelPlan : INotifyPropertyChanged
    {
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
        private string _Id;
        private string _Department;

        /// <summary>
        /// 计划ID号，格式yyyyMMddHHmmssfff
        /// </summary>
        [Key]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(nameof(Id)); }
        }
        /// <summary>
        /// 标题。
        /// </summary>
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; OnPropertyChanged(nameof(Caption)); }
        }
        /// <summary>
        /// 内容与要求
        /// </summary>
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(nameof(Content)); }
        }
        /// <summary>
        /// 完成情况
        /// </summary>
        public string FinishNote
        {
            get { return _FinishNote; }
            set { _FinishNote = value; OnPropertyChanged(nameof(FinishNote)); }
        }
        /// <summary>
        /// 类型：纪检监察、新闻宣传、总支议题。
        /// </summary>
        public string PlanType
        {
            get { return _PlanType; }
            set { _PlanType = value; OnPropertyChanged(nameof(PlanType)); }
        }
        /// <summary>
        /// 计划所属部门。
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set { _Department = value; OnPropertyChanged(nameof(Department)); }
        }
        /// <summary>
        /// 责任人员
        /// </summary>
        public string ResponsiblePerson
        {
            get { return _ResponsiblePerson; }
            set { _ResponsiblePerson = value; OnPropertyChanged(nameof(ResponsiblePerson)); }
        }
        /// <summary>
        /// 协助人员
        /// </summary>
        public string Helpers
        {
            get { return _Helpers; }
            set { _Helpers = value; OnPropertyChanged(nameof(Helpers)); }
        }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; OnPropertyChanged(nameof(BeginDate)); }
        }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; OnPropertyChanged(nameof(EndDate)); }
        }
        /// <summary>
        /// 完成日期
        /// </summary>
        public DateTime FinishDate
        {
            get { return _FinishDate; }
            set { _FinishDate = value; OnPropertyChanged(nameof(FinishDate)); }
        }
        /// <summary>
        /// 创建人员
        /// </summary>
        public string CreateUserId
        {
            get { return _CreateUserId; }
            set { _CreateUserId = value; OnPropertyChanged(nameof(CreateUserId)); }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string CurrectState
        {
            get { return _CurrectState; }
            set { _CurrectState = value; OnPropertyChanged(nameof(CurrectState)); }
        }
        /// <summary>
        /// 计划读取权限
        /// </summary>
        public string ReadGrant
        {
            get { return _ReadGrant; }
            set { _ReadGrant = value; OnPropertyChanged(nameof(ReadGrant)); }
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
