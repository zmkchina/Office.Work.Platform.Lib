using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Office.Work.Platform.Lib
{
    /// <summary>
    /// 抽象类，各模型类继承：本类中的主要虚方法有：
    /// 检查模型有效性：ModelIsValid(),对特性标记为[Required]的属性检查是否为空或不是全法数据。
    /// </summary>
    public abstract class ModelBaseClass:INotifyPropertyChanged
    {
        /// <summary>
        /// 检查模型有效性。
        /// </summary>
        /// <returns></returns>
        public virtual bool ModelIsValid()
        {
            PropertyInfo[] propertyInfos = this.GetType().GetProperties();
            foreach (var property in propertyInfos)
            {
                //获取当前属性是否具被“[Required]”属性修饰。
                object[] objs = property.GetCustomAttributes(typeof(RequiredAttribute), true);
                if (objs.Length > 0)
                {
                    if (property.GetValue(this) == null || string.IsNullOrWhiteSpace(property.GetValue(this).ToString()))
                    {
                        return false;
                    }
                    if (property.PropertyType == typeof(int))
                    {
                        if (!int.TryParse(property.GetValue(this).ToString(), out _))
                        {
                            return false;
                        }
                    }
                   else if (property.PropertyType == typeof(float))
                    {
                        if (!float.TryParse(property.GetValue(this).ToString(), out _))
                        {
                            return false;
                        }
                    }
                    
                    else if (property.PropertyType == typeof(DateTime))
                    {
                        if (!DateTime.TryParse(property.GetValue(this).ToString(), out _))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
