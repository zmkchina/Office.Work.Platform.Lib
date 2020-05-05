using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义待遇发放配置信息：为哪些人发，在发放新待遇时从上月复制哪些项目数据。
    /// </summary>
    public class MemberPaySet : INotifyPropertyChanged
    {
        private DateTime _UpDateTime;
        private string _UserId;
        private string _UnitName;
        private string _PayItemNames;

        /// <summary>
        /// 单位名称：表明是哪个单位的待遇发放配置信息
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 主键，同时也是外键（指向员工信息，表明该条配置是对哪个用户的）。
        /// </summary>
        [Key]
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }


        /// <summary>
        /// 发放哪些待遇项目，项目之间用,号分隔
        /// </summary>
        [Column(TypeName = "varchar(2000)")]
        public string PayItemNames
        {
            get { return _PayItemNames; }
            set { _PayItemNames = value; OnPropertyChanged(); }
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
        /// 操作人员ID
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 员工的姓名(不保存到数据库）
        /// </summary>
        [NotMapped]
        public string MemberName { get; set; }

        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
