using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOutino
{

    public enum TipoRestart
    {
        [Description("Mai")]
        Mai,
        [Description("dopo 'snooze'")]
        Snoooze
    }

    internal static class UtilsEnums
    {

        public static string ToDescriptionString(this Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static List<string> TipoRestart_sz
        {
            get
            {
                return Enum.GetValues(typeof(TipoRestart)).Cast<TipoRestart>().Select(r => r.ToDescriptionString()).ToList();
            }
        }

        public static List<string> TipoNotifica_sz
        {
            get
            {
                return Enum.GetValues(typeof(TipoNotifica)).Cast<TipoNotifica>().Select(r => r.ToDescriptionString()).ToList();
            }
        }

    }
}
