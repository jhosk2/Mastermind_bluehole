﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserVoiceViewer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mastermind")]
	public partial class TeraArticleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertLog(Log instance);
    partial void UpdateLog(Log instance);
    partial void DeleteLog(Log instance);
    partial void InsertCheckPoint(CheckPoint instance);
    partial void UpdateCheckPoint(CheckPoint instance);
    partial void DeleteCheckPoint(CheckPoint instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    #endregion
		
		public TeraArticleDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["mastermindConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TeraArticleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeraArticleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeraArticleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TeraArticleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Article> Articles
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<Log> Logs
		{
			get
			{
				return this.GetTable<Log>();
			}
		}
		
		public System.Data.Linq.Table<CheckPoint> CheckPoints
		{
			get
			{
				return this.GetTable<CheckPoint>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comments
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Articles")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ArticleAutoId;
		
		private int _Game;
		
		private int _TargetSite;
		
		private int _CategoryId;
		
		private int _ArticleId;
		
		private string _Link;
		
		private string _RawHtml;
		
		private System.DateTime _CrawledTime;
		
		private string _Author;
		
		private string _Title;
		
		private string _ContentHtml;
		
		private System.Nullable<System.DateTime> _ArticleWrittenTime;
		
		private string _Keywords;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnArticleAutoIdChanging(int value);
    partial void OnArticleAutoIdChanged();
    partial void OnGameChanging(int value);
    partial void OnGameChanged();
    partial void OnTargetSiteChanging(int value);
    partial void OnTargetSiteChanged();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnArticleIdChanging(int value);
    partial void OnArticleIdChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    partial void OnRawHtmlChanging(string value);
    partial void OnRawHtmlChanged();
    partial void OnCrawledTimeChanging(System.DateTime value);
    partial void OnCrawledTimeChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnContentHtmlChanging(string value);
    partial void OnContentHtmlChanged();
    partial void OnArticleWrittenTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnArticleWrittenTimeChanged();
    partial void OnKeywordsChanging(string value);
    partial void OnKeywordsChanged();
    #endregion
		
		public Article()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleAutoId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ArticleAutoId
		{
			get
			{
				return this._ArticleAutoId;
			}
			set
			{
				if ((this._ArticleAutoId != value))
				{
					this.OnArticleAutoIdChanging(value);
					this.SendPropertyChanging();
					this._ArticleAutoId = value;
					this.SendPropertyChanged("ArticleAutoId");
					this.OnArticleAutoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Game", DbType="Int NOT NULL")]
		public int Game
		{
			get
			{
				return this._Game;
			}
			set
			{
				if ((this._Game != value))
				{
					this.OnGameChanging(value);
					this.SendPropertyChanging();
					this._Game = value;
					this.SendPropertyChanged("Game");
					this.OnGameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetSite", DbType="Int NOT NULL")]
		public int TargetSite
		{
			get
			{
				return this._TargetSite;
			}
			set
			{
				if ((this._TargetSite != value))
				{
					this.OnTargetSiteChanging(value);
					this.SendPropertyChanging();
					this._TargetSite = value;
					this.SendPropertyChanged("TargetSite");
					this.OnTargetSiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="Int NOT NULL")]
		public int CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleId", DbType="Int NOT NULL")]
		public int ArticleId
		{
			get
			{
				return this._ArticleId;
			}
			set
			{
				if ((this._ArticleId != value))
				{
					this.OnArticleIdChanging(value);
					this.SendPropertyChanging();
					this._ArticleId = value;
					this.SendPropertyChanged("ArticleId");
					this.OnArticleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RawHtml", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string RawHtml
		{
			get
			{
				return this._RawHtml;
			}
			set
			{
				if ((this._RawHtml != value))
				{
					this.OnRawHtmlChanging(value);
					this.SendPropertyChanging();
					this._RawHtml = value;
					this.SendPropertyChanged("RawHtml");
					this.OnRawHtmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CrawledTime", DbType="DateTime2 NOT NULL")]
		public System.DateTime CrawledTime
		{
			get
			{
				return this._CrawledTime;
			}
			set
			{
				if ((this._CrawledTime != value))
				{
					this.OnCrawledTimeChanging(value);
					this.SendPropertyChanging();
					this._CrawledTime = value;
					this.SendPropertyChanged("CrawledTime");
					this.OnCrawledTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(4000)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(4000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContentHtml", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ContentHtml
		{
			get
			{
				return this._ContentHtml;
			}
			set
			{
				if ((this._ContentHtml != value))
				{
					this.OnContentHtmlChanging(value);
					this.SendPropertyChanging();
					this._ContentHtml = value;
					this.SendPropertyChanged("ContentHtml");
					this.OnContentHtmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleWrittenTime", DbType="DateTime2")]
		public System.Nullable<System.DateTime> ArticleWrittenTime
		{
			get
			{
				return this._ArticleWrittenTime;
			}
			set
			{
				if ((this._ArticleWrittenTime != value))
				{
					this.OnArticleWrittenTimeChanging(value);
					this.SendPropertyChanging();
					this._ArticleWrittenTime = value;
					this.SendPropertyChanged("ArticleWrittenTime");
					this.OnArticleWrittenTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keywords", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Keywords
		{
			get
			{
				return this._Keywords;
			}
			set
			{
				if ((this._Keywords != value))
				{
					this.OnKeywordsChanging(value);
					this.SendPropertyChanging();
					this._Keywords = value;
					this.SendPropertyChanged("Keywords");
					this.OnKeywordsChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Logs")]
	public partial class Log : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LogId;
		
		private System.DateTime _TimeStamp;
		
		private int _LogType;
		
		private string _Message;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogIdChanging(int value);
    partial void OnLogIdChanged();
    partial void OnTimeStampChanging(System.DateTime value);
    partial void OnTimeStampChanged();
    partial void OnLogTypeChanging(int value);
    partial void OnLogTypeChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    #endregion
		
		public Log()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LogId
		{
			get
			{
				return this._LogId;
			}
			set
			{
				if ((this._LogId != value))
				{
					this.OnLogIdChanging(value);
					this.SendPropertyChanging();
					this._LogId = value;
					this.SendPropertyChanged("LogId");
					this.OnLogIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime2 NOT NULL")]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogType", DbType="Int NOT NULL")]
		public int LogType
		{
			get
			{
				return this._LogType;
			}
			set
			{
				if ((this._LogType != value))
				{
					this.OnLogTypeChanging(value);
					this.SendPropertyChanging();
					this._LogType = value;
					this.SendPropertyChanged("LogType");
					this.OnLogTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CheckPoints")]
	public partial class CheckPoint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AnalysisPhase;
		
		private int _ProcessedArticleId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAnalysisPhaseChanging(int value);
    partial void OnAnalysisPhaseChanged();
    partial void OnProcessedArticleIdChanging(int value);
    partial void OnProcessedArticleIdChanged();
    #endregion
		
		public CheckPoint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnalysisPhase", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AnalysisPhase
		{
			get
			{
				return this._AnalysisPhase;
			}
			set
			{
				if ((this._AnalysisPhase != value))
				{
					this.OnAnalysisPhaseChanging(value);
					this.SendPropertyChanging();
					this._AnalysisPhase = value;
					this.SendPropertyChanged("AnalysisPhase");
					this.OnAnalysisPhaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProcessedArticleId", DbType="Int NOT NULL")]
		public int ProcessedArticleId
		{
			get
			{
				return this._ProcessedArticleId;
			}
			set
			{
				if ((this._ProcessedArticleId != value))
				{
					this.OnProcessedArticleIdChanging(value);
					this.SendPropertyChanging();
					this._ProcessedArticleId = value;
					this.SendPropertyChanged("ProcessedArticleId");
					this.OnProcessedArticleIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comments")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CommentAutoId;
		
		private System.Nullable<int> _CommentId;
		
		private System.Nullable<int> _ParentCommentId;
		
		private int _ArticleAutoId;
		
		private string _Author;
		
		private string _ContentHtml;
		
		private System.Nullable<System.DateTime> _CommentWrittenTime;
		
		private System.Nullable<int> _LikeCount;
		
		private System.Nullable<int> _DislikeCount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentAutoIdChanging(int value);
    partial void OnCommentAutoIdChanged();
    partial void OnCommentIdChanging(System.Nullable<int> value);
    partial void OnCommentIdChanged();
    partial void OnParentCommentIdChanging(System.Nullable<int> value);
    partial void OnParentCommentIdChanged();
    partial void OnArticleAutoIdChanging(int value);
    partial void OnArticleAutoIdChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnContentHtmlChanging(string value);
    partial void OnContentHtmlChanged();
    partial void OnCommentWrittenTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnCommentWrittenTimeChanged();
    partial void OnLikeCountChanging(System.Nullable<int> value);
    partial void OnLikeCountChanged();
    partial void OnDislikeCountChanging(System.Nullable<int> value);
    partial void OnDislikeCountChanged();
    #endregion
		
		public Comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentAutoId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CommentAutoId
		{
			get
			{
				return this._CommentAutoId;
			}
			set
			{
				if ((this._CommentAutoId != value))
				{
					this.OnCommentAutoIdChanging(value);
					this.SendPropertyChanging();
					this._CommentAutoId = value;
					this.SendPropertyChanged("CommentAutoId");
					this.OnCommentAutoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", DbType="Int")]
		public System.Nullable<int> CommentId
		{
			get
			{
				return this._CommentId;
			}
			set
			{
				if ((this._CommentId != value))
				{
					this.OnCommentIdChanging(value);
					this.SendPropertyChanging();
					this._CommentId = value;
					this.SendPropertyChanged("CommentId");
					this.OnCommentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentCommentId", DbType="Int")]
		public System.Nullable<int> ParentCommentId
		{
			get
			{
				return this._ParentCommentId;
			}
			set
			{
				if ((this._ParentCommentId != value))
				{
					this.OnParentCommentIdChanging(value);
					this.SendPropertyChanging();
					this._ParentCommentId = value;
					this.SendPropertyChanged("ParentCommentId");
					this.OnParentCommentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArticleAutoId", DbType="Int NOT NULL")]
		public int ArticleAutoId
		{
			get
			{
				return this._ArticleAutoId;
			}
			set
			{
				if ((this._ArticleAutoId != value))
				{
					this.OnArticleAutoIdChanging(value);
					this.SendPropertyChanging();
					this._ArticleAutoId = value;
					this.SendPropertyChanged("ArticleAutoId");
					this.OnArticleAutoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(4000)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContentHtml", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ContentHtml
		{
			get
			{
				return this._ContentHtml;
			}
			set
			{
				if ((this._ContentHtml != value))
				{
					this.OnContentHtmlChanging(value);
					this.SendPropertyChanging();
					this._ContentHtml = value;
					this.SendPropertyChanged("ContentHtml");
					this.OnContentHtmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentWrittenTime", DbType="DateTime2")]
		public System.Nullable<System.DateTime> CommentWrittenTime
		{
			get
			{
				return this._CommentWrittenTime;
			}
			set
			{
				if ((this._CommentWrittenTime != value))
				{
					this.OnCommentWrittenTimeChanging(value);
					this.SendPropertyChanging();
					this._CommentWrittenTime = value;
					this.SendPropertyChanged("CommentWrittenTime");
					this.OnCommentWrittenTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LikeCount", DbType="Int")]
		public System.Nullable<int> LikeCount
		{
			get
			{
				return this._LikeCount;
			}
			set
			{
				if ((this._LikeCount != value))
				{
					this.OnLikeCountChanging(value);
					this.SendPropertyChanging();
					this._LikeCount = value;
					this.SendPropertyChanged("LikeCount");
					this.OnLikeCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DislikeCount", DbType="Int")]
		public System.Nullable<int> DislikeCount
		{
			get
			{
				return this._DislikeCount;
			}
			set
			{
				if ((this._DislikeCount != value))
				{
					this.OnDislikeCountChanging(value);
					this.SendPropertyChanging();
					this._DislikeCount = value;
					this.SendPropertyChanged("DislikeCount");
					this.OnDislikeCountChanged();
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
}
#pragma warning restore 1591
