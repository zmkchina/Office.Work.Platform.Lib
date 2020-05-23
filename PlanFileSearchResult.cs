using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询结果类
    /// </summary>
    public class PlanFileSearchResult
    {
        public PlanFileSearchResult()
        {
            SearchCondition = new PlanFileSearch();
            RecordList = new List<PlanFile>();
        }
        public PlanFileSearch SearchCondition { get; set; }
        public List<PlanFile> RecordList { get; set; }
    }
}
