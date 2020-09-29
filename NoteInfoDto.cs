using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息类
    /// </summary>
    public class NoteInfoDto : ModelBaseClass
    {
        private string _Id;
        private string _Caption;
        private string _Content;
        private DateTime _UpDateTime;
        private string _UserId;
        private string _CanReadUserIds;
        private string _TextContent;

        /// <summary>
        /// 主键：不设为自增，不自动处理。
        /// </summary>
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 备忘标题
        /// </summary>
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 备忘内容
        /// </summary>
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 备忘内容，纯文本
        /// </summary>
        public string TextContent
        {
            get { return _TextContent; }
            set { _TextContent = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 创建用户Id
        /// </summary>
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 可查看该备注信息的用户列表
        /// </summary>
        public string CanReadUserIds
        {
            get { return _CanReadUserIds; }
            set { _CanReadUserIds = value; OnPropertyChanged(); }
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
