using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 系统服务器的相关设置（一般中只有管理员才能修改）
    /// </summary>
    public class ModelSettingServer : INotifyPropertyChanged
    {
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 字段
        private string _WorkContentType;
        private string _AppVersion;
        private string _Deparmentts;
        private int _IntervalOne;
        private int _IntervalTwo;
        private string _PlanStateType;
        #endregion

        #region 属性
        /// <summary>
        /// Id号，就一条记录，没有意义，为使用 efcore设置
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 计划状态：等待执行、正在进行、已经完结、计划取消
        /// </summary>
        public string PlanStateType
        {
            get { return _PlanStateType; }
            set { _PlanStateType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 工作内容（文件）的类型："纪检监察,新闻宣传,组织人事,劳动工资,党的建设,总支议事"
        /// </summary>
        public string WorkContentType
        {
            get { return _WorkContentType; }
            set { _WorkContentType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 程序版本号
        /// </summary>
        public string AppVersion
        {
            get { return _AppVersion; }
            set { _AppVersion = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 使用本系统的所有部门:政工科、综合科、养护科等
        /// </summary>
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
        public ModelSettingServer()
        {
        }
        #endregion
        #region 方法
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
