using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工社会关系类
    /// </summary>
    public class MemberRelations : INotifyPropertyChanged
    {

        private string _Id;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Remark;
        private string _UserId;
        private string _Role;
        private string _UnitName;
        private string _Relation;
        private string _Name;

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
        /// 姓名
        /// </summary>
        [Required,Column(TypeName = "varchar(20)")]
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged(); } }
        /// <summary>
        /// 关系
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string Relation { get { return _Relation; } set { _Relation = value; OnPropertyChanged(); } }
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
        /// 主要社会关系
        /// </summary>
        [NotMapped]
        public string[] RelationArr { get; set; }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        public MemberRelations()
        {
            RelationArr = new string[] { "父亲","母亲","姐妹","兄弟","儿子","女儿","其他关系"};
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
