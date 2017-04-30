﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="moviereviews")]
public partial class MovieReviewsDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertMovie(Movie instance);
  partial void UpdateMovie(Movie instance);
  partial void DeleteMovie(Movie instance);
  partial void InsertReview(Review instance);
  partial void UpdateReview(Review instance);
  partial void DeleteReview(Review instance);
  #endregion
	
	public MovieReviewsDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["moviereviewsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public MovieReviewsDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MovieReviewsDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MovieReviewsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MovieReviewsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Movie> Movies
	{
		get
		{
			return this.GetTable<Movie>();
		}
	}
	
	public System.Data.Linq.Table<Review> Reviews
	{
		get
		{
			return this.GetTable<Review>();
		}
	}
	
	[Function(Name="dbo.GetHighestRankedMovies")]
	public ISingleResult<Movie> GetHighestRankedMovies([Parameter(Name="SinceDate", DbType="DateTime")] System.Nullable<System.DateTime> sinceDate)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sinceDate);
		return ((ISingleResult<Movie>)(result.ReturnValue));
	}
}

[Table(Name="dbo.movies")]
public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Title;
	
	private System.DateTime _ReleaseDate;
	
	private EntitySet<Review> _Reviews;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnReleaseDateChanging(System.DateTime value);
    partial void OnReleaseDateChanged();
    #endregion
	
	public Movie()
	{
		this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
		OnCreated();
	}
	
	[Column(Name="movie_id", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Name="title", Storage="_Title", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[Column(Name="release_date", Storage="_ReleaseDate", DbType="DateTime NOT NULL")]
	public System.DateTime ReleaseDate
	{
		get
		{
			return this._ReleaseDate;
		}
		set
		{
			if ((this._ReleaseDate != value))
			{
				this.OnReleaseDateChanging(value);
				this.SendPropertyChanging();
				this._ReleaseDate = value;
				this.SendPropertyChanged("ReleaseDate");
				this.OnReleaseDateChanged();
			}
		}
	}
	
	[Association(Name="Movie_Review", Storage="_Reviews", ThisKey="ID", OtherKey="MovieID")]
	public EntitySet<Review> Reviews
	{
		get
		{
			return this._Reviews;
		}
		set
		{
			this._Reviews.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Reviews(Review entity)
	{
		this.SendPropertyChanging();
		entity.Movie = this;
	}
	
	private void detach_Reviews(Review entity)
	{
		this.SendPropertyChanging();
		entity.Movie = null;
	}
}

[Table(Name="dbo.reviews")]
public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private int _MovieID;
	
	private string _Summary;
	
	private int _rating;
	
	private string _review1;
	
	private string _reviewer;
	
	private EntityRef<Movie> _Movie;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnratingChanging(int value);
    partial void OnratingChanged();
    partial void Onreview1Changing(string value);
    partial void Onreview1Changed();
    partial void OnreviewerChanging(string value);
    partial void OnreviewerChanged();
    #endregion
	
	public Review()
	{
		this._Movie = default(EntityRef<Movie>);
		OnCreated();
	}
	
	[Column(Name="review_id", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Name="movie_id", Storage="_MovieID", DbType="Int NOT NULL")]
	public int MovieID
	{
		get
		{
			return this._MovieID;
		}
		set
		{
			if ((this._MovieID != value))
			{
				this.OnMovieIDChanging(value);
				this.SendPropertyChanging();
				this._MovieID = value;
				this.SendPropertyChanged("MovieID");
				this.OnMovieIDChanged();
			}
		}
	}
	
	[Column(Name="summary", Storage="_Summary", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
	public string Summary
	{
		get
		{
			return this._Summary;
		}
		set
		{
			if ((this._Summary != value))
			{
				this.OnSummaryChanging(value);
				this.SendPropertyChanging();
				this._Summary = value;
				this.SendPropertyChanged("Summary");
				this.OnSummaryChanged();
			}
		}
	}
	
	[Column(Storage="_rating", DbType="Int NOT NULL")]
	public int rating
	{
		get
		{
			return this._rating;
		}
		set
		{
			if ((this._rating != value))
			{
				this.OnratingChanging(value);
				this.SendPropertyChanging();
				this._rating = value;
				this.SendPropertyChanged("rating");
				this.OnratingChanged();
			}
		}
	}
	
	[Column(Name="review", Storage="_review1", DbType="NVarChar(512) NOT NULL", CanBeNull=false)]
	public string review1
	{
		get
		{
			return this._review1;
		}
		set
		{
			if ((this._review1 != value))
			{
				this.Onreview1Changing(value);
				this.SendPropertyChanging();
				this._review1 = value;
				this.SendPropertyChanged("review1");
				this.Onreview1Changed();
			}
		}
	}
	
	[Column(Storage="_reviewer", DbType="NVarChar(64)")]
	public string reviewer
	{
		get
		{
			return this._reviewer;
		}
		set
		{
			if ((this._reviewer != value))
			{
				this.OnreviewerChanging(value);
				this.SendPropertyChanging();
				this._reviewer = value;
				this.SendPropertyChanged("reviewer");
				this.OnreviewerChanged();
			}
		}
	}
	
	[Association(Name="Movie_Review", Storage="_Movie", ThisKey="MovieID", OtherKey="ID", IsForeignKey=true)]
	public Movie Movie
	{
		get
		{
			return this._Movie.Entity;
		}
		set
		{
			Movie previousValue = this._Movie.Entity;
			if (((previousValue != value) 
						|| (this._Movie.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Movie.Entity = null;
					previousValue.Reviews.Remove(this);
				}
				this._Movie.Entity = value;
				if ((value != null))
				{
					value.Reviews.Add(this);
					this._MovieID = value.ID;
				}
				else
				{
					this._MovieID = default(int);
				}
				this.SendPropertyChanged("Movie");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
