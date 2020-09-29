using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工社会关系类
    /// </summary>
    public class MemberRelationsEntity : ModelBaseClass
    {
        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private string _Role;
        private string _UnitName;
        private string _Relation;
        private string _Name;
        private int _OrderIndex;
        private DateTime _Birthday;
        private string _PoliticalStatus;

        /// <summary>
        ///主键：不设为自增，不自动处理。
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
        [ForeignKey("RelationsFkey"), Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// </summary>
        public MemberInfoEntity Member { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged(); } }
        /// <summary>
        /// 关系
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string Relation { get { return _Relation; } set { _Relation = value; OnPropertyChanged(); } }

        /// <summary>
        /// 出生日期
        /// </summary>
        [Description("出生日期")]
        public DateTime Birthday { get { return _Birthday; } set { _Birthday = value; OnPropertyChanged(); } }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [Description("政治面貌")]
        [Column(TypeName = "varchar(20)")]
        public string PoliticalStatus { get { return _PoliticalStatus; } set { _PoliticalStatus = value; OnPropertyChanged(); } }

        /// <summary>
        /// 工作单位
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string UnitName { get { return _UnitName; } set { _UnitName = value; OnPropertyChanged(); } }
        /// <summary>
        /// 职务
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Role { get { return _Role; } set { _Role = value; OnPropertyChanged(); } }

        /// <summary>
        /// 人员排序
        /// </summary>
        public int OrderIndex
        {
            get { return _OrderIndex; }
            set { _OrderIndex = value; OnPropertyChanged(); }
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
   
    }
}
