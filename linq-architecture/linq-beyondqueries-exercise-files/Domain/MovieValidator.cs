using System;
using System.Linq;
using BeyondQueries.Models.Data;

namespace BeyondQueries.Domain
{
    public class MovieValidator
    {
        public bool IsValid(Movie movie)
        {
            Func<Movie, bool>[] rules =
                {
                    m => string.IsNullOrEmpty(m.Title),
                    m => m.Length < 60 || m.Length > 400,
                    m => m.ReleaseDate.Value.Year < 1903
                };


            return rules.All(rule => rule(movie) == false);
        }
    }
}