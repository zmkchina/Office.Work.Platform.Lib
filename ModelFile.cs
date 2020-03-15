﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

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
        private float _DownIntProgress;
        private Uri _FileTypeImageUri;
        #endregion

        #region 属性
        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        [Key]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件名称。
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件的扩展名
        /// </summary>
        public string ExtendName
        {
            get { return _ExtendName; }
            set { _ExtendName = value; FileTypeImageUri = GetFileTypeImage(ExtendName); OnPropertyChanged(); }
        }
        /// <summary>
        /// 该文件所属的计划、备忘、员工记录的ID号
        /// </summary>
        public string OwnerId
        {
            get { return _OwnerId; }
            set { _OwnerId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件类型：计划附件、备忘文件、个人文件、普通文件
        /// </summary>
        public string OwnerType
        {
            get { return _OwnerType; }
            set { _OwnerType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件分类：纪检监察、新闻宣传、组织人事、劳动工资、党的建设、总支议事
        /// </summary>
        public string ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件长度
        /// </summary>
        public long Length
        {
            get { return _Length; }
            set { _Length = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 援用文件读取权限的用户列表。
        /// </summary>
        public string ReadGrant
        {
            get { return _ReadGrant; }
            set { _ReadGrant = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 上传该文件的用户ID号
        /// </summary>
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
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
        /// 该文件信息的描述
        /// </summary>
        public string Describe
        {
            get { return _Describe; }
            set { _Describe = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该文件的下载进度条，不映射到数据库
        /// </summary>
        [NotMapped]
        public float DownIntProgress
        {
            get { return _DownIntProgress; }
            set { _DownIntProgress = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该文件的图标URI，不映射到数据库
        /// 因为不映射到数据库，故从数据表中查询数据时，此值总为空。
        /// </summary>
        [NotMapped]
        public Uri FileTypeImageUri
        {
            get { return _FileTypeImageUri; }
            set
            {
                //判断一下：防止JsonConvert.DeserializeObject<T>过程中，此值被重新赋值为空
                if (value != null)
                {
                    _FileTypeImageUri = value; OnPropertyChanged();
                }
            }
        }
        #endregion

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
        private Uri GetFileTypeImage(string FileExtentName)
        {
            Uri V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocImg.png", UriKind.Relative);
            string[] imgExtNameArr = { ".bmp", ".jpg", ".gif", ".jpeg", ".png", ".jpe", ".jfif", ".ico", ".tif", ".tiff" };
            if (imgExtNameArr.Contains(FileExtentName.ToLower()))
            {
                V_DefaultDocImg = new Uri("/Office.Work.Assistant;component/AppRes/Images/DefaultImg.png", UriKind.Relative);
            }
            else
            {
                if ((new string[] { ".xls", ".xlsx" }).Contains(FileExtentName.ToLower()))
                {
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocExcel.png", UriKind.Relative);
                }
                if ((new string[] { ".doc", ".docx" }).Contains(FileExtentName.ToLower()))
                {
                    return new Uri("/Office.Work.Platform;component/AppRes/Images/DocWord.png", UriKind.Relative);
                }
                if ((new string[] { ".ppt", ".pptx" }).Contains(FileExtentName.ToLower()))
                {
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocPpt.png", UriKind.Relative);
                }
                if ((new string[] { ".rar", ".zip" }).Contains(FileExtentName.ToLower()))
                {
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocRar.png", UriKind.Relative);
                }
                if ((new string[] { ".pdf" }).Contains(FileExtentName.ToLower()))
                {
                    V_DefaultDocImg = new Uri("/Office.Work.Platform;component/AppRes/Images/DocPdf.png", UriKind.Relative);
                }
            }
            return V_DefaultDocImg;
        }
        #endregion
    }
}
