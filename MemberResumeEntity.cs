using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工个人简历类
    /// </summary>
    public class MemberResumeEntity : ModelBaseClass
    {
        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private DateTime _BeginDate = DateTime.Now;
        private DateTime _EndDate = DateTime.Now.AddYears(1);
        private string _Content;

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
        [ForeignKey("ResumesFkey"), Required, Column(TypeName = "varchar(20)")]
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
        /// 工作或学习内容
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Content { get { return _Content; } set { _Content = value; OnPropertyChanged(); } }
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
