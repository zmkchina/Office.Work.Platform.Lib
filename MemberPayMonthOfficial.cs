using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工月度待遇发放类
    /// </summary>
    public class MemberPayMonthOfficial : INotifyPropertyChanged
    {

        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private float _PostPay;
        private float _ScalePay;
        private float _PostAllowance;
        private float _LivingAllowance;
        private float _IncentivePerformancePay;
        private string _Remark;
        private int _PayMonth;
        private int _PayYear;
        private string _UserId;
        private float _FoodAllowance;
        private float _TrafficAllowance;
        private string _RemarkShow;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 外键
        /// </summary>
        [ForeignKey("mid_mpm")]
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }
        //外键指向的实体。
        public Member Member { get; set; }

        /// <summary>
        /// 岗位工资
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float PostPay { get { return _PostPay; } set { _PostPay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 薪级工资
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float ScalePay { get { return _ScalePay; } set { _ScalePay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 岗位津贴
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float PostAllowance { get { return _PostAllowance; } set { _PostAllowance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 生活补贴
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float LivingAllowance { get { return _LivingAllowance; } set { _LivingAllowance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 奖励性绩效工资(月度发放部分）
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float IncentivePerformancePay { get { return _IncentivePerformancePay; } set { _IncentivePerformancePay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 交通补贴
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float TrafficAllowance { get { return _TrafficAllowance; } set { _TrafficAllowance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 伙食补贴
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float FoodAllowance { get { return _FoodAllowance; } set { _FoodAllowance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 发放年份
        /// </summary>
        public int PayYear
        {
            get { return _PayYear; }
            set { _PayYear = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 发放月份
        /// </summary>
        public int PayMonth
        {
            get { return _PayMonth; }
            set { _PayMonth = value; OnPropertyChanged(); }
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
        /// 本月备注
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Remark { get { return _Remark; } set { _Remark = value; RemarkShow = value!=null && value.Trim().Length > 0?"Visible": "Collapsed"; OnPropertyChanged(); } }
        /// <summary>
        /// 有无备注信息，用于控制DataGrid是否显示详细信息
        /// </summary>
        [NotMapped]
        public string RemarkShow { get { return _RemarkShow; } set { _RemarkShow = value; OnPropertyChanged(); } }
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
