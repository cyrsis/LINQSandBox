using System;
using System.Collections.Generic;
using BeyondQueries.Domain.BuilderExtensions;
using BeyondQueries.Models.Data;

namespace BeyondQueries.Domain
{
    public class MovieFlowchart : Flowchart<Movie, MovieResult>
    {
        public MovieFlowchart()
        {
            var chart = this;

            chart.AddShape("CheckTitle")                     
                    .Requires(m => m.Title)
                    .WithArrowPointingTo("CheckLength").AndRule(m => !String.IsNullOrEmpty(m.Title))
                .AddShape("CheckLength")
                    .Requires(m => m.Length)
                    .WithArrowPointingTo("BadMovie").AndRule(LengthIsTooLong)
                    .WithArrowPointingTo("GoodMovie").AndRule(LengthIsJustRight)
                    .WithArrowPointingTo("CheckReleaseDate").AndRule(LengthExists)
                .AddShape("CheckReleaseDate")
                    .Requires(m => m.ReleaseDate)
                    .WithArrowPointingTo("BadMovie").AndRule(TooOld)
                    .WithArrowPointingTo("GoodMovie").AndRule(HasReleaseDate)

                .AddShape("BadMovie").YieldsResult(MovieResult.BadMovie)
                .AddShape("GoodMovie").YieldsResult(MovieResult.GoodMovie);            
        }

        public static MovieFlowchart CreateWithoutApi()
        {
            var chart = new MovieFlowchart();
            chart.Shapes.Add(
                new Shape<Movie, MovieResult>()
                {
                        Name = "CheckTitle",
                        Arrows = 
                        {
                            new Arrow<Movie>
                            {
                                PointsTo = "CheckLength", 
                                Rule = m => !String.IsNullOrEmpty(m.Title)
                            }                                                           
                        },
                        RequiredField = new PropertySpecifier<Movie>(m=>m.Title)
                }
                // ... and so on
            );

            return chart;
        }

        #region Rules
        Func<Movie, bool> TitleNotNullOrEmpty = m => !String.IsNullOrEmpty(m.Title);

        Func<Movie, bool> LengthIsTooLong = m => m.Length > 240;

        Func<Movie, bool> LengthIsJustRight = m => m.Length == 75;

        Func<Movie, bool> LengthExists = m => m.Length.HasValue;

        Func<Movie, bool> TooOld = m => m.ReleaseDate.HasValue &&
                                        m.ReleaseDate.Value.Year < 2000;

        Func<Movie, bool> HasReleaseDate = m => m.ReleaseDate.HasValue;  
        #endregion       
    }
}