﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sareAam")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertadmin(admin instance);
  partial void Updateadmin(admin instance);
  partial void Deleteadmin(admin instance);
  partial void Insertpost(post instance);
  partial void Updatepost(post instance);
  partial void Deletepost(post instance);
  partial void Insertpage(page instance);
  partial void Updatepage(page instance);
  partial void Deletepage(page instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<admin> admins
	{
		get
		{
			return this.GetTable<admin>();
		}
	}
	
	public System.Data.Linq.Table<post> posts
	{
		get
		{
			return this.GetTable<post>();
		}
	}
	
	public System.Data.Linq.Table<page> pages
	{
		get
		{
			return this.GetTable<page>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _ad_username;
	
	private string _ad_password;
	
	private int _ad_id;
	
	private EntitySet<post> _posts;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onad_usernameChanging(string value);
    partial void Onad_usernameChanged();
    partial void Onad_passwordChanging(string value);
    partial void Onad_passwordChanged();
    partial void Onad_idChanging(int value);
    partial void Onad_idChanged();
    #endregion
	
	public admin()
	{
		this._posts = new EntitySet<post>(new Action<post>(this.attach_posts), new Action<post>(this.detach_posts));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ad_username
	{
		get
		{
			return this._ad_username;
		}
		set
		{
			if ((this._ad_username != value))
			{
				this.Onad_usernameChanging(value);
				this.SendPropertyChanging();
				this._ad_username = value;
				this.SendPropertyChanged("ad_username");
				this.Onad_usernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ad_password
	{
		get
		{
			return this._ad_password;
		}
		set
		{
			if ((this._ad_password != value))
			{
				this.Onad_passwordChanging(value);
				this.SendPropertyChanging();
				this._ad_password = value;
				this.SendPropertyChanged("ad_password");
				this.Onad_passwordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ad_id
	{
		get
		{
			return this._ad_id;
		}
		set
		{
			if ((this._ad_id != value))
			{
				this.Onad_idChanging(value);
				this.SendPropertyChanging();
				this._ad_id = value;
				this.SendPropertyChanged("ad_id");
				this.Onad_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_post", Storage="_posts", ThisKey="ad_id", OtherKey="ad_id")]
	public EntitySet<post> posts
	{
		get
		{
			return this._posts;
		}
		set
		{
			this._posts.Assign(value);
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
	
	private void attach_posts(post entity)
	{
		this.SendPropertyChanging();
		entity.admin = this;
	}
	
	private void detach_posts(post entity)
	{
		this.SendPropertyChanging();
		entity.admin = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.post")]
public partial class post : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _post_id;
	
	private int _ad_id;
	
	private string _disclaimer;
	
	private string _Title;
	
	private string _link;
	
	private string _file_name;
	
	private int _page_id;
	
	private string _Breif;
	
	private EntityRef<admin> _admin;
	
	private EntityRef<page> _page;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpost_idChanging(int value);
    partial void Onpost_idChanged();
    partial void Onad_idChanging(int value);
    partial void Onad_idChanged();
    partial void OndisclaimerChanging(string value);
    partial void OndisclaimerChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnlinkChanging(string value);
    partial void OnlinkChanged();
    partial void Onfile_nameChanging(string value);
    partial void Onfile_nameChanged();
    partial void Onpage_idChanging(int value);
    partial void Onpage_idChanged();
    partial void OnBreifChanging(string value);
    partial void OnBreifChanged();
    #endregion
	
	public post()
	{
		this._admin = default(EntityRef<admin>);
		this._page = default(EntityRef<page>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_post_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int post_id
	{
		get
		{
			return this._post_id;
		}
		set
		{
			if ((this._post_id != value))
			{
				this.Onpost_idChanging(value);
				this.SendPropertyChanging();
				this._post_id = value;
				this.SendPropertyChanged("post_id");
				this.Onpost_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad_id", DbType="Int NOT NULL")]
	public int ad_id
	{
		get
		{
			return this._ad_id;
		}
		set
		{
			if ((this._ad_id != value))
			{
				if (this._admin.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onad_idChanging(value);
				this.SendPropertyChanging();
				this._ad_id = value;
				this.SendPropertyChanged("ad_id");
				this.Onad_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disclaimer", DbType="NVarChar(500)")]
	public string disclaimer
	{
		get
		{
			return this._disclaimer;
		}
		set
		{
			if ((this._disclaimer != value))
			{
				this.OndisclaimerChanging(value);
				this.SendPropertyChanging();
				this._disclaimer = value;
				this.SendPropertyChanged("disclaimer");
				this.OndisclaimerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_link", DbType="NVarChar(500)")]
	public string link
	{
		get
		{
			return this._link;
		}
		set
		{
			if ((this._link != value))
			{
				this.OnlinkChanging(value);
				this.SendPropertyChanging();
				this._link = value;
				this.SendPropertyChanged("link");
				this.OnlinkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_file_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string file_name
	{
		get
		{
			return this._file_name;
		}
		set
		{
			if ((this._file_name != value))
			{
				this.Onfile_nameChanging(value);
				this.SendPropertyChanging();
				this._file_name = value;
				this.SendPropertyChanged("file_name");
				this.Onfile_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_page_id", DbType="Int NOT NULL")]
	public int page_id
	{
		get
		{
			return this._page_id;
		}
		set
		{
			if ((this._page_id != value))
			{
				if (this._page.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onpage_idChanging(value);
				this.SendPropertyChanging();
				this._page_id = value;
				this.SendPropertyChanged("page_id");
				this.Onpage_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breif", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
	public string Breif
	{
		get
		{
			return this._Breif;
		}
		set
		{
			if ((this._Breif != value))
			{
				this.OnBreifChanging(value);
				this.SendPropertyChanging();
				this._Breif = value;
				this.SendPropertyChanged("Breif");
				this.OnBreifChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_post", Storage="_admin", ThisKey="ad_id", OtherKey="ad_id", IsForeignKey=true)]
	public admin admin
	{
		get
		{
			return this._admin.Entity;
		}
		set
		{
			admin previousValue = this._admin.Entity;
			if (((previousValue != value) 
						|| (this._admin.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._admin.Entity = null;
					previousValue.posts.Remove(this);
				}
				this._admin.Entity = value;
				if ((value != null))
				{
					value.posts.Add(this);
					this._ad_id = value.ad_id;
				}
				else
				{
					this._ad_id = default(int);
				}
				this.SendPropertyChanged("admin");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="page_post", Storage="_page", ThisKey="page_id", OtherKey="page_id", IsForeignKey=true)]
	public page page
	{
		get
		{
			return this._page.Entity;
		}
		set
		{
			page previousValue = this._page.Entity;
			if (((previousValue != value) 
						|| (this._page.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._page.Entity = null;
					previousValue.posts.Remove(this);
				}
				this._page.Entity = value;
				if ((value != null))
				{
					value.posts.Add(this);
					this._page_id = value.page_id;
				}
				else
				{
					this._page_id = default(int);
				}
				this.SendPropertyChanged("page");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pages")]
public partial class page : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _page_id;
	
	private string _page_name;
	
	private EntitySet<post> _posts;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpage_idChanging(int value);
    partial void Onpage_idChanged();
    partial void Onpage_nameChanging(string value);
    partial void Onpage_nameChanged();
    #endregion
	
	public page()
	{
		this._posts = new EntitySet<post>(new Action<post>(this.attach_posts), new Action<post>(this.detach_posts));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_page_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int page_id
	{
		get
		{
			return this._page_id;
		}
		set
		{
			if ((this._page_id != value))
			{
				this.Onpage_idChanging(value);
				this.SendPropertyChanging();
				this._page_id = value;
				this.SendPropertyChanged("page_id");
				this.Onpage_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_page_name", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
	public string page_name
	{
		get
		{
			return this._page_name;
		}
		set
		{
			if ((this._page_name != value))
			{
				this.Onpage_nameChanging(value);
				this.SendPropertyChanging();
				this._page_name = value;
				this.SendPropertyChanged("page_name");
				this.Onpage_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="page_post", Storage="_posts", ThisKey="page_id", OtherKey="page_id")]
	public EntitySet<post> posts
	{
		get
		{
			return this._posts;
		}
		set
		{
			this._posts.Assign(value);
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
	
	private void attach_posts(post entity)
	{
		this.SendPropertyChanging();
		entity.page = this;
	}
	
	private void detach_posts(post entity)
	{
		this.SendPropertyChanging();
		entity.page = null;
	}
}
#pragma warning restore 1591
