using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 附件（文件）查询条件类
    /// </summary>
    public class PlanFileDtoSearch : INotifyPropertyChanged
    {
        private int _PageCount;
        private int _PageIndex;
        private int _RecordCount;
        private int _PageSize;

        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 文件所属计划的单位名称。
        /// </summary>
        public string PlanUnitName { get; set; }

        /// <summary>
        /// 文件名称。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件编号
        /// </summary>
        public string FileNumber { get; set; }
        /// <summary>
        /// 文件的扩展名
        /// </summary>
        public string ExtendName { get; set; }
        /// <summary>
        /// 拥有者Id号
        /// </summary>
        public string PlanId { get; set; }
        /// <summary>
        /// 文件分类：纪检监察、新闻宣传、组织人事、劳动工资、党的建设、总支议事
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// 文件长度
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 当前用户的Id号，用于判断当前用户是否有权限读取该文件。
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 上传该文件的用户ID号
        /// </summary>
        public string UploadUserId { get; set; }

        /// <summary>
        /// 发文单位。
        /// </summary>
        public string DispatchUnit { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 该文件信息的描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 多字段查询，查询文件名称及文件描述
        /// </summary>
        public string SearchNameOrDesc { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int RecordCount
        {
            get
            {
                return _RecordCount;
            }
            set
            {
                _RecordCount = value;
                PageCount = (RecordCount % PageSize) > 0 ? (RecordCount / PageSize) + 1 : RecordCount / PageSize;
                OnPropertyChanged();
            }
        }



        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return _PageCount;
            }
            set
            {
                _PageCount = value; OnPropertyChanged();
            }
        }

        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 每页记录条数
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
                PageCount = (RecordCount % PageSize) > 0 ? (RecordCount / PageSize) + 1 : RecordCount / PageSize;
                OnPropertyChanged();
            }
        }

        public PlanFileDtoSearch()
        {
            PageSize = 10;
            PageIndex = 1;
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
