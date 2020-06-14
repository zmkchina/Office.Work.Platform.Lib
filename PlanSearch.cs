using System;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类用户从客户端查询Plan时的参数类
    /// </summary>
    public class PlanSearch : ModelBaseClass
    {
        private int _PageCount;
        private int _PageIndex;
        private int _RecordCount;
        private int _PageSize;
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

        /// <summary>
        /// 是否要查询长期计划（3个月以上，值为yes:表查询长期计划，no:表查询短期计划，all:表查询所有） 
        /// </summary>
        public string LongPlan { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int RecordCount
        {
            get
            {
                return _RecordCount;
            }
            set
            {
                _RecordCount = value;
                PageCount = (RecordCount % PageSize) > 0 ? (RecordCount / PageSize) + 1 : RecordCount / PageSize;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return _PageCount;
            }
            set
            {
                _PageCount = value; OnPropertyChanged();
            }
        }

        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 每页记录条数
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
                PageCount = (RecordCount % PageSize) > 0 ? (RecordCount / PageSize) + 1 : RecordCount / PageSize;
                OnPropertyChanged();
            }
        }

        public PlanSearch()
        {
            PageSize = 10;
            PageIndex = 1;
        }
    }
}
