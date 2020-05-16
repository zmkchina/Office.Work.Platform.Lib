using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询条件类
    /// </summary>
    public class NoteSearch
    {

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

    }
}
