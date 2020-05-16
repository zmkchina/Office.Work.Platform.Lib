using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 登陆用户类
    /// </summary>
    public class User : INotifyPropertyChanged
    {
        private string _Id;
        private string _PassWord;
        private string _Post;
        private string _Department;
        private string _Grants;
        private int _OrderIndex;
        private string _Name;
        private string _UnitName;
        private string _UnitShortName;

        /// <summary>
        /// 登陆用户的帐号ID
        /// </summary>
        [Key]
        [Required, Column(TypeName = "varchar(10)")]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户的密码
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户的姓名
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 登陆用户的角色
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string Post
        {
            get { return _Post; }
            set { _Post = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户的单位
        /// </summary>
        [Required, Column(TypeName = "varchar(40)")]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户单位的简称
        /// </summary>
        [Required, Column(TypeName = "varchar(40)")]
        public string UnitShortName
        {
            get { return _UnitShortName; }
            set { _UnitShortName = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户的部门
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string Department
        {
            get { return _Department; }
            set { _Department = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 登陆用户的操作权限
        /// </summary>
        [Required, Column(TypeName = "varchar(1000)")]
        public string Grants
        {
            get { return _Grants; }
            set { _Grants = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 用户排序
        /// </summary>
        public int OrderIndex
        {
            get { return _OrderIndex; }
            set { _OrderIndex = value; OnPropertyChanged(); }
        }

        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
