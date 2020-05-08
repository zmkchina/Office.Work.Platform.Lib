using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义员工发放记录表
    /// </summary>
    public class MemberPay : INotifyPropertyChanged
    {
        private string _Id;
        private string _PayName;
        private string _InCardinality;
        private string _AddOrCut;
        private string _InTableType;
        private float _Amount;
        private string _Remark;
        private DateTime _UpDateTime;
        private string _UserId;
        private int _PayMonth;
        private int _OrderIndex;
        private int _PayYear;
        private string _PayUnitName;
        private int _MemberIndex;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 工作人员Id
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }
        /// <summary>
        /// 工作人员姓名
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberName { get; set; }
        /// <summary>
        /// 工作人员类型
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string MemberType { get; set; }

        /// <summary>
        /// 待遇项目的名称
        /// </summary>
        [Required, Column(TypeName = "varchar(30)")]
        public string PayName { get { return _PayName; } set { _PayName = value; OnPropertyChanged(); } }
       
        /// <summary>
        /// 是否计入各类交费基数
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string InCardinality
        {
            get { return _InCardinality; }
            set { _InCardinality = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 生成打印表格时放在哪个表中：月度工资表、月度补贴表、其他待遇表
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string InTableType
        {
            get { return _InTableType; }
            set { _InTableType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该项目是发放待遇还是扣除待遇:发放、扣除
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string AddOrCut
        {
            get { return _AddOrCut; }
            set { _AddOrCut = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 金额
        /// </summary>
        [Required, Column(TypeName = "float(10,2)")]
        public float Amount { get { return _Amount; } set { _Amount = value; OnPropertyChanged(); } }
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
        /// 发放单位
        /// </summary>
        public string PayUnitName
        {
            get { return _PayUnitName; }
            set { _PayUnitName = value; OnPropertyChanged(); }
        }
        
        /// <summary>
        /// 内部人员排序(此字段值来源于Member表）
        /// </summary>
        public int MemberIndex { get { return _MemberIndex; } set { _MemberIndex = value; OnPropertyChanged(); } }
        /// <summary>
        /// 发放项目排序(此字段值来源于MemberPayItem表）
        /// </summary>
        public int OrderIndex { get { return _OrderIndex; } set { _OrderIndex = value; OnPropertyChanged(); } }
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
        [Column(TypeName = "varchar(300)")]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; OnPropertyChanged(); }
        }
      
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
