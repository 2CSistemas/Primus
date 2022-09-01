using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Aplicacao.Helper
{
    public static class EnumHelper
    {
        public static IEnumerable<string> GetDescriptions<T>() where T : struct, IConvertible
        {
            var type = typeof(T);
            if (!type.IsEnum || typeof(T) != type)
                return new List<string>();

            try
            {
                return Enum.GetValues(type).Cast<T>().Select(x => x.GetDescription()).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
        {
            var type = enumValue.GetType();
            if (!type.IsEnum)
                return string.Empty;

            var memberInfo = type.GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                    return ((DescriptionAttribute) attributes[0]).Description;
            }

            return enumValue.ToString();
        }
    }
}