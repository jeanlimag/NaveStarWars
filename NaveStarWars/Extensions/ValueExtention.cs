using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.Extensions
{
    public static class ValueExtention
    {

        public static T GetValueOrDefault<T>(this SqlDataReader reader, string campo)
        {
            try
            {
                return (T)reader[campo];
            }
            catch
            {
                return default(T);
            }
        }

    }
}
