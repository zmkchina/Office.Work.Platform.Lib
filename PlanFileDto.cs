﻿using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询结果类
    /// </summary>
    public class PlanFileDto : ModelBaseClass
    {
        private string _Id;
        private string _Name;
        private string _Describe;
        private DateTime _UpDateTime;
        private string _UserId;
        private long _Length;
        private string _ExtendName;
        private float _DownIntProgress;
        private float _UpIntProgress;
        private string _ContentType;
        private string _DispatchUnit;
        private DateTime _Pubdate ;
        private string _FileNumber;
        private string _CanReadUserIds;
        private string _CanDelte;

        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 外键，指向计划
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        ///外键：指向计划实体
        /// </summary>
        public Lib.PlanEntity Plan { get; set; }

        /// <summary>
        /// 文件内容类型(一般应当于其所属的计划相一致，不一致其实也无所谓)。
        /// </summary>
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 文件名称。
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 文件编号
        /// </summary>
        public string FileNumber
        {
            get { return _FileNumber; }
            set { _FileNumber = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 发文单位。
        /// </summary>
        public string DispatchUnit
        {
            get { return _DispatchUnit; }
            set { _DispatchUnit = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 有限读取人员。
        /// </summary>
        public string CanReadUserIds
        {
            get { return _CanReadUserIds; }
            set { _CanReadUserIds = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 成文时间。
        /// </summary>
        public DateTime Pubdate
        {
            get { return _Pubdate; }
            set { _Pubdate = value; OnPropertyChanged(); }
        }


        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string ExtendName
        {
            get { return _ExtendName; }
            set { _ExtendName = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件长度
        /// </summary>
        public long Length
        {
            get { return _Length; }
            set { _Length = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 上传该文件的用户ID号
        /// </summary>
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
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
        /// 该文件信息的描述
        /// </summary>
        public string Describe
        {
            get { return _Describe; }
            set { _Describe = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 该文件的上传进度条，不映射到数据库
        /// </summary>
        public float UpIntProgress
        {
            get { return _UpIntProgress; }
            set { _UpIntProgress = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该文件的下载进度条，不映射到数据库
        /// </summary>
        public float DownIntProgress
        {
            get { return _DownIntProgress; }
            set { _DownIntProgress = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该文件能否被删除标志，不映射到数据库
        /// </summary>
        public string CanDelte
        {
            get { return _CanDelte; }
            set { _CanDelte = value; OnPropertyChanged(); }
        }
    }
}
