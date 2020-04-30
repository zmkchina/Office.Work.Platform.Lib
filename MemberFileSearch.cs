using System;

namespace Office.Work.Platform.Lib
{
    public  class MemberFileSearch
    {
        public string MemberId { get; set; }
        public string FileType { get; set; }
        public string Id { get; set; }

        /// <summary>
        /// 多字段查询，查询文件名称及文件描述
        /// </summary>
        public string SearchNameOrDesc { get; set; }
        public string OtherRecordId { get; set; }
        public DateTime UpDateTime { get; set; }

        /// <summary>
        /// 当前用户的Id号，用于判断当前用户是否有权限读取该文件。
        /// </summary>
        public string UserId { get; set; }
    }
}
