using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义员工发放记录表
    /// </summary>
    public class MemberSalary : ModelBaseClass
    {
        private string _Id;
        private string _Remark;
        private DateTime _UpDateTime;
        private string _UserId;
        private int _PayMonth;
        private int _PayYear;
        private string _PayUnitName;
        private string _TableType;
        private string _NameAndAmount;


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
        /// 外键:关联员工表 Id
        /// </summary>
        [ForeignKey("PayFkey"), Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// 该属性必须有，否则在生成数据库时，将无法产生外键，即使上面设置了外键（PayFKey)。
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// 已发放的待遇项目Id号及对应的金额列表（JSON格式）。
        /// </summary>
        [Required, Column(TypeName = "varchar(2000)")]
        public string NameAndAmount { get { return _NameAndAmount; } set { _NameAndAmount = value; OnPropertyChanged(); } }

        /// <summary>
        /// 发放类型：月度待遇表、月度补贴表、其他待遇表
        /// </summary>
        [Required, Column(TypeName = "varchar(30)")]
        public string TableType { get { return _TableType; } set { _TableType = value; OnPropertyChanged(); } }

        
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
    }
}
