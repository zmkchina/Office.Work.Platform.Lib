using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询结果类
    /// </summary>
    public class PlanSearchResult
    {
        public PlanSearchResult()
        {
            SearchCondition = new PlanSearch();
            RecordList = new List<Plan>();
        }
        public PlanSearch SearchCondition { get; set; }
        public List<Plan> RecordList { get; set; }
    }
}
