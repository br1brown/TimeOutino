using System;
using System.ComponentModel;
using System.Reflection;

namespace TimeOutino
{
    public enum TipoRestart
    {
        [Description("Mai")]
        Mai,
        [Description("dopo 'snooze'")]
        Snooze
    }

    internal static class UtilsEnums
    {
        /// <summary>
        /// Restituisce il testo dell'attributo <see cref="DescriptionAttribute"/> associato
        /// al valore enum, oppure il nome del valore se l'attributo non è presente.
        /// </summary>
        public static string ToDescriptionString(this Enum value)
        {
            if (value == null)
                return string.Empty;

            FieldInfo field = value.GetType().GetField(value.ToString());
            if (field == null)
                return value.ToString();

            var attribute = (DescriptionAttribute)Attribute
                .GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute != null ? attribute.Description : value.ToString();
        }
    }
}
