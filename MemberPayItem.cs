using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义所有待遇发放项目
    /// </summary>
    public class MemberPayItem : ModelBaseClass
    {
        private string _Name;
        private string _InCardinality;
        private string _Remark;
        private string _InTableType;
        private string _UnitName;
        private DateTime _UpDateTime;
        private string _UserId;
        private int _OrderIndex;
        private string _MemberTypes;
        private string _PayType;

        /// <summary>
        /// 待遇项目的名称
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//不设为自增，不自动处理。
        [Required, Column(TypeName = "varchar(30)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 是否计入各类交费基数
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string InCardinality
        {
            get { return _InCardinality; }
            set { _InCardinality = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 生成打印表格时放在哪个表中：月度工资表、月度补贴表、其他待遇表
        /// 此栏目信息可用于标志，该项目是不是月度的项目
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string InTableType
        {
            get { return _InTableType; }
            set { _InTableType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该项目性须:应发待遇、单位交纳、个人交纳
        /// </summary>
        [Required, Column(TypeName = "varchar(20)")]
        public string PayType
        {
            get { return _PayType; }
            set { _PayType = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该项目属于哪个单位
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; OnPropertyChanged(); }
        }
        
        /// <summary>
        /// 该项目属于哪种性质的人员
        /// </summary>
        [Required, Column(TypeName = "varchar(500)")]
        public string MemberTypes
        {
            get { return _MemberTypes; }
            set { _MemberTypes = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 具体操作人员
        /// </summary>
        [Required, Column(TypeName = "varchar(30)")]
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 操作日期
        /// </summary>
        [Required, Column(TypeName = "varchar(50)")]
        public DateTime UpDateTime
        {
            get { return _UpDateTime; }
            set { _UpDateTime = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 该项目相关说明
        /// </summary>
        [Column(TypeName = "varchar(300)")]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// 内部排序
        /// </summary>
        public int OrderIndex { get { return _OrderIndex; } set { _OrderIndex = value; OnPropertyChanged(); } }

    }
}
