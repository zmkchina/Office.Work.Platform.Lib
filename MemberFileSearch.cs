using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 附件（文件）查询条件类
    /// </summary>
    public class MemberFileSearch
    {

        #region 属性
        /// <summary>
        /// 文件ID，与物理磁盘上的文件名称对应
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 文件所属员工的单位名称。
        /// </summary>
        public string MemberUnitName { get; set; }
        /// <summary>
        /// 文件名称。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件的扩展名
        /// </summary>
        public string ExtendName { get; set; }
        /// <summary>
        /// 拥有者Id号
        /// </summary>
        public string MemberId { get; set; }
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

        #endregion

    }
}
