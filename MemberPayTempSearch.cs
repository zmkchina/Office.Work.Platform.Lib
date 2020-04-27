using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 职工临时待遇查询条件类
    /// </summary>
    public class MemberPayTempSearch
    {
        
        #region 属性
        /// <summary>
        /// 记录Id号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 所属职工的Id号（身份证号）
        /// </summary>
        public string MemberId { get; set; }
        /// <summary>
        /// 临时发放的待遇名称。
        /// </summary>
        public string PayName { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpDateTime { get; set; }
        /// <summary>
        /// 该文件信息的描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 多字段查询 
        /// </summary>
        public string SearchFromNameDesc { get; set; }

        /// <summary>
        /// 更新记录的人员
        /// </summary>
        public string UserId { get; set; }


        #endregion

    }
}
