using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 员工绩效考核信息查询类
    /// </summary>
    public class MemberScoreSearch : INotifyPropertyChanged
    {
        private string _Remark;
        private DateTime _UpDateTime;
        private string _UserId;
        private string _ScoreType;
        private int _Score;
        private string _ScoreReason;
        private int _OccurYear;
        private int _OccurMonth;
        private string _ScoreUnitName;
        private string _MemberId;

        /// <summary>
        /// 记录 Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 员工 Id
        /// </summary>
        public string MemberId { get { return _MemberId; } set { _MemberId = value; OnPropertyChanged(); } }

        /// <summary>
        /// 工作人员姓名
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 工作人员类型
        /// </summary>
        public string MemberType { get; set; }

        /// <summary>
        /// 得分类型：基础分、加分、减分
        /// </summary>
        public string ScoreType { get { return _ScoreType; } set { _ScoreType = value; OnPropertyChanged(); } }

        /// <summary>
        /// 具体分值
        /// </summary>
        public int Score
        {
            get { return _Score; }
            set { _Score = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 发生年份
        /// </summary>
        public int OccurYear
        {
            get { return _OccurYear; }
            set { _OccurYear = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 发生月份
        /// </summary>
        public int OccurMonth
        {
            get { return _OccurMonth; }
            set { _OccurMonth = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 得分原由
        /// </summary>
        public string ScoreReason { get { return _ScoreReason; } set { _ScoreReason = value; OnPropertyChanged(); } }

        /// <summary>
        /// 考核单位
        /// </summary>
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
