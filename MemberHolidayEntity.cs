using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工休假情况
    /// </summary>
    public class MemberHolidayEntity : ModelBaseClass
    {

        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private DateTime _BeginDate = DateTime.Now;
        private DateTime _EndDate = DateTime.Now.AddDays(2);
        private string _HolidayReasion;
        private string _HolidayType;
        private string _UnitName;

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
        [ForeignKey("HolidayFkey"), Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// </summary>
        public MemberInfoEntity Member { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 假期类型
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string HolidayType { get { return _HolidayType; } set { _HolidayType = value; OnPropertyChanged(); } }

        /// <summary>
        /// 请假事由
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string HolidayReasion { get { return _HolidayReasion; } set { _HolidayReasion = value; OnPropertyChanged(); } }

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
        /// 考核单位
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 假期类型
        /// </summary>
        public MemberHolidayEntity()
        {
        }
       
    }
}
