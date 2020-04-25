using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 附件（文件）类
    /// </summary>
    public class Note : INotifyPropertyChanged
    {
        #region 字段
        private string _Id;
        private string _Type;
        private string _Caption;
        private string _Content;
        private DateTime _UpDateTime;
        private string _UserId;
        private string _CanReadUserIds;
        #endregion

        #region 属性
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 备忘类型。
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged(); }
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
        [Required, Column(TypeName = "blob")]
        public string Content
        {
            get { return _Content; }
            set { _Content = value; OnPropertyChanged(); }
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
