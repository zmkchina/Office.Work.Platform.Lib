namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// Api执行返回结果类（用于JSON序列化和反序列化）
    /// </summary>
    public class ExcuteResult
    {
        /// <summary>
        /// 无参构造，可以表示未执行任何操作。状态码设为-1,信息为：未执行任何操作。
        /// </summary>
        public ExcuteResult()
        {
            State = -1;
            Msg = "未执行操作";
            ApiUrl = "";
            Tag = "";
        }

        /// <summary>
        /// 有参构造，可以作返回值的初始化处理
        /// </summary>
        /// <param name="p_state">操作结果状态码：0-成功，1-失败，2-错误，-1-未执行任何操作</param>
        /// <param name="p_msg">操作成功与否反馈信息</param>
        /// <param name="p_apiurl">附加的Url，默认为空字符串</param>
        /// <param name="p_tag">附加信息，默认为空字符串</param>
        public ExcuteResult(int p_state, string p_msg, string p_apiurl = "", string p_tag = "")
        {
            State = p_state;
            Msg = p_msg;
            ApiUrl = p_apiurl;
            Tag = p_tag;
        }
        /// <summary>
        /// 执行结果状态码（0:成功,1出错，）
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 执行结果信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 执行结果信息标题
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// 需要返回的ApiUrl
        /// </summary>
        public string ApiUrl { get; set; }
        /// <summary>
        /// 额外数据
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 设备结果对象属性值。
        /// </summary>
        /// <param name="p_state"></param>
        /// <param name="p_msg"></param>
        /// <param name="p_apiurl"></param>
        /// <param name="p_tag"></param>
        public void SetValues(int p_state, string p_msg, string p_apiurl = "", string p_tag = "", string p_caption = "信息")
        {
            State = p_state;
            Msg = p_msg;
            Caption = p_caption;
            ApiUrl = p_apiurl;
            Tag = p_tag;
        }
    }
}
