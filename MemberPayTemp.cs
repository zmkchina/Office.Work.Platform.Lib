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
        private string _UserId;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 临时发放的待遇类别
        /// </summary>
        [Required, Column(TypeName = "varchar(30)")]
        public string PayName { get { return _PayName; } set { _PayName = value; OnPropertyChanged(); } }     
        /// <summary>
        /// 外键
        /// </summary>
        [ForeignKey("mid_mpt")]
        [Required, Column(TypeName = "varchar(20)")] 
        public string MemberId { get; set; }
        //外键指向的实体。
        public Member Member { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
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
        /// 为此次临时发放的说明
        /// </summary>
        [Required, Column(TypeName = "varchar(500)")]
        public string Remark { get { return _Remark; } set { _Remark = value; OnPropertyChanged(); } }
        /// <summary>
        /// 该记录操作的用户ID号
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
        }
        [NotMapped]
        public string[] PayNameList { get; set; }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        public MemberPayTemp()
        {
            PayNameList = new string[] {"补发工资","补发房补","发放年终绩效工资","发放年终绩效考核奖","发放其他临时待遇" };
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
