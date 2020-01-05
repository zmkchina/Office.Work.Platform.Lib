using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 单位员工家庭成员信息类
    /// </summary>
    public class ModelMemberFamily : INotifyPropertyChanged
    {

        private string _Name;
        private string _Relation;
        private DateTime _Birthday = DateTime.Now;
        private DateTime _UpDateTime = DateTime.Now;
        private string _Post;
        private string _Organization;
        private string _Remarks;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged("Name"); } }
        /// <summary>
        /// 关系：父亲、母亲、配偶、儿子、女儿、弟弟、妹妹
        /// </summary>
        public string Relation { get { return _Relation; } set { _Relation = value; OnPropertyChanged("Relation"); } }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get { return _Birthday; } set { _Birthday = value; OnPropertyChanged("Birthday"); } }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string Organization { get { return _Organization; } set { _Organization = value; OnPropertyChanged("Organization"); } }
        /// <summary>
        /// 职务
        /// </summary>
        public string Post { get { return _Post; } set { _Post = value; OnPropertyChanged("Post"); } }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get { return _Remarks; } set { _Remarks = value; OnPropertyChanged("Remarks"); } }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged("UpDateTime"); }
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
