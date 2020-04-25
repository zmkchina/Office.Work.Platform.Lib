using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 升级文件描述类
    /// </summary>
    public class UpdateFile
    {
        /// <summary>
        /// 欲升级的文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 欲升级的文件版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 上次写入当前文件或目录的时间
        /// </summary>
        public DateTime LastWriteTime { get; set; }
    }
}
