using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工奖惩情况类
    /// </summary>
    public class MemberPrizePunish : INotifyPropertyChanged
    {

        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private DateTime _OccurDate;
        private string _PrizrOrPunishName;
        private string _PrizrOrPunishUnit;
        private string _PrizrOrPunishReasion;
        private int _GetScore;
        private string _PrizrOrPunishType;

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
        /// 绩效加减分,如减分请输入负数。
        /// </summary>
        public int GetScore { get { return _GetScore; } set { _GetScore = value; OnPropertyChanged(); } }
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
        [NotMapped]
        public string[] PrizrOrPunishTypeArr { get; set; }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        public MemberPrizePunish()
        {
            PrizrOrPunishTypeArr = new string[]{"奖励","处理","处分" };
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
