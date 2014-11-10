using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Utils
{
    public static class Conversores
    {
        public static DateTime? ToDateTimeNullable(this string dataString)
        {
            DateTime data;
            if (!DateTime.TryParse(dataString, out data))
            {
                return null;
            }
            return data;
        }

        public static DateTime? ToDateTimeNullable(this object dataObject)
        {
            string dataString = (string)dataObject;
            DateTime dataConvertido;
            if (DateTime.TryParse(dataString, out dataConvertido))
            {
                return dataConvertido;
            };
            return null;
        }

        public static DateTime ToDateTime(this string dataString)
        {
            DateTime data;
            if (DateTime.TryParse(dataString, out data))
            {
                return data;
            }
            throw new InvalidCastException();
        }

        public static DateTime ToDateTime(this object numeroObject)
        {
            return Convert.ToDateTime(numeroObject);
        }

        public static Int32? ToInt32Nullable(this string numeroString)
        {
            Int32 numero;
            if (!Int32.TryParse(numeroString, out numero))
            {
                return null;
            }
            return numero;
        }

        public static Int32? ToInt32Nullable(this object numeroObject)
        {
            string numeroString = (string)numeroObject;
            int inteiroConvertido;
            if (Int32.TryParse(numeroString, out inteiroConvertido))
            {
                return inteiroConvertido;
            };
            return null;
        }

        public static Int32 ToInt32(this string numeroString)
        {
            Int32 numero;
            if (!Int32.TryParse(numeroString, out numero))
            {
                return 0;
            }
            return numero;
        }

        public static Int32 ToInt32(this object numeroObject)
        {
            return Convert.ToInt32(numeroObject);
        }

        public static Boolean? ToBooleanNullable(this object valorObject)
        {
            var valorString = (string)valorObject;
            bool boolean;
            if (!Boolean.TryParse(valorString, out boolean))
            {
                return null;
            }
            return boolean;
        }
    }
}
