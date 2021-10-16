using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace BlazorSample.Sample.EditForm
{
    public static class EnumUtility
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }

        public static T GetEnum<T>(int value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }
    }
}
