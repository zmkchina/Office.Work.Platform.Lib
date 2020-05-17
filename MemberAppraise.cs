using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工年度考核情况（事业单位人员年度考核）
    /// </summary>
    public class MemberAppraise : INotifyPropertyChanged
    {
        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private string _Year;
        private string _Result;

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
        /// 外键
        /// </summary>
        [ForeignKey("AppraiseFkey"),Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// 考核年份
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string Year
        {
            get { return _Year; }
            set { _Year = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 考核结果
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string Result
        {
            get { return _Result; }
            set { _Result = value; OnPropertyChanged(); }
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
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Remark { get { return _Remark; } set { _Remark = value; OnPropertyChanged(); } }

        /// <summary>
        /// 考核结果种类
        /// </summary>
        [NotMapped]
        public string[] AppraiseTypeArr { get; set; }

       

        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        /// <summary>
        /// 构造函数
        /// </summary>
        public MemberAppraise()
        {
            AppraiseTypeArr = new string[] { "优秀", "合格", "基本合格","不合格" };
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
