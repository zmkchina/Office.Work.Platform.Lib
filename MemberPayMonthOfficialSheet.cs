using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位正式员工月度待遇发放工资表
    /// </summary>
    public class MemberPayMonthOfficialSheet : INotifyPropertyChanged
    {

        private float _PostPay;
        private float _ScalePay;
        private float _PostAllowance;
        private float _LivingAllowance;
        private float _IncentivePerformancePay;
        private string _Remark;
        private int _PayMonth;
        private int _PayYear;
        private string _RemarkShow;
        private float _HousingFund;
        private float _UnionFees;
        private float _MedicalInsurance;
        private float _UnemploymentInsurance;
        private float _PensionInsurance;
        private float _OccupationalPension;
        private float _Tax;
        private string _MemberId;
        private string _MemberName;
        private float _FactGetMoney;
        private float _ShouldGetMoney;

        /// <summary>
        /// 职工的Id号
        /// </summary>
        public string MemberId { get { return _MemberId; } set { _MemberId = value; OnPropertyChanged(); } }
        /// <summary>
        /// 职工的姓名
        /// </summary>
        public string MemberName { get { return _MemberName; } set { _MemberName = value; OnPropertyChanged(); } }
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
        /// 应发工资
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float ShouldGetMoney { get { return _ShouldGetMoney; } set { _ShouldGetMoney = value; OnPropertyChanged(); } }
        /// <summary>
        /// 实发工资
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float FactGetMoney { get { return _FactGetMoney; } set { _FactGetMoney = value; OnPropertyChanged(); } }
        /// <summary>
        /// 奖励性绩效工资(月度发放部分）
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float IncentivePerformancePay { get { return _IncentivePerformancePay; } set { _IncentivePerformancePay = value; OnPropertyChanged(); } }
        /// 扣住房公积金
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float HousingFund { get { return _HousingFund; } set { _HousingFund = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣职业年金
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float OccupationalPension { get { return _OccupationalPension; } set { _OccupationalPension = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣养老保险
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float PensionInsurance { get { return _PensionInsurance; } set { _PensionInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣失业保险
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float UnemploymentInsurance { get { return _UnemploymentInsurance; } set { _UnemploymentInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣医疗保险
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float MedicalInsurance { get { return _MedicalInsurance; } set { _MedicalInsurance = value; OnPropertyChanged(); } }
        /// <summary>
        /// 扣工会费
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float UnionFees { get { return _UnionFees; } set { _UnionFees = value; OnPropertyChanged(); } }
        /// <summary>
        /// 应纳个税
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
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
        /// 本月备注
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Remark { get { return _Remark; } set { _Remark = value; RemarkShow = value!=null && value.Trim().Length > 0?"Visible": "Collapsed"; OnPropertyChanged(); } }
        /// <summary>
        /// 有无备注信息，用于控制DataGrid是否显示详细信息
        /// </summary>
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
