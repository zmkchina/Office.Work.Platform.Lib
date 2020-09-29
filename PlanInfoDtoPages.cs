using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 计划类
    /// </summary>
    public class PlanInfoDtoPages : ModelBaseClass
    {
        public PlanInfoDtoPages()
        {
            SearchCondition = new PlanInfoSearch();
            RecordList = new List<PlanInfoDto>();
        }
        public PlanInfoSearch SearchCondition { get; set; }
        public List<PlanInfoDto> RecordList { get; set; }
    }
}
