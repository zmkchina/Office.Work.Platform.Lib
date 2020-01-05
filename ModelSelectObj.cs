using System.ComponentModel;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 本类用于为已有的对象添加临时绑定到具有选择功能的控件上，以便返回被选中的已有对象。比如：将UserModel对像绑定到CheckBox上，用于获得所有被选中的用户。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModelSelectObj<T> : INotifyPropertyChanged
    {
        private bool _IsSelect;

        private T _Obj;

        /// <summary>
        /// 布尔值，用于表是是否被选中
        /// </summary>
        public bool IsSelect
        {
            get { return _IsSelect; }
            set { _IsSelect = value; OnPropertyChanged(nameof(IsSelect)); }
        }
        /// <summary>
        /// 已有的待选择对象
        /// </summary>
        public T Obj
        {
            get { return _Obj; }
            set { _Obj = value; OnPropertyChanged(nameof(Obj)); }
        }
        #region 事件
        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 方法
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
