using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工一次性、临时性、非月度性待遇，类别主要有：年终绩效分配工资、年终绩效考核奖金、补发工资、补发非工资
    /// </summary>
    public class MemberPayTemp : INotifyPropertyChanged
    {
        private string _Id;
        private string _PayName;
        private DateTime _UpDateTime = DateTime.Now;
        private float _Amount;
        private string _Remark;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string PayName { get { return _PayName; } set { _PayName = value; OnPropertyChanged(); } }     
        /// <summary>
        /// 外键
        /// </summary>
        [ForeignKey("mpmunid")]
        [Required, Column(TypeName = "varchar(20)")] 
        public string MemberId { get; set; }
        //外键指向的实体。
        public Member Member { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public float Amount { get { return _Amount; } set { _Amount = value; OnPropertyChanged(); } }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 本月备注
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Remark { get { return _Remark; } set { _Remark = value; OnPropertyChanged(); } }
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
