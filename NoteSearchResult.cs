using System.Collections.Generic;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 工作备忘信息查询结果类
    /// </summary>
    public class NoteSearchResult
    {
        public NoteSearchResult()
        {
            SearchCondition = new NoteSearch();
            RecordList = new List<Note>();
        }
        public NoteSearch SearchCondition { get; set; }
        public List<Note> RecordList { get; set; }
    }
}
