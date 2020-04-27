using System;
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
    public class MemberFile : INotifyPropertyChanged
    {
        #region 字段
        private string _Id;
        private string _Name;
        private string _Describe;
        private DateTime _UpDateTime;
        private string _UserId;
        private long _Length;
        private string _ExtendName;
        private float _DownIntProgress;
        private float _UpIntProgress;
        private string _FType;
        private string _PayId;
        #endregion

        #region 属性
        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
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
        [ForeignKey("mid_mf"),Required, Column(TypeName = "varchar(20)")]
        public string MemberId { get; set; }
        //外键指向的实体。
        public Member Member { get; set; }
        /// <summary>
        /// 文件类别：基本信息、工作信息、教育信息、个人简历、奖惩情况、社会关系、月度待遇、补充待遇。
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string FType
        {
            get { return _FType; }
            set { _FType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 待遇Id。
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PayId
        {
            get { return _PayId; }
            set { _PayId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件名称。
        /// </summary>
        [Required, Column(TypeName = "varchar(200)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 文件的扩展名
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string ExtendName
        {
            get { return _ExtendName; }
            set { _ExtendName = value;  OnPropertyChanged(); }
        }     
        /// <summary>
        /// 文件长度
        /// </summary>
        [Required, Column(TypeName = "bigint")]
        public long Length
        {
            get { return _Length; }
            set { _Length = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 上传该文件的用户ID号
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
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
        [Column(TypeName = "varchar(1000)")]
        public string Describe
        {
            get { return _Describe; }
            set { _Describe = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 该文件的上传进度条，不映射到数据库
        /// </summary>
        [NotMapped]
        public float UpIntProgress
        {
            get { return _UpIntProgress; }
            set { _UpIntProgress = value; OnPropertyChanged(); }
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
        /// 文件具体信息
        /// </summary>
        [NotMapped]
        public System.IO.FileInfo FileInfo
        {
            get; set;
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
