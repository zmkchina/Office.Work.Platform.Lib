using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 附件（文件）类
    /// </summary>
    public class ModelFile : INotifyPropertyChanged
    {
        #region 字段
        private string _Id;
        private string _Name;
        private string _Describe;
        private DateTime _UpDateTime;
        private string _UserId;
        private string _OwnerId;
        private string _ReadGrant;
        private long _Length;
        private string _ExtendName;
        private string _ContentType;
        private string _OwnerType;
        #endregion

        #region 属性
        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        [Key]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(nameof(Id)); }
        }
        /// <summary>
        /// 文件名称。
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(nameof(Name)); }
        }
        /// <summary>
        /// 文件的扩展名
        /// </summary>
        public string ExtendName
        {
            get { return _ExtendName; }
            set { _ExtendName = value; OnPropertyChanged(nameof(ExtendName)); }
        }
        /// <summary>
        /// 该文件所属的计划、备忘、员工记录的ID号
        /// </summary>
        public string OwnerId
        {
            get { return _OwnerId; }
            set { _OwnerId = value; OnPropertyChanged(nameof(OwnerId)); }
        }
        /// <summary>
        /// 文件类型：计划附件、备忘文件、个人文件、普通文件
        /// </summary>
        public string OwnerType
        {
            get { return _OwnerType; }
            set { _OwnerType = value; OnPropertyChanged(nameof(OwnerType)); }
        }
        /// <summary>
        /// 文件分类：纪检监察、新闻宣传、组织人事、劳动工资、党的建设、总支议事
        /// </summary>
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged(nameof(ContentType)); }
        }
        /// <summary>
        /// 文件长度
        /// </summary>
        public long Length
        {
            get { return _Length; }
            set { _Length = value; OnPropertyChanged(nameof(Length)); }
        }
        /// <summary>
        /// 文件读取权限
        /// </summary>
        public string ReadGrant
        {
            get { return _ReadGrant; }
            set { _ReadGrant = value; OnPropertyChanged(nameof(ReadGrant)); }
        }

        /// <summary>
        /// 上传该文件的用户ID号
        /// </summary>
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(nameof(UserId)); }
        }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(nameof(UpDateTime)); }
        }
        /// <summary>
        /// 该文件信息的描述
        /// </summary>
        public string Describe
        {
            get { return _Describe; }
            set { _Describe = value; OnPropertyChanged(nameof(Describe)); }
        }
        #endregion

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
