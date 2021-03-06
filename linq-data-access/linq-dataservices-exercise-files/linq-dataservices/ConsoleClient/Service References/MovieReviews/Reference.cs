//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 12/6/2008 12:16:38 AM
namespace ConsoleClient.MovieReviews
{
    
    /// <summary>
    /// There are no comments for MovieReviewEntities in the schema.
    /// </summary>
    public partial class MovieReviewEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new MovieReviewEntities object.
        /// </summary>
        public MovieReviewEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("MovieReviewsModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ConsoleClient.MovieReviews", typeName.Substring(17)), true);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ConsoleClient.MovieReviews", global::System.StringComparison.Ordinal))
            {
                return string.Concat("MovieReviewsModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Movies in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Movie> Movies
        {
            get
            {
                if ((this._Movies == null))
                {
                    this._Movies = base.CreateQuery<Movie>("Movies");
                }
                return this._Movies;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Movie> _Movies;
        /// <summary>
        /// There are no comments for Reviews in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Review> Reviews
        {
            get
            {
                if ((this._Reviews == null))
                {
                    this._Reviews = base.CreateQuery<Review>("Reviews");
                }
                return this._Reviews;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Review> _Reviews;
        /// <summary>
        /// There are no comments for Movies in the schema.
        /// </summary>
        public void AddToMovies(Movie movie)
        {
            base.AddObject("Movies", movie);
        }
        /// <summary>
        /// There are no comments for Reviews in the schema.
        /// </summary>
        public void AddToReviews(Review review)
        {
            base.AddObject("Reviews", review);
        }
    }
    /// <summary>
    /// There are no comments for MovieReviewsModel.Movie in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Movie
    {
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="releaseDate">Initial value of ReleaseDate.</param>
        public static Movie CreateMovie(int ID, string title, global::System.DateTime releaseDate)
        {
            Movie movie = new Movie();
            movie.ID = ID;
            movie.Title = title;
            movie.ReleaseDate = releaseDate;
            return movie;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property ReleaseDate in the schema.
        /// </summary>
        public global::System.DateTime ReleaseDate
        {
            get
            {
                return this._ReleaseDate;
            }
            set
            {
                this.OnReleaseDateChanging(value);
                this._ReleaseDate = value;
                this.OnReleaseDateChanged();
            }
        }
        private global::System.DateTime _ReleaseDate;
        partial void OnReleaseDateChanging(global::System.DateTime value);
        partial void OnReleaseDateChanged();
        /// <summary>
        /// There are no comments for Reviews in the schema.
        /// </summary>
        public global::System.Collections.ObjectModel.Collection<Review> Reviews
        {
            get
            {
                return this._Reviews;
            }
            set
            {
                if ((value != null))
                {
                    this._Reviews = value;
                }
            }
        }
        private global::System.Collections.ObjectModel.Collection<Review> _Reviews = new global::System.Collections.ObjectModel.Collection<Review>();
    }
    /// <summary>
    /// There are no comments for MovieReviewsModel.Review in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Review
    {
        /// <summary>
        /// Create a new Review object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="summary">Initial value of Summary.</param>
        /// <param name="rating">Initial value of Rating.</param>
        /// <param name="body">Initial value of Body.</param>
        public static Review CreateReview(int ID, string summary, int rating, string body)
        {
            Review review = new Review();
            review.ID = ID;
            review.Summary = summary;
            review.Rating = rating;
            review.Body = body;
            return review;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Summary in the schema.
        /// </summary>
        public string Summary
        {
            get
            {
                return this._Summary;
            }
            set
            {
                this.OnSummaryChanging(value);
                this._Summary = value;
                this.OnSummaryChanged();
            }
        }
        private string _Summary;
        partial void OnSummaryChanging(string value);
        partial void OnSummaryChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        public int Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
            }
        }
        private int _Rating;
        partial void OnRatingChanging(int value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property Body in the schema.
        /// </summary>
        public string Body
        {
            get
            {
                return this._Body;
            }
            set
            {
                this.OnBodyChanging(value);
                this._Body = value;
                this.OnBodyChanged();
            }
        }
        private string _Body;
        partial void OnBodyChanging(string value);
        partial void OnBodyChanged();
        /// <summary>
        /// There are no comments for Property Reviewer in the schema.
        /// </summary>
        public string Reviewer
        {
            get
            {
                return this._Reviewer;
            }
            set
            {
                this.OnReviewerChanging(value);
                this._Reviewer = value;
                this.OnReviewerChanged();
            }
        }
        private string _Reviewer;
        partial void OnReviewerChanging(string value);
        partial void OnReviewerChanged();
        /// <summary>
        /// There are no comments for Movie in the schema.
        /// </summary>
        public Movie Movie
        {
            get
            {
                return this._Movie;
            }
            set
            {
                this._Movie = value;
            }
        }
        private Movie _Movie;
    }
}
