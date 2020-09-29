namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 计划的四种状态：等待执行、正在实施、已经完结、计划取消
    /// </summary>
    public static class PlanStatus
    {
        /// <summary>
        /// 等待执行
        /// </summary>
        public const string WaitBegin = "等待执行";
        /// <summary>
        /// 正在实施
        /// </summary>
        public const string Running = "正在实施";
        /// <summary>
        /// 已经完结
        /// </summary>
        public const string Finished = "已经完结";
        /// <summary>
        /// 计划取消
        /// </summary>
        public const string Canceled = "计划取消";

        /// <summary>
        /// 计划四种状态的字符串常量数组
        /// </summary>
        public static string[] PlanStatusArr
        {
            get
            {
                return new string[] { WaitBegin, Running, Finished, Canceled };
            }
        }
    }
}
