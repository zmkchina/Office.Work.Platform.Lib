using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义员工绩效考核信息
    /// </summary>
    public class MemberScoreDto : ModelBaseClass
    {
        private string _Remark;
        private DateTime _UpDateTime;
        private string _UserId;
        private int _MemberIndex;
        private string _ScoreType;
        private float _Score;
        private string _ScoreUnitName;
        private DateTime _OccurDate;


        /// <summary>
        /// 主键：不设为自增，不自动处理。
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        /// <summary>
        /// 外键:关联员工表 Id
        /// </summary>
        [ForeignKey("PerformanceFkey"), Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外键指向的实体。
        /// 该属性必须有，否则在生成数据库时，将无法产生外键，即使上面设置了外键（PayFKey)。
        /// </summary>
        public MemberInfoEntity Member { get; set; }

        /// <summary>
        /// 得分情由：基础分值、发表文章、获得表彰、迟到早退、党政纪处理、党政纪处分、其他加分情形、其他扣分情形
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "得分类型必须输入"), Column(TypeName = "varchar(30)")]
        public string ScoreType
        {
            get { return _ScoreType; }
            set
            {
                _ScoreType = value; OnPropertyChanged();
            }
        }

        /// <summary>
        /// 具体分值，扣分的话为负值
        /// </summary>
        [Required]
        public float Score
        {
            get { return _Score; }
            set { _Score = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 发生时间
        /// </summary>
        [Required]
        public DateTime OccurDate
        {
            get { return _OccurDate; }
            set { _OccurDate = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 内部人员排序(此字段值来源于Member表）
        /// </summary>
        public int MemberIndex { get { return _MemberIndex; } set { _MemberIndex = value; OnPropertyChanged(); } }

        /// <summary>
        /// 考核单位
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string ScoreUnitName
        {
            get { return _ScoreUnitName; }
            set { _ScoreUnitName = value; OnPropertyChanged(); }
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
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(); }
        }
    }
}
