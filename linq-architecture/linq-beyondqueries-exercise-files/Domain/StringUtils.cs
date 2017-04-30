using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeyondQueries.Domain
{
    public static class StringUtils
    {

        public static double ParseDouble(this string value)
        {
            return double.Parse(value);
        }
    }
}
