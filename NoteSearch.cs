using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 附件（文件）查询条件类
    /// </summary>
    public class NoteSearch
    {
        
        #region 属性
        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 备忘类型。
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 备忘标题
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// 备忘内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建用户Id
        /// </summary>
        public string  UserId{ get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 多字段查询 
        /// </summary>
        public string KeysInMultiple { get; set; }

        #endregion

    }
}
