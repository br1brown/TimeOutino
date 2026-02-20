using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TimeOutino
{
    public enum TipoRestart
    {
        [Description("Mai")]
        Mai,
        [Description("dopo 'snooze'")]
        Snooze
    }

    public sealed class EnumOption<TEnum>
    {
        public TEnum Value { get; set; }
        public string Display { get; set; }
    }

    internal static class UtilsEnums
    {
        public static string ToDescriptionString(this Enum val)
        {
            var field = val.GetType().GetField(val.ToString());
            if (field == null)
                return val.ToString();

            var attributes = (DescriptionAttribute[])field
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : val.ToString();
        }

        public static List<EnumOption<TipoRestart>> TipoRestartOptions
        {
            get
            {
                return Enum.GetValues(typeof(TipoRestart))
                    .Cast<TipoRestart>()
                    .Select(r => new EnumOption<TipoRestart>
                    {
                        Value = r,
                        Display = r.ToDescriptionString()
                    })
                    .ToList();
            }
        }

        public static List<EnumOption<TipoNotifica>> TipoNotificaOptions
        {
            get
            {
                return Enum.GetValues(typeof(TipoNotifica))
                    .Cast<TipoNotifica>()
                    .Select(r => new EnumOption<TipoNotifica>
                    {
                        Value = r,
                        Display = r.ToDescriptionString()
                    })
                    .ToList();
            }
        }
    }
}
