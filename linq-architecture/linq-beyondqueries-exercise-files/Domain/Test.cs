using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using BeyondQueries.Models.Data;

namespace BeyondQueries.Domain
{
    public static class MyExtensions
    {
        public static TimeSpan Seconds(this int value)
        {
            return new TimeSpan(0, 0, value);
        }

        public static TimeSpan Ago(this TimeSpan value)
        {
            return value.Negate();
        }
    }

    public class Test
    {
        public void DoWork()
        {

            int value = "32".ToInt32();

            var movie = new Movie();
           
            Func<Movie, bool>[] rules = {
                                            m => String.IsNullOrEmpty(m.Title),
                                            m => m.Length > 20 && m.Length < 100,
                                            m => m.ReleaseDate.Value.Year > 1890
                                        };

            var isValid = rules.All(rule => rule(movie));



            IEnumerable<string> names = new string[] { "Scott", "Alex", "Chris" };

            var query2 = from n in names
                         where n.StartsWith("L")
                         select n;

            


            var query = names.Where(city => city.StartsWith("L"));

            string postalCode = "21740";

            var result = postalCode.IsValidPostalCode();

            var timeSpan = 20.Seconds().Ago();


        }
    }

    public static class StringExtensions
    {
        public static int ToInt32(this string value)
        {
            return Int32.Parse(value);
        }

        public static bool IsValidPostalCode(this string value)
        {
            return value.Length == 5;
        }
    }
}