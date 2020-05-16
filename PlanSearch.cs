using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类用户从客户端查询Plan时的参数类
    /// </summary>
    public class PlanSearch
    {
        /// <summary>
        /// 计划的Id号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// 内容与要求
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 完成情况
        /// </summary>
        public string FinishNote { get; set; }

        /// <summary>
        /// 类型：纪检监察、新闻宣传、总支议题。
        /// </summary>
        public string PlanType { get; set; }

        /// <summary>
        /// 计划所属单位
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 计划所属部门
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 责任人员
        /// </summary>
        public string ResponsiblePerson { get; set; }

        /// <summary>
        /// 协助人员
        /// </summary>
        public string Helpers { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 完成日期
        /// </summary>
        public DateTime FinishDate { get; set; }

        /// <summary>
        /// 创建人员
        /// </summary>
        public string CreateUserId { get; set; }

        /// <summary>
        /// 当前状态
        /// </summary>
        public string CurrectState { get; set; }

        /// <summary>
        /// 计划读取权限
        /// </summary>
        public string ReadGrant { get; set; }

        /// <summary>
        /// 多字段查询 
        /// </summary>

        public string KeysInMultiple { get; set; }
    }
}
