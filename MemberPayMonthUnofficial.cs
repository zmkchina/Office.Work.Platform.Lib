using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 编外劳动用工人员
    /// </summary>
    public class MemberPayMonthUnofficial : INotifyPropertyChanged
    {

        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private float _PostPay;
        private float _HousingFund;
        private float _OccupationalPension;
        private float _UnemploymentInsurance;
        private float _PensionInsurance;
        private float _MedicalInsurance;
        private float _UnionFees;
        private float _Tax;
        private string _Remark;
        private int _PayMonth;
        private int _PayYear;
        private float _PerformancePay;
        private float _BasicPay;
        private string _UserId;

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
        [ForeignKey("mid_mpmu")]
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }
        //外键指向的实体。
        public Member Member { get; set; }
        
        /// <summary>
        /// 基本工资
        /// </summary>
        public float BasicPay { get { return _BasicPay; } set { _BasicPay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 岗位工资
        /// </summary>
        public float PostPay { get { return _PostPay; } set { _PostPay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 绩效工资(月度发放部分）
        /// </summary>
        public float PerformancePay { get { return _PerformancePay; } set { _PerformancePay = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣住房公积金
        /// </summary>
        public float HousingFund  { get { return _HousingFund; } set { _HousingFund = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣职业年金
        /// </summary>
        public float OccupationalPension { get { return _OccupationalPension; } set { _OccupationalPension = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣养老保险
        /// </summary>
        public float PensionInsurance { get { return _PensionInsurance; } set { _PensionInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣失业保险
        /// </summary>
        public float UnemploymentInsurance { get { return _UnemploymentInsurance; } set { _UnemploymentInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣医疗保险
        /// </summary>
        public float MedicalInsurance { get { return _MedicalInsurance; } set { _MedicalInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣工会费
        /// </summary>
        public float UnionFees { get { return _UnionFees; } set { _UnionFees = value; OnPropertyChanged(); } }
        /// <summary>
        /// 应纳个税
        /// </summary>
        public float Tax { get { return _Tax; } set { _Tax = value; OnPropertyChanged(); } }
     
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
