using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询结果类
    /// </summary>
    public class PlanFileDtoPages
    {
        public PlanFileDtoPages()
        {
            SearchCondition = new PlanFileDtoSearch();
            RecordList = new List<PlanFileDto>();
        }
        public PlanFileDtoSearch SearchCondition { get; set; }
        public List<PlanFileDto> RecordList { get; set; }
    }
}
