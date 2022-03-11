using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GenshinImpactAccountManager
{
    public class MethodsHelper
    {
        public static IEnumerable<T> GetChildrenByType<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                
                foreach (var child in LogicalTreeHelper.GetChildren(depObj))
                {
                    if(child is DependencyObject)
                    {
                        if (child != null && child is T)
                        {
                            yield return (T)child;
                        }

                        foreach (T childOfChild in GetChildrenByType<T>(((DependencyObject)child)))
                        {
                            yield return childOfChild;
                        }
                    }
                    
                }
            }
        }
    }
}
