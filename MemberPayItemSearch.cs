namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义待遇发放项目查询条件信息
    /// </summary>
    public class MemberPayItemSearch 
    {
        /// <summary>
        /// 待遇项目的名称
        /// </summary>
        public string Name { get; set; }
      
        /// <summary>
        /// 是否计入各类交费基数
        /// </summary>
        public string InCardinality { get; set; }
        /// <summary>
        /// 生成打印表格时放在哪个表中：月度工资表、月度补贴表、其他待遇表
        /// 此栏目信息可用于标志，该项目是不是月度的项目
        /// </summary>
        public string InTableType { get; set; }
        /// <summary>
        /// 该项目是发放待遇还是扣除待遇:发放、扣除
        /// </summary>
        public string AddOrCut { get; set; }
        /// <summary>
        /// 该项目相关说明
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 该项目属于哪个单位
        /// </summary>
        public string UnitName { get; set; }
        /// <summary>
        /// 操作人员ID
        /// </summary>
        public string UserId { get; set; }
    }
}
