using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询条件类
    /// </summary>
    public class NoteSearch : INotifyPropertyChanged
    {
        private int _PageCount;
        private int _PageIndex;
        private int _RecordCount;
        private int _PageSize;

        /// <summary>
        /// 备忘记录ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 备忘标题
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// 备忘内容的纯文本
        /// </summary>
        public string TextContent { get; set; }
        /// <summary>
        /// 创建用户Id
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 是否只查询本人备忘信息
        /// </summary>
        public string IsMySelft { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 多字段查询 
        /// </summary>
        public string KeysInMultiple { get; set; }

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

        public NoteSearch()
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
