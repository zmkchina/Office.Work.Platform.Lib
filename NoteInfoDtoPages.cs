using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息类
    /// </summary>
    public class NoteInfoDtoPages
    {
        public NoteInfoDtoPages()
        {
            SearchCondition = new NoteInfoSearch();
            RecordList = new List<NoteInfoDto>();
        }
        public NoteInfoSearch SearchCondition { get; set; }
        public List<NoteInfoDto> RecordList { get; set; }
    }
}
