using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 系统服务器的相关设置（一般中只有管理员才能修改）
    /// </summary>
    public class SettingServer : INotifyPropertyChanged
    {
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 字段
        private string _WorkContentType;
        private string _Deparmentts;
        private int _IntervalOne;
        private int _IntervalTwo;
        #endregion

        #region 属性
        /// <summary>
        /// Id号，就一条记录，没有意义，为使用 efcore设置
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        ///工作内容类型："总支议事，党的建设,党风廉政,意识形态,组织人事,劳动工资，制度建设、绩效考核,其他类别"
        /// </summary>
        [Required, Column(TypeName = "varchar(500)")]
        public string WorkContentType
        {
            get { return _WorkContentType; }
            set { _WorkContentType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 使用本系统的所有部门:政工科、综合科、养护科等
        /// </summary>
        [Required, Column(TypeName = "varchar(500)")]
        public string Deparmentts
        {
            get { return _Deparmentts; }
            set { _Deparmentts = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 计划、附件总数变化信息提示时间
        /// </summary>
        public int IntervalOne
        {
            get { return _IntervalOne; }
            set { _IntervalOne = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 快过期计划提示时间间隔
        /// </summary>
        public int IntervalTwo
        {
            get { return _IntervalTwo; }
            set { _IntervalTwo = value; OnPropertyChanged(); }
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public SettingServer()
        {
        }
        #endregion

        #region 方法
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// 返回工作内容类型的List对象
        /// </summary>
        /// <returns></returns>
        public List<string> GetWorkContentTypes()
        {
            return new List<string>(WorkContentType.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
        #endregion


    }
}
