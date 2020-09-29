using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工奖惩情况类
    /// </summary>
    public class MemberPrizePunishDto : ModelBaseClass
    {
        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private DateTime _OccurDate = DateTime.Now;
        private string _PrizrOrPunishName;
        private string _PrizrOrPunishUnit;
        private string _PrizrOrPunishReasion;
        private string _PrizrOrPunishType;
        private string _PrizrOrPunishGrade;

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
        [ForeignKey("PPunishFkey"), Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// </summary>
        public MemberInfoEntity Member { get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime OccurDate
        {
            get { return _OccurDate; }
            set { _OccurDate = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 类型：奖励、处理、处罚
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PrizrOrPunishType { get { return _PrizrOrPunishType; } set { _PrizrOrPunishType = value; OnPropertyChanged(); } }

        /// <summary>
        /// 级别：县级、市级、省级、国家级
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PrizrOrPunishGrade { get { return _PrizrOrPunishGrade; } set { _PrizrOrPunishGrade = value; OnPropertyChanged(); } }

        /// <summary>
        /// 奖励或处罚（理）名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string PrizrOrPunishName { get { return _PrizrOrPunishName; } set { _PrizrOrPunishName = value; OnPropertyChanged(); } }

        /// <summary>
        /// 奖励或处罚（理）事由
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string PrizrOrPunishReasion { get { return _PrizrOrPunishReasion; } set { _PrizrOrPunishReasion = value; OnPropertyChanged(); } }
        /// <summary>
        /// 奖励或处罚单位
        /// </summary>
        [Column(TypeName = "varchar(60)")]
        public string PrizrOrPunishUnit { get { return _PrizrOrPunishUnit; } set { _PrizrOrPunishUnit = value; OnPropertyChanged(); } }
     
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
       
    }
}
