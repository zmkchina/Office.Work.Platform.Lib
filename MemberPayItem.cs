using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类定义所有待遇发放项目
    /// </summary>
    public class MemberPayItem : INotifyPropertyChanged
    {
        private string _Name;
        private string _InCardinality;
        private string _AddOrCut;
        private string _Remark;
        private string _InTableType;
        private string _UnitName;
        private DateTime _UpDateTime;
        private string _UserId;
        private int _OrderIndex;

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
        /// 该项目是发放待遇还是扣除待遇:发放、扣除
        /// </summary>
        [Required, Column(TypeName = "varchar(10)")]
        public string AddOrCut
        {
            get { return _AddOrCut; }
            set { _AddOrCut = value; OnPropertyChanged(); }
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

     
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        public MemberPayItem()
        {
        }
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
