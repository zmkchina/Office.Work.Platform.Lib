using System;
using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 升级文件描述类
    /// </summary>
    public class AppUpdateInfo
    {
        /// <summary>
        /// 欲升级的时间信息，如客户端保存的升级时间比这个时间早，则启动升级程序
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 欲升级的文件名称列表
        /// </summary>
        public List<string> UpdateFiles { get; set; }
        /// <summary>
        /// 服务器读取升级信息结果
        /// </summary>
        public bool ReadResult { get; set; }
        /// <summary>
        /// 构造函数，初始化UpdateDate为最小值
        /// </summary>
        public AppUpdateInfo()
        {
            UpdateDate = DateTime.MinValue;
            UpdateFiles = new List<string>();
            ReadResult = false;
        }
    }
}
