using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息类
    /// </summary>
    public class Note : INotifyPropertyChanged
    {
        #region 字段
        private string _Id;
        private string _Caption;
        private string _Content;
        private DateTime _UpDateTime;
        private string _UserId;
        private string _CanReadUserIds;
        private string _TextContent;
        #endregion

        #region 属性
        /// <summary>
        /// 主键：不设为自增，不自动处理。
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 备忘标题
        /// </summary>
        [Required, Column(TypeName = "varchar(100)")]
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 备忘内容
        /// </summary>
        [Required, Column(TypeName = "longblob")]
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 备忘内容，纯文本
        /// </summary>
        [Column(TypeName = "longtext")]
        public string TextContent
        {
            get { return _TextContent; }
            set { _TextContent = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 创建用户Id
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 可查看该备注信息的用户列表
        /// </summary>
        [Required, Column(TypeName = "varchar(1000)")]
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
        #endregion

        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
