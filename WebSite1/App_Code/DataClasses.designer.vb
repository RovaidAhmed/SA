﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="sareAam")>  _
Partial Public Class DataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertadmin(instance As admin)
    End Sub
  Partial Private Sub Updateadmin(instance As admin)
    End Sub
  Partial Private Sub Deleteadmin(instance As admin)
    End Sub
  Partial Private Sub Insertpage(instance As page)
    End Sub
  Partial Private Sub Updatepage(instance As page)
    End Sub
  Partial Private Sub Deletepage(instance As page)
    End Sub
  Partial Private Sub Insertpost(instance As post)
    End Sub
  Partial Private Sub Updatepost(instance As post)
    End Sub
  Partial Private Sub Deletepost(instance As post)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("sareAamConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property admins() As System.Data.Linq.Table(Of admin)
		Get
			Return Me.GetTable(Of admin)
		End Get
	End Property
	
	Public ReadOnly Property pages() As System.Data.Linq.Table(Of page)
		Get
			Return Me.GetTable(Of page)
		End Get
	End Property
	
	Public ReadOnly Property posts() As System.Data.Linq.Table(Of post)
		Get
			Return Me.GetTable(Of post)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.admin")>  _
Partial Public Class admin
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ad_username As String
	
	Private _ad_password As String
	
	Private _ad_id As Integer
	
	Private _posts As EntitySet(Of post)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onad_usernameChanging(value As String)
    End Sub
    Partial Private Sub Onad_usernameChanged()
    End Sub
    Partial Private Sub Onad_passwordChanging(value As String)
    End Sub
    Partial Private Sub Onad_passwordChanged()
    End Sub
    Partial Private Sub Onad_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onad_idChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._posts = New EntitySet(Of post)(AddressOf Me.attach_posts, AddressOf Me.detach_posts)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ad_username", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ad_username() As String
		Get
			Return Me._ad_username
		End Get
		Set
			If (String.Equals(Me._ad_username, value) = false) Then
				Me.Onad_usernameChanging(value)
				Me.SendPropertyChanging
				Me._ad_username = value
				Me.SendPropertyChanged("ad_username")
				Me.Onad_usernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ad_password", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ad_password() As String
		Get
			Return Me._ad_password
		End Get
		Set
			If (String.Equals(Me._ad_password, value) = false) Then
				Me.Onad_passwordChanging(value)
				Me.SendPropertyChanging
				Me._ad_password = value
				Me.SendPropertyChanged("ad_password")
				Me.Onad_passwordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ad_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ad_id() As Integer
		Get
			Return Me._ad_id
		End Get
		Set
			If ((Me._ad_id = value)  _
						= false) Then
				Me.Onad_idChanging(value)
				Me.SendPropertyChanging
				Me._ad_id = value
				Me.SendPropertyChanged("ad_id")
				Me.Onad_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="admin_post", Storage:="_posts", ThisKey:="ad_id", OtherKey:="ad_id")>  _
	Public Property posts() As EntitySet(Of post)
		Get
			Return Me._posts
		End Get
		Set
			Me._posts.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_posts(ByVal entity As post)
		Me.SendPropertyChanging
		entity.admin = Me
	End Sub
	
	Private Sub detach_posts(ByVal entity As post)
		Me.SendPropertyChanging
		entity.admin = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.pages")>  _
Partial Public Class page
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _page_id As Integer
	
	Private _page_name As String
	
	Private _posts As EntitySet(Of post)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onpage_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onpage_idChanged()
    End Sub
    Partial Private Sub Onpage_nameChanging(value As String)
    End Sub
    Partial Private Sub Onpage_nameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._posts = New EntitySet(Of post)(AddressOf Me.attach_posts, AddressOf Me.detach_posts)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_page_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property page_id() As Integer
		Get
			Return Me._page_id
		End Get
		Set
			If ((Me._page_id = value)  _
						= false) Then
				Me.Onpage_idChanging(value)
				Me.SendPropertyChanging
				Me._page_id = value
				Me.SendPropertyChanged("page_id")
				Me.Onpage_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_page_name", DbType:="NVarChar(500) NOT NULL", CanBeNull:=false)>  _
	Public Property page_name() As String
		Get
			Return Me._page_name
		End Get
		Set
			If (String.Equals(Me._page_name, value) = false) Then
				Me.Onpage_nameChanging(value)
				Me.SendPropertyChanging
				Me._page_name = value
				Me.SendPropertyChanged("page_name")
				Me.Onpage_nameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="page_post", Storage:="_posts", ThisKey:="page_id", OtherKey:="page_id")>  _
	Public Property posts() As EntitySet(Of post)
		Get
			Return Me._posts
		End Get
		Set
			Me._posts.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_posts(ByVal entity As post)
		Me.SendPropertyChanging
		entity.page = Me
	End Sub
	
	Private Sub detach_posts(ByVal entity As post)
		Me.SendPropertyChanging
		entity.page = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.post")>  _
Partial Public Class post
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _post_id As Integer
	
	Private _ad_id As Integer
	
	Private _disclaimer As String
	
	Private _Title As String
	
	Private _link As String
	
	Private _file_name As String
	
	Private _page_id As Integer
	
	Private _Breif As String
	
	Private _Author As String
	
	Private _admin As EntityRef(Of admin)
	
	Private _page As EntityRef(Of page)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onpost_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onpost_idChanged()
    End Sub
    Partial Private Sub Onad_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onad_idChanged()
    End Sub
    Partial Private Sub OndisclaimerChanging(value As String)
    End Sub
    Partial Private Sub OndisclaimerChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnlinkChanging(value As String)
    End Sub
    Partial Private Sub OnlinkChanged()
    End Sub
    Partial Private Sub Onfile_nameChanging(value As String)
    End Sub
    Partial Private Sub Onfile_nameChanged()
    End Sub
    Partial Private Sub Onpage_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onpage_idChanged()
    End Sub
    Partial Private Sub OnBreifChanging(value As String)
    End Sub
    Partial Private Sub OnBreifChanged()
    End Sub
    Partial Private Sub OnAuthorChanging(value As String)
    End Sub
    Partial Private Sub OnAuthorChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._admin = CType(Nothing, EntityRef(Of admin))
		Me._page = CType(Nothing, EntityRef(Of page))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_post_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property post_id() As Integer
		Get
			Return Me._post_id
		End Get
		Set
			If ((Me._post_id = value)  _
						= false) Then
				Me.Onpost_idChanging(value)
				Me.SendPropertyChanging
				Me._post_id = value
				Me.SendPropertyChanged("post_id")
				Me.Onpost_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ad_id", DbType:="Int NOT NULL")>  _
	Public Property ad_id() As Integer
		Get
			Return Me._ad_id
		End Get
		Set
			If ((Me._ad_id = value)  _
						= false) Then
				If Me._admin.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.Onad_idChanging(value)
				Me.SendPropertyChanging
				Me._ad_id = value
				Me.SendPropertyChanged("ad_id")
				Me.Onad_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_disclaimer", DbType:="NVarChar(500)")>  _
	Public Property disclaimer() As String
		Get
			Return Me._disclaimer
		End Get
		Set
			If (String.Equals(Me._disclaimer, value) = false) Then
				Me.OndisclaimerChanging(value)
				Me.SendPropertyChanging
				Me._disclaimer = value
				Me.SendPropertyChanged("disclaimer")
				Me.OndisclaimerChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="NVarChar(500) NOT NULL", CanBeNull:=false)>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_link", DbType:="NVarChar(500)")>  _
	Public Property link() As String
		Get
			Return Me._link
		End Get
		Set
			If (String.Equals(Me._link, value) = false) Then
				Me.OnlinkChanging(value)
				Me.SendPropertyChanging
				Me._link = value
				Me.SendPropertyChanged("link")
				Me.OnlinkChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_file_name", DbType:="NVarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property file_name() As String
		Get
			Return Me._file_name
		End Get
		Set
			If (String.Equals(Me._file_name, value) = false) Then
				Me.Onfile_nameChanging(value)
				Me.SendPropertyChanging
				Me._file_name = value
				Me.SendPropertyChanged("file_name")
				Me.Onfile_nameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_page_id", DbType:="Int NOT NULL")>  _
	Public Property page_id() As Integer
		Get
			Return Me._page_id
		End Get
		Set
			If ((Me._page_id = value)  _
						= false) Then
				If Me._page.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.Onpage_idChanging(value)
				Me.SendPropertyChanging
				Me._page_id = value
				Me.SendPropertyChanged("page_id")
				Me.Onpage_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Breif", DbType:="NVarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Breif() As String
		Get
			Return Me._Breif
		End Get
		Set
			If (String.Equals(Me._Breif, value) = false) Then
				Me.OnBreifChanging(value)
				Me.SendPropertyChanging
				Me._Breif = value
				Me.SendPropertyChanged("Breif")
				Me.OnBreifChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Author", DbType:="NVarChar(500)")>  _
	Public Property Author() As String
		Get
			Return Me._Author
		End Get
		Set
			If (String.Equals(Me._Author, value) = false) Then
				Me.OnAuthorChanging(value)
				Me.SendPropertyChanging
				Me._Author = value
				Me.SendPropertyChanged("Author")
				Me.OnAuthorChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="admin_post", Storage:="_admin", ThisKey:="ad_id", OtherKey:="ad_id", IsForeignKey:=true)>  _
	Public Property admin() As admin
		Get
			Return Me._admin.Entity
		End Get
		Set
			Dim previousValue As admin = Me._admin.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._admin.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._admin.Entity = Nothing
					previousValue.posts.Remove(Me)
				End If
				Me._admin.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.posts.Add(Me)
					Me._ad_id = value.ad_id
				Else
					Me._ad_id = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("admin")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="page_post", Storage:="_page", ThisKey:="page_id", OtherKey:="page_id", IsForeignKey:=true)>  _
	Public Property page() As page
		Get
			Return Me._page.Entity
		End Get
		Set
			Dim previousValue As page = Me._page.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._page.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._page.Entity = Nothing
					previousValue.posts.Remove(Me)
				End If
				Me._page.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.posts.Add(Me)
					Me._page_id = value.page_id
				Else
					Me._page_id = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("page")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class