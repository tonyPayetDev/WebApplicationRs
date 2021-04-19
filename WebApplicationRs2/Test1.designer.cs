﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationRs2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bdrstony")]
	public partial class TestDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertCommentaires(Commentaires instance);
    partial void UpdateCommentaires(Commentaires instance);
    partial void DeleteCommentaires(Commentaires instance);
    partial void InsertUtilisateurs(Utilisateurs instance);
    partial void UpdateUtilisateurs(Utilisateurs instance);
    partial void DeleteUtilisateurs(Utilisateurs instance);
    partial void InsertVotes(Votes instance);
    partial void UpdateVotes(Votes instance);
    partial void DeleteVotes(Votes instance);
    #endregion
		
		public TestDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OutilsADV_RECConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Commentaires> Commentaires
		{
			get
			{
				return this.GetTable<Commentaires>();
			}
		}
		
		public System.Data.Linq.Table<Utilisateurs> Utilisateurs
		{
			get
			{
				return this.GetTable<Utilisateurs>();
			}
		}
		
		public System.Data.Linq.Table<Votes> Votes
		{
			get
			{
				return this.GetTable<Votes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Commentaires")]
	public partial class Commentaires : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Description;
		
		private System.DateTime _Date;
		
		private int _nbJaime;
		
		private int _createByUser;
		
		private EntitySet<Votes> _Votes;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnnbJaimeChanging(int value);
    partial void OnnbJaimeChanged();
    partial void OncreateByUserChanging(int value);
    partial void OncreateByUserChanged();
    #endregion
		
		public Commentaires()
		{
			this._Votes = new EntitySet<Votes>(new Action<Votes>(this.attach_Votes), new Action<Votes>(this.detach_Votes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbJaime", DbType="Int NOT NULL")]
		public int nbJaime
		{
			get
			{
				return this._nbJaime;
			}
			set
			{
				if ((this._nbJaime != value))
				{
					this.OnnbJaimeChanging(value);
					this.SendPropertyChanging();
					this._nbJaime = value;
					this.SendPropertyChanged("nbJaime");
					this.OnnbJaimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createByUser", DbType="Int NOT NULL")]
		public int createByUser
		{
			get
			{
				return this._createByUser;
			}
			set
			{
				if ((this._createByUser != value))
				{
					this.OncreateByUserChanging(value);
					this.SendPropertyChanging();
					this._createByUser = value;
					this.SendPropertyChanged("createByUser");
					this.OncreateByUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Commentaires_Votes", Storage="_Votes", ThisKey="Id", OtherKey="Commentaire_Id")]
		public EntitySet<Votes> Votes
		{
			get
			{
				return this._Votes;
			}
			set
			{
				this._Votes.Assign(value);
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
		
		private void attach_Votes(Votes entity)
		{
			this.SendPropertyChanging();
			entity.Commentaires = this;
		}
		
		private void detach_Votes(Votes entity)
		{
			this.SendPropertyChanging();
			entity.Commentaires = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Utilisateurs")]
	public partial class Utilisateurs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Prenom;
		
		private string _MotDePasse;
		
		private EntitySet<Votes> _Votes;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnMotDePasseChanging(string value);
    partial void OnMotDePasseChanged();
    #endregion
		
		public Utilisateurs()
		{
			this._Votes = new EntitySet<Votes>(new Action<Votes>(this.attach_Votes), new Action<Votes>(this.detach_Votes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(MAX)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotDePasse", DbType="NVarChar(MAX)")]
		public string MotDePasse
		{
			get
			{
				return this._MotDePasse;
			}
			set
			{
				if ((this._MotDePasse != value))
				{
					this.OnMotDePasseChanging(value);
					this.SendPropertyChanging();
					this._MotDePasse = value;
					this.SendPropertyChanged("MotDePasse");
					this.OnMotDePasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Utilisateurs_Votes", Storage="_Votes", ThisKey="Id", OtherKey="Utilisateur_Id")]
		public EntitySet<Votes> Votes
		{
			get
			{
				return this._Votes;
			}
			set
			{
				this._Votes.Assign(value);
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
		
		private void attach_Votes(Votes entity)
		{
			this.SendPropertyChanging();
			entity.Utilisateurs = this;
		}
		
		private void detach_Votes(Votes entity)
		{
			this.SendPropertyChanging();
			entity.Utilisateurs = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Votes")]
	public partial class Votes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Commentaire_Id;
		
		private System.Nullable<int> _Utilisateur_Id;
		
		private EntityRef<Commentaires> _Commentaires;
		
		private EntityRef<Utilisateurs> _Utilisateurs;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCommentaire_IdChanging(System.Nullable<int> value);
    partial void OnCommentaire_IdChanged();
    partial void OnUtilisateur_IdChanging(System.Nullable<int> value);
    partial void OnUtilisateur_IdChanged();
    #endregion
		
		public Votes()
		{
			this._Commentaires = default(EntityRef<Commentaires>);
			this._Utilisateurs = default(EntityRef<Utilisateurs>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Commentaire_Id", DbType="Int")]
		public System.Nullable<int> Commentaire_Id
		{
			get
			{
				return this._Commentaire_Id;
			}
			set
			{
				if ((this._Commentaire_Id != value))
				{
					if (this._Commentaires.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCommentaire_IdChanging(value);
					this.SendPropertyChanging();
					this._Commentaire_Id = value;
					this.SendPropertyChanged("Commentaire_Id");
					this.OnCommentaire_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Utilisateur_Id", DbType="Int")]
		public System.Nullable<int> Utilisateur_Id
		{
			get
			{
				return this._Utilisateur_Id;
			}
			set
			{
				if ((this._Utilisateur_Id != value))
				{
					if (this._Utilisateurs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUtilisateur_IdChanging(value);
					this.SendPropertyChanging();
					this._Utilisateur_Id = value;
					this.SendPropertyChanged("Utilisateur_Id");
					this.OnUtilisateur_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Commentaires_Votes", Storage="_Commentaires", ThisKey="Commentaire_Id", OtherKey="Id", IsForeignKey=true)]
		public Commentaires Commentaires
		{
			get
			{
				return this._Commentaires.Entity;
			}
			set
			{
				Commentaires previousValue = this._Commentaires.Entity;
				if (((previousValue != value) 
							|| (this._Commentaires.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Commentaires.Entity = null;
						previousValue.Votes.Remove(this);
					}
					this._Commentaires.Entity = value;
					if ((value != null))
					{
						value.Votes.Add(this);
						this._Commentaire_Id = value.Id;
					}
					else
					{
						this._Commentaire_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Commentaires");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Utilisateurs_Votes", Storage="_Utilisateurs", ThisKey="Utilisateur_Id", OtherKey="Id", IsForeignKey=true)]
		public Utilisateurs Utilisateurs
		{
			get
			{
				return this._Utilisateurs.Entity;
			}
			set
			{
				Utilisateurs previousValue = this._Utilisateurs.Entity;
				if (((previousValue != value) 
							|| (this._Utilisateurs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Utilisateurs.Entity = null;
						previousValue.Votes.Remove(this);
					}
					this._Utilisateurs.Entity = value;
					if ((value != null))
					{
						value.Votes.Add(this);
						this._Utilisateur_Id = value.Id;
					}
					else
					{
						this._Utilisateur_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Utilisateurs");
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
