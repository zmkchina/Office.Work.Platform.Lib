﻿using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 计划类
    /// </summary>
    public class PlanInfoDto : ModelBaseClass
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
        private string _UnitName;

        /// <summary>
        /// 计划ID号，格式yyyyMMddHHmmssfff
        /// </summary>
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 标题。
        /// </summary>
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 内容与要求
        /// </summary>
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 完成情况
        /// </summary>
        public string FinishNote
        {
            get { return _FinishNote; }
            set { _FinishNote = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 类型：纪检监察、新闻宣传、总支议题等。
        /// </summary>
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划所属单位。
        /// </summary>
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划所属部门。
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set { _Department = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 责任人员
        /// </summary>
        public string ResponsiblePerson
        {
            get { return _ResponsiblePerson; }
            set { _ResponsiblePerson = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 协助人员
        /// </summary>
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
        public string CreateUserId
        {
            get { return _CreateUserId; }
            set { _CreateUserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string CurrectState
        {
            get { return _CurrectState; }
            set { _CurrectState = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划读取权限(此字段存储用户ID列表)
        /// </summary>
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

    }
}
