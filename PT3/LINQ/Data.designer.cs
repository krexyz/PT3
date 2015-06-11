﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT3.LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OnlineTest")]
	public partial class DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertusername(username instance);
    partial void Updateusername(username instance);
    partial void Deleteusername(username instance);
    partial void Inserttest(test instance);
    partial void Updatetest(test instance);
    partial void Deletetest(test instance);
    partial void Insertsubject(subject instance);
    partial void Updatesubject(subject instance);
    partial void Deletesubject(subject instance);
    partial void Insertteacher(teacher instance);
    partial void Updateteacher(teacher instance);
    partial void Deleteteacher(teacher instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    partial void Insertquestion(question instance);
    partial void Updatequestion(question instance);
    partial void Deletequestion(question instance);
    partial void Inserttestquestion(testquestion instance);
    partial void Updatetestquestion(testquestion instance);
    partial void Deletetestquestion(testquestion instance);
    partial void Insertobjectiveanswer(objectiveanswer instance);
    partial void Updateobjectiveanswer(objectiveanswer instance);
    partial void Deleteobjectiveanswer(objectiveanswer instance);
    #endregion
		
		public DataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OnlineTestConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<username> usernames
		{
			get
			{
				return this.GetTable<username>();
			}
		}
		
		public System.Data.Linq.Table<test> tests
		{
			get
			{
				return this.GetTable<test>();
			}
		}
		
		public System.Data.Linq.Table<subject> subjects
		{
			get
			{
				return this.GetTable<subject>();
			}
		}
		
		public System.Data.Linq.Table<teacher> teachers
		{
			get
			{
				return this.GetTable<teacher>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
		
		public System.Data.Linq.Table<question> questions
		{
			get
			{
				return this.GetTable<question>();
			}
		}
		
		public System.Data.Linq.Table<testquestion> testquestions
		{
			get
			{
				return this.GetTable<testquestion>();
			}
		}
		
		public System.Data.Linq.Table<objectiveanswer> objectiveanswers
		{
			get
			{
				return this.GetTable<objectiveanswer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.username")]
	public partial class username : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _username1;
		
		private string _password;
		
		private System.Nullable<int> _privilage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void Onusername1Changing(string value);
    partial void Onusername1Changed();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnprivilageChanging(System.Nullable<int> value);
    partial void OnprivilageChanged();
    #endregion
		
		public username()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="username", Storage="_username1", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string username1
		{
			get
			{
				return this._username1;
			}
			set
			{
				if ((this._username1 != value))
				{
					this.Onusername1Changing(value);
					this.SendPropertyChanging();
					this._username1 = value;
					this.SendPropertyChanged("username1");
					this.Onusername1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_privilage", DbType="Int")]
		public System.Nullable<int> privilage
		{
			get
			{
				return this._privilage;
			}
			set
			{
				if ((this._privilage != value))
				{
					this.OnprivilageChanging(value);
					this.SendPropertyChanging();
					this._privilage = value;
					this.SendPropertyChanged("privilage");
					this.OnprivilageChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.test")]
	public partial class test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _testID;
		
		private System.Nullable<int> _time;
		
		private System.Nullable<System.DateTime> _timeStart;
		
		private System.Nullable<System.DateTime> _timeEnd;
		
		private string _totalMarks;
		
		private int _subjectID;
		
		private EntityRef<testquestion> _testquestions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntestIDChanging(int value);
    partial void OntestIDChanged();
    partial void OntimeChanging(System.Nullable<int> value);
    partial void OntimeChanged();
    partial void OntimeStartChanging(System.Nullable<System.DateTime> value);
    partial void OntimeStartChanged();
    partial void OntimeEndChanging(System.Nullable<System.DateTime> value);
    partial void OntimeEndChanged();
    partial void OntotalMarksChanging(string value);
    partial void OntotalMarksChanged();
    partial void OnsubjectIDChanging(int value);
    partial void OnsubjectIDChanged();
    #endregion
		
		public test()
		{
			this._testquestions = default(EntityRef<testquestion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_testID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int testID
		{
			get
			{
				return this._testID;
			}
			set
			{
				if ((this._testID != value))
				{
					this.OntestIDChanging(value);
					this.SendPropertyChanging();
					this._testID = value;
					this.SendPropertyChanged("testID");
					this.OntestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="Int")]
		public System.Nullable<int> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeStart", DbType="DateTime2")]
		public System.Nullable<System.DateTime> timeStart
		{
			get
			{
				return this._timeStart;
			}
			set
			{
				if ((this._timeStart != value))
				{
					this.OntimeStartChanging(value);
					this.SendPropertyChanging();
					this._timeStart = value;
					this.SendPropertyChanged("timeStart");
					this.OntimeStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeEnd", DbType="DateTime2")]
		public System.Nullable<System.DateTime> timeEnd
		{
			get
			{
				return this._timeEnd;
			}
			set
			{
				if ((this._timeEnd != value))
				{
					this.OntimeEndChanging(value);
					this.SendPropertyChanging();
					this._timeEnd = value;
					this.SendPropertyChanged("timeEnd");
					this.OntimeEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalMarks", DbType="NVarChar(45)")]
		public string totalMarks
		{
			get
			{
				return this._totalMarks;
			}
			set
			{
				if ((this._totalMarks != value))
				{
					this.OntotalMarksChanging(value);
					this.SendPropertyChanging();
					this._totalMarks = value;
					this.SendPropertyChanged("totalMarks");
					this.OntotalMarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectID", DbType="Int NOT NULL")]
		public int subjectID
		{
			get
			{
				return this._subjectID;
			}
			set
			{
				if ((this._subjectID != value))
				{
					this.OnsubjectIDChanging(value);
					this.SendPropertyChanging();
					this._subjectID = value;
					this.SendPropertyChanged("subjectID");
					this.OnsubjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="test_testquestion", Storage="_testquestions", ThisKey="testID", OtherKey="testID", IsUnique=true, IsForeignKey=false)]
		public testquestion testquestions
		{
			get
			{
				return this._testquestions.Entity;
			}
			set
			{
				testquestion previousValue = this._testquestions.Entity;
				if (((previousValue != value) 
							|| (this._testquestions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._testquestions.Entity = null;
						previousValue.test = null;
					}
					this._testquestions.Entity = value;
					if ((value != null))
					{
						value.test = this;
					}
					this.SendPropertyChanged("testquestions");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.subject")]
	public partial class subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _subjectID;
		
		private string _SubjectName;
		
		private System.Nullable<int> _subjectCredit;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsubjectIDChanging(int value);
    partial void OnsubjectIDChanged();
    partial void OnSubjectNameChanging(string value);
    partial void OnSubjectNameChanged();
    partial void OnsubjectCreditChanging(System.Nullable<int> value);
    partial void OnsubjectCreditChanged();
    #endregion
		
		public subject()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int subjectID
		{
			get
			{
				return this._subjectID;
			}
			set
			{
				if ((this._subjectID != value))
				{
					this.OnsubjectIDChanging(value);
					this.SendPropertyChanging();
					this._subjectID = value;
					this.SendPropertyChanged("subjectID");
					this.OnsubjectIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(45)")]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this.OnSubjectNameChanging(value);
					this.SendPropertyChanging();
					this._SubjectName = value;
					this.SendPropertyChanged("SubjectName");
					this.OnSubjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subjectCredit", DbType="Int")]
		public System.Nullable<int> subjectCredit
		{
			get
			{
				return this._subjectCredit;
			}
			set
			{
				if ((this._subjectCredit != value))
				{
					this.OnsubjectCreditChanging(value);
					this.SendPropertyChanging();
					this._subjectCredit = value;
					this.SendPropertyChanged("subjectCredit");
					this.OnsubjectCreditChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.teacher")]
	public partial class teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public teacher()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(45)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _name;
		
		private int _classID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnclassIDChanging(int value);
    partial void OnclassIDChanged();
    #endregion
		
		public student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(45)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_classID", DbType="Int NOT NULL")]
		public int classID
		{
			get
			{
				return this._classID;
			}
			set
			{
				if ((this._classID != value))
				{
					this.OnclassIDChanging(value);
					this.SendPropertyChanging();
					this._classID = value;
					this.SendPropertyChanged("classID");
					this.OnclassIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.question")]
	public partial class question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _questionID;
		
		private System.Nullable<int> _questionType;
		
		private string _questionText;
		
		private string _questionAnswer;
		
		private System.Nullable<int> _questionMarks;
		
		private EntityRef<testquestion> _testquestions;
		
		private EntityRef<objectiveanswer> _objectiveanswers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnquestionIDChanging(int value);
    partial void OnquestionIDChanged();
    partial void OnquestionTypeChanging(System.Nullable<int> value);
    partial void OnquestionTypeChanged();
    partial void OnquestionTextChanging(string value);
    partial void OnquestionTextChanged();
    partial void OnquestionAnswerChanging(string value);
    partial void OnquestionAnswerChanged();
    partial void OnquestionMarksChanging(System.Nullable<int> value);
    partial void OnquestionMarksChanged();
    #endregion
		
		public question()
		{
			this._testquestions = default(EntityRef<testquestion>);
			this._objectiveanswers = default(EntityRef<objectiveanswer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int questionID
		{
			get
			{
				return this._questionID;
			}
			set
			{
				if ((this._questionID != value))
				{
					this.OnquestionIDChanging(value);
					this.SendPropertyChanging();
					this._questionID = value;
					this.SendPropertyChanged("questionID");
					this.OnquestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionType", DbType="Int")]
		public System.Nullable<int> questionType
		{
			get
			{
				return this._questionType;
			}
			set
			{
				if ((this._questionType != value))
				{
					this.OnquestionTypeChanging(value);
					this.SendPropertyChanging();
					this._questionType = value;
					this.SendPropertyChanged("questionType");
					this.OnquestionTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionText", DbType="NVarChar(300)")]
		public string questionText
		{
			get
			{
				return this._questionText;
			}
			set
			{
				if ((this._questionText != value))
				{
					this.OnquestionTextChanging(value);
					this.SendPropertyChanging();
					this._questionText = value;
					this.SendPropertyChanged("questionText");
					this.OnquestionTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionAnswer", DbType="NVarChar(64)")]
		public string questionAnswer
		{
			get
			{
				return this._questionAnswer;
			}
			set
			{
				if ((this._questionAnswer != value))
				{
					this.OnquestionAnswerChanging(value);
					this.SendPropertyChanging();
					this._questionAnswer = value;
					this.SendPropertyChanged("questionAnswer");
					this.OnquestionAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionMarks", DbType="Int")]
		public System.Nullable<int> questionMarks
		{
			get
			{
				return this._questionMarks;
			}
			set
			{
				if ((this._questionMarks != value))
				{
					this.OnquestionMarksChanging(value);
					this.SendPropertyChanging();
					this._questionMarks = value;
					this.SendPropertyChanged("questionMarks");
					this.OnquestionMarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="question_testquestion", Storage="_testquestions", ThisKey="questionID", OtherKey="questionID", IsUnique=true, IsForeignKey=false)]
		public testquestion testquestions
		{
			get
			{
				return this._testquestions.Entity;
			}
			set
			{
				testquestion previousValue = this._testquestions.Entity;
				if (((previousValue != value) 
							|| (this._testquestions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._testquestions.Entity = null;
						previousValue.question = null;
					}
					this._testquestions.Entity = value;
					if ((value != null))
					{
						value.question = this;
					}
					this.SendPropertyChanged("testquestions");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="question_objectiveanswer", Storage="_objectiveanswers", ThisKey="questionID", OtherKey="questionID", IsUnique=true, IsForeignKey=false)]
		public objectiveanswer objectiveanswers
		{
			get
			{
				return this._objectiveanswers.Entity;
			}
			set
			{
				objectiveanswer previousValue = this._objectiveanswers.Entity;
				if (((previousValue != value) 
							|| (this._objectiveanswers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._objectiveanswers.Entity = null;
						previousValue.question = null;
					}
					this._objectiveanswers.Entity = value;
					if ((value != null))
					{
						value.question = this;
					}
					this.SendPropertyChanged("objectiveanswers");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.testquestion")]
	public partial class testquestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _testID;
		
		private int _questionID;
		
		private EntityRef<question> _question;
		
		private EntityRef<test> _test;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntestIDChanging(int value);
    partial void OntestIDChanged();
    partial void OnquestionIDChanging(int value);
    partial void OnquestionIDChanged();
    #endregion
		
		public testquestion()
		{
			this._question = default(EntityRef<question>);
			this._test = default(EntityRef<test>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_testID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int testID
		{
			get
			{
				return this._testID;
			}
			set
			{
				if ((this._testID != value))
				{
					if (this._test.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntestIDChanging(value);
					this.SendPropertyChanging();
					this._testID = value;
					this.SendPropertyChanged("testID");
					this.OntestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int questionID
		{
			get
			{
				return this._questionID;
			}
			set
			{
				if ((this._questionID != value))
				{
					if (this._question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnquestionIDChanging(value);
					this.SendPropertyChanging();
					this._questionID = value;
					this.SendPropertyChanged("questionID");
					this.OnquestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="question_testquestion", Storage="_question", ThisKey="questionID", OtherKey="questionID", IsForeignKey=true)]
		public question question
		{
			get
			{
				return this._question.Entity;
			}
			set
			{
				question previousValue = this._question.Entity;
				if (((previousValue != value) 
							|| (this._question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._question.Entity = null;
						previousValue.testquestions = null;
					}
					this._question.Entity = value;
					if ((value != null))
					{
						value.testquestions = this;
						this._questionID = value.questionID;
					}
					else
					{
						this._questionID = default(int);
					}
					this.SendPropertyChanged("question");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="test_testquestion", Storage="_test", ThisKey="testID", OtherKey="testID", IsForeignKey=true)]
		public test test
		{
			get
			{
				return this._test.Entity;
			}
			set
			{
				test previousValue = this._test.Entity;
				if (((previousValue != value) 
							|| (this._test.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._test.Entity = null;
						previousValue.testquestions = null;
					}
					this._test.Entity = value;
					if ((value != null))
					{
						value.testquestions = this;
						this._testID = value.testID;
					}
					else
					{
						this._testID = default(int);
					}
					this.SendPropertyChanged("test");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.objectiveanswers")]
	public partial class objectiveanswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _questionID;
		
		private string _AnswerA;
		
		private string _AnswerB;
		
		private string _AnswerC;
		
		private string _AnswerD;
		
		private EntityRef<question> _question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnquestionIDChanging(int value);
    partial void OnquestionIDChanged();
    partial void OnAnswerAChanging(string value);
    partial void OnAnswerAChanged();
    partial void OnAnswerBChanging(string value);
    partial void OnAnswerBChanged();
    partial void OnAnswerCChanging(string value);
    partial void OnAnswerCChanged();
    partial void OnAnswerDChanging(string value);
    partial void OnAnswerDChanged();
    #endregion
		
		public objectiveanswer()
		{
			this._question = default(EntityRef<question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_questionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int questionID
		{
			get
			{
				return this._questionID;
			}
			set
			{
				if ((this._questionID != value))
				{
					if (this._question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnquestionIDChanging(value);
					this.SendPropertyChanging();
					this._questionID = value;
					this.SendPropertyChanged("questionID");
					this.OnquestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerA", DbType="NVarChar(60)")]
		public string AnswerA
		{
			get
			{
				return this._AnswerA;
			}
			set
			{
				if ((this._AnswerA != value))
				{
					this.OnAnswerAChanging(value);
					this.SendPropertyChanging();
					this._AnswerA = value;
					this.SendPropertyChanged("AnswerA");
					this.OnAnswerAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerB", DbType="NVarChar(60)")]
		public string AnswerB
		{
			get
			{
				return this._AnswerB;
			}
			set
			{
				if ((this._AnswerB != value))
				{
					this.OnAnswerBChanging(value);
					this.SendPropertyChanging();
					this._AnswerB = value;
					this.SendPropertyChanged("AnswerB");
					this.OnAnswerBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerC", DbType="NVarChar(60)")]
		public string AnswerC
		{
			get
			{
				return this._AnswerC;
			}
			set
			{
				if ((this._AnswerC != value))
				{
					this.OnAnswerCChanging(value);
					this.SendPropertyChanging();
					this._AnswerC = value;
					this.SendPropertyChanged("AnswerC");
					this.OnAnswerCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerD", DbType="NVarChar(60)")]
		public string AnswerD
		{
			get
			{
				return this._AnswerD;
			}
			set
			{
				if ((this._AnswerD != value))
				{
					this.OnAnswerDChanging(value);
					this.SendPropertyChanging();
					this._AnswerD = value;
					this.SendPropertyChanged("AnswerD");
					this.OnAnswerDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="question_objectiveanswer", Storage="_question", ThisKey="questionID", OtherKey="questionID", IsForeignKey=true)]
		public question question
		{
			get
			{
				return this._question.Entity;
			}
			set
			{
				question previousValue = this._question.Entity;
				if (((previousValue != value) 
							|| (this._question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._question.Entity = null;
						previousValue.objectiveanswers = null;
					}
					this._question.Entity = value;
					if ((value != null))
					{
						value.objectiveanswers = this;
						this._questionID = value.questionID;
					}
					else
					{
						this._questionID = default(int);
					}
					this.SendPropertyChanged("question");
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