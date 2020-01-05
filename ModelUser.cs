using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 登陆用户类
    /// </summary>
    public class ModelUser : INotifyPropertyChanged
    {
        private string _Id;
        private string _PassWord;
        private string _Post;
        private string _Department;
        private int _RestInterval;
        private string _Grants;

        /// <summary>
        /// 登陆用户的帐号ID
        /// </summary>
        [Key]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(nameof(Id)); }
        }
        /// <summary>
        /// 登陆用户的密码
        /// </summary>
        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; OnPropertyChanged(nameof(PassWord)); }
        }
        /// <summary>
        /// 登陆用户的角色
        /// </summary>
        public string Post
        {
            get { return _Post; }
            set { _Post = value; OnPropertyChanged(nameof(Post)); }
        }
        /// <summary>
        /// 登陆用户的部门
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set { _Department = value; OnPropertyChanged(nameof(Department)); }
        }
        /// <summary>
        /// 登陆用户的间隔休息时间
        /// </summary>
        public int RestInterval
        {
            get { return _RestInterval; }
            set { _RestInterval = value; OnPropertyChanged(nameof(RestInterval)); }
        }
        /// <summary>
        /// 登陆用户的操作权限
        /// </summary>
        public string Grants
        {
            get { return _Grants; }
            set { _Grants = value; OnPropertyChanged(nameof(Grants)); }
        }

        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
      
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
