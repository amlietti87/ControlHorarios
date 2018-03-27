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

namespace DataBase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="controlhorariodb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertobrasocial(obrasocial instance);
    partial void Updateobrasocial(obrasocial instance);
    partial void Deleteobrasocial(obrasocial instance);
    partial void Inserttipodehora(tipodehora instance);
    partial void Updatetipodehora(tipodehora instance);
    partial void Deletetipodehora(tipodehora instance);
    partial void Insertprofesion(profesion instance);
    partial void Updateprofesion(profesion instance);
    partial void Deleteprofesion(profesion instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DataBase.Properties.Settings.Default.controlhorariodbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<obrasocial> obrasocials
		{
			get
			{
				return this.GetTable<obrasocial>();
			}
		}
		
		public System.Data.Linq.Table<tipodehora> tipodehoras
		{
			get
			{
				return this.GetTable<tipodehora>();
			}
		}
		
		public System.Data.Linq.Table<profesion> profesions
		{
			get
			{
				return this.GetTable<profesion>();
			}
		}
		
		public System.Data.Linq.Table<terapeuta> terapeutas
		{
			get
			{
				return this.GetTable<terapeuta>();
			}
		}
		
		public System.Data.Linq.Table<paciente> pacientes
		{
			get
			{
				return this.GetTable<paciente>();
			}
		}
		
		private void Insertterapeuta(terapeuta obj)
		{
			this.AgregarTerapeuta(obj.terapeuta_nom, obj.terapeuta_ape, obj.terapeuta_mail, obj.terapeuta_tel, obj.terapeuta_dom, obj.terapeuta_matricula, obj.terapeuta_doc, ((System.Nullable<int>)(obj.terapeuta_idprofesion)));
		}
		
		private void Updateterapeuta(terapeuta obj)
		{
			this.ModificarTerapeuta(((System.Nullable<int>)(obj.Id_terapeuta)), obj.terapeuta_nom, obj.terapeuta_ape, obj.terapeuta_mail, obj.terapeuta_tel, obj.terapeuta_dom, obj.terapeuta_matricula, obj.terapeuta_doc, ((System.Nullable<int>)(obj.terapeuta_idprofesion)));
		}
		
		private void Deleteterapeuta(terapeuta obj)
		{
			this.EliminarTerapeuta(((System.Nullable<int>)(obj.Id_terapeuta)));
		}
		
		private void Insertpaciente(paciente obj)
		{
			this.AgregarPaciente(obj.paciente_nom, obj.paciente_ape, obj.paciente_tel, obj.paciente_dom, ((System.Nullable<System.DateTime>)(obj.paciente_fecnac)), obj.paciente_doc, ((System.Nullable<int>)(obj.paciente_idobrasocial)));
		}
		
		private void Updatepaciente(paciente obj)
		{
			this.ModificarPaciente(((System.Nullable<int>)(obj.Id_paciente)), obj.paciente_nom, obj.paciente_ape, obj.paciente_tel, obj.paciente_dom, ((System.Nullable<System.DateTime>)(obj.paciente_fecnac)), obj.paciente_doc, ((System.Nullable<int>)(obj.paciente_idobrasocial)));
		}
		
		private void Deletepaciente(paciente obj)
		{
			this.EliminarPaciente(((System.Nullable<int>)(obj.Id_paciente)));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarPacientes")]
		public ISingleResult<ListarPacientesResult> ListarPacientes()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarPacientesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarTerapeuta")]
		public int AgregarTerapeuta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="Char(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido", DbType="Char(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mail", DbType="NChar(50)")] string mail, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="NChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="NChar(50)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Matricula", DbType="NChar(30)")] string matricula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Documento", DbType="NChar(50)")] string documento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Profesion", DbType="Int")] System.Nullable<int> profesion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellido, mail, telefono, domicilio, matricula, documento, profesion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarTerapeuta")]
		public int EliminarTerapeuta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModificarTerapeuta")]
		public int ModificarTerapeuta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="Char(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido", DbType="Char(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mail", DbType="NChar(50)")] string mail, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="NChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="NChar(50)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Matricula", DbType="NChar(30)")] string matricula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Documento", DbType="NChar(50)")] string documento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Profesion", DbType="Int")] System.Nullable<int> profesion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, nombre, apellido, mail, telefono, domicilio, matricula, documento, profesion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarTerapeutas")]
		public ISingleResult<ListarTerapeutasResult> ListarTerapeutas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarTerapeutasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarPaciente")]
		public int AgregarPaciente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="Char(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido", DbType="Char(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="Char(30)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="Char(30)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FecNac", DbType="Date")] System.Nullable<System.DateTime> fecNac, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Documento", DbType="NChar(30)")] string documento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ObraSocial", DbType="Int")] System.Nullable<int> obraSocial)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellido, telefono, domicilio, fecNac, documento, obraSocial);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarPaciente")]
		public int EliminarPaciente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModificarPaciente")]
		public int ModificarPaciente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="Char(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido", DbType="Char(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="Char(30)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="Char(30)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FecNac", DbType="Date")] System.Nullable<System.DateTime> fecNac, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Documento", DbType="NChar(30)")] string documento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ObraSocial", DbType="Int")] System.Nullable<int> obraSocial)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, nombre, apellido, telefono, domicilio, fecNac, documento, obraSocial);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.obrasocial")]
	public partial class obrasocial : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_ObraSocial;
		
		private string _obrasocial_nom;
		
		private EntitySet<paciente> _pacientes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ObraSocialChanging(int value);
    partial void OnId_ObraSocialChanged();
    partial void Onobrasocial_nomChanging(string value);
    partial void Onobrasocial_nomChanged();
    #endregion
		
		public obrasocial()
		{
			this._pacientes = new EntitySet<paciente>(new Action<paciente>(this.attach_pacientes), new Action<paciente>(this.detach_pacientes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_ObraSocial", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_ObraSocial
		{
			get
			{
				return this._Id_ObraSocial;
			}
			set
			{
				if ((this._Id_ObraSocial != value))
				{
					this.OnId_ObraSocialChanging(value);
					this.SendPropertyChanging();
					this._Id_ObraSocial = value;
					this.SendPropertyChanged("Id_ObraSocial");
					this.OnId_ObraSocialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_obrasocial_nom", DbType="Char(30)")]
		public string obrasocial_nom
		{
			get
			{
				return this._obrasocial_nom;
			}
			set
			{
				if ((this._obrasocial_nom != value))
				{
					this.Onobrasocial_nomChanging(value);
					this.SendPropertyChanging();
					this._obrasocial_nom = value;
					this.SendPropertyChanged("obrasocial_nom");
					this.Onobrasocial_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="obrasocial_paciente", Storage="_pacientes", ThisKey="Id_ObraSocial", OtherKey="paciente_idobrasocial")]
		public EntitySet<paciente> pacientes
		{
			get
			{
				return this._pacientes;
			}
			set
			{
				this._pacientes.Assign(value);
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
		
		private void attach_pacientes(paciente entity)
		{
			this.SendPropertyChanging();
			entity.obrasocial = this;
		}
		
		private void detach_pacientes(paciente entity)
		{
			this.SendPropertyChanging();
			entity.obrasocial = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tipodehora")]
	public partial class tipodehora : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_TipodeHora;
		
		private string _tipodehora_nom;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_TipodeHoraChanging(int value);
    partial void OnId_TipodeHoraChanged();
    partial void Ontipodehora_nomChanging(string value);
    partial void Ontipodehora_nomChanged();
    #endregion
		
		public tipodehora()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_TipodeHora", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_TipodeHora
		{
			get
			{
				return this._Id_TipodeHora;
			}
			set
			{
				if ((this._Id_TipodeHora != value))
				{
					this.OnId_TipodeHoraChanging(value);
					this.SendPropertyChanging();
					this._Id_TipodeHora = value;
					this.SendPropertyChanged("Id_TipodeHora");
					this.OnId_TipodeHoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipodehora_nom", DbType="Char(30)")]
		public string tipodehora_nom
		{
			get
			{
				return this._tipodehora_nom;
			}
			set
			{
				if ((this._tipodehora_nom != value))
				{
					this.Ontipodehora_nomChanging(value);
					this.SendPropertyChanging();
					this._tipodehora_nom = value;
					this.SendPropertyChanged("tipodehora_nom");
					this.Ontipodehora_nomChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.profesion")]
	public partial class profesion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Profesion;
		
		private string _profesion_nom;
		
		private EntitySet<terapeuta> _terapeutas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ProfesionChanging(int value);
    partial void OnId_ProfesionChanged();
    partial void Onprofesion_nomChanging(string value);
    partial void Onprofesion_nomChanged();
    #endregion
		
		public profesion()
		{
			this._terapeutas = new EntitySet<terapeuta>(new Action<terapeuta>(this.attach_terapeutas), new Action<terapeuta>(this.detach_terapeutas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Profesion", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Profesion
		{
			get
			{
				return this._Id_Profesion;
			}
			set
			{
				if ((this._Id_Profesion != value))
				{
					this.OnId_ProfesionChanging(value);
					this.SendPropertyChanging();
					this._Id_Profesion = value;
					this.SendPropertyChanged("Id_Profesion");
					this.OnId_ProfesionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profesion_nom", DbType="Char(30)")]
		public string profesion_nom
		{
			get
			{
				return this._profesion_nom;
			}
			set
			{
				if ((this._profesion_nom != value))
				{
					this.Onprofesion_nomChanging(value);
					this.SendPropertyChanging();
					this._profesion_nom = value;
					this.SendPropertyChanged("profesion_nom");
					this.Onprofesion_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profesion_terapeuta", Storage="_terapeutas", ThisKey="Id_Profesion", OtherKey="terapeuta_idprofesion")]
		public EntitySet<terapeuta> terapeutas
		{
			get
			{
				return this._terapeutas;
			}
			set
			{
				this._terapeutas.Assign(value);
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
		
		private void attach_terapeutas(terapeuta entity)
		{
			this.SendPropertyChanging();
			entity.profesion = this;
		}
		
		private void detach_terapeutas(terapeuta entity)
		{
			this.SendPropertyChanging();
			entity.profesion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.terapeuta")]
	public partial class terapeuta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_terapeuta;
		
		private string _terapeuta_nom;
		
		private string _terapeuta_ape;
		
		private string _terapeuta_mail;
		
		private string _terapeuta_dom;
		
		private string _terapeuta_tel;
		
		private string _terapeuta_doc;
		
		private int _terapeuta_idprofesion;
		
		private string _terapeuta_matricula;
		
		private EntityRef<profesion> _profesion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_terapeutaChanging(int value);
    partial void OnId_terapeutaChanged();
    partial void Onterapeuta_nomChanging(string value);
    partial void Onterapeuta_nomChanged();
    partial void Onterapeuta_apeChanging(string value);
    partial void Onterapeuta_apeChanged();
    partial void Onterapeuta_mailChanging(string value);
    partial void Onterapeuta_mailChanged();
    partial void Onterapeuta_domChanging(string value);
    partial void Onterapeuta_domChanged();
    partial void Onterapeuta_telChanging(string value);
    partial void Onterapeuta_telChanged();
    partial void Onterapeuta_docChanging(string value);
    partial void Onterapeuta_docChanged();
    partial void Onterapeuta_idprofesionChanging(int value);
    partial void Onterapeuta_idprofesionChanged();
    partial void Onterapeuta_matriculaChanging(string value);
    partial void Onterapeuta_matriculaChanged();
    #endregion
		
		public terapeuta()
		{
			this._profesion = default(EntityRef<profesion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_terapeuta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_terapeuta
		{
			get
			{
				return this._Id_terapeuta;
			}
			set
			{
				if ((this._Id_terapeuta != value))
				{
					this.OnId_terapeutaChanging(value);
					this.SendPropertyChanging();
					this._Id_terapeuta = value;
					this.SendPropertyChanged("Id_terapeuta");
					this.OnId_terapeutaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_nom", DbType="Char(30)")]
		public string terapeuta_nom
		{
			get
			{
				return this._terapeuta_nom;
			}
			set
			{
				if ((this._terapeuta_nom != value))
				{
					this.Onterapeuta_nomChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_nom = value;
					this.SendPropertyChanged("terapeuta_nom");
					this.Onterapeuta_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_ape", DbType="Char(30)")]
		public string terapeuta_ape
		{
			get
			{
				return this._terapeuta_ape;
			}
			set
			{
				if ((this._terapeuta_ape != value))
				{
					this.Onterapeuta_apeChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_ape = value;
					this.SendPropertyChanged("terapeuta_ape");
					this.Onterapeuta_apeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_mail", DbType="NChar(50)")]
		public string terapeuta_mail
		{
			get
			{
				return this._terapeuta_mail;
			}
			set
			{
				if ((this._terapeuta_mail != value))
				{
					this.Onterapeuta_mailChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_mail = value;
					this.SendPropertyChanged("terapeuta_mail");
					this.Onterapeuta_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_dom", DbType="NChar(50)")]
		public string terapeuta_dom
		{
			get
			{
				return this._terapeuta_dom;
			}
			set
			{
				if ((this._terapeuta_dom != value))
				{
					this.Onterapeuta_domChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_dom = value;
					this.SendPropertyChanged("terapeuta_dom");
					this.Onterapeuta_domChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_tel", DbType="NChar(50)")]
		public string terapeuta_tel
		{
			get
			{
				return this._terapeuta_tel;
			}
			set
			{
				if ((this._terapeuta_tel != value))
				{
					this.Onterapeuta_telChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_tel = value;
					this.SendPropertyChanged("terapeuta_tel");
					this.Onterapeuta_telChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_doc", DbType="NChar(50)")]
		public string terapeuta_doc
		{
			get
			{
				return this._terapeuta_doc;
			}
			set
			{
				if ((this._terapeuta_doc != value))
				{
					this.Onterapeuta_docChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_doc = value;
					this.SendPropertyChanged("terapeuta_doc");
					this.Onterapeuta_docChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_idprofesion", DbType="Int NOT NULL")]
		public int terapeuta_idprofesion
		{
			get
			{
				return this._terapeuta_idprofesion;
			}
			set
			{
				if ((this._terapeuta_idprofesion != value))
				{
					if (this._profesion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onterapeuta_idprofesionChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_idprofesion = value;
					this.SendPropertyChanged("terapeuta_idprofesion");
					this.Onterapeuta_idprofesionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_matricula", DbType="NChar(30)")]
		public string terapeuta_matricula
		{
			get
			{
				return this._terapeuta_matricula;
			}
			set
			{
				if ((this._terapeuta_matricula != value))
				{
					this.Onterapeuta_matriculaChanging(value);
					this.SendPropertyChanging();
					this._terapeuta_matricula = value;
					this.SendPropertyChanged("terapeuta_matricula");
					this.Onterapeuta_matriculaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="profesion_terapeuta", Storage="_profesion", ThisKey="terapeuta_idprofesion", OtherKey="Id_Profesion", IsForeignKey=true)]
		public profesion profesion
		{
			get
			{
				return this._profesion.Entity;
			}
			set
			{
				profesion previousValue = this._profesion.Entity;
				if (((previousValue != value) 
							|| (this._profesion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._profesion.Entity = null;
						previousValue.terapeutas.Remove(this);
					}
					this._profesion.Entity = value;
					if ((value != null))
					{
						value.terapeutas.Add(this);
						this._terapeuta_idprofesion = value.Id_Profesion;
					}
					else
					{
						this._terapeuta_idprofesion = default(int);
					}
					this.SendPropertyChanged("profesion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.paciente")]
	public partial class paciente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_paciente;
		
		private string _paciente_nom;
		
		private string _paciente_ape;
		
		private string _paciente_tel;
		
		private string _paciente_dom;
		
		private System.Nullable<int> _paciente_idobrasocial;
		
		private System.Nullable<System.DateTime> _paciente_fecnac;
		
		private string _paciente_doc;
		
		private EntityRef<obrasocial> _obrasocial;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_pacienteChanging(int value);
    partial void OnId_pacienteChanged();
    partial void Onpaciente_nomChanging(string value);
    partial void Onpaciente_nomChanged();
    partial void Onpaciente_apeChanging(string value);
    partial void Onpaciente_apeChanged();
    partial void Onpaciente_telChanging(string value);
    partial void Onpaciente_telChanged();
    partial void Onpaciente_domChanging(string value);
    partial void Onpaciente_domChanged();
    partial void Onpaciente_idobrasocialChanging(System.Nullable<int> value);
    partial void Onpaciente_idobrasocialChanged();
    partial void Onpaciente_fecnacChanging(System.Nullable<System.DateTime> value);
    partial void Onpaciente_fecnacChanged();
    partial void Onpaciente_docChanging(string value);
    partial void Onpaciente_docChanged();
    #endregion
		
		public paciente()
		{
			this._obrasocial = default(EntityRef<obrasocial>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_paciente", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_paciente
		{
			get
			{
				return this._Id_paciente;
			}
			set
			{
				if ((this._Id_paciente != value))
				{
					this.OnId_pacienteChanging(value);
					this.SendPropertyChanging();
					this._Id_paciente = value;
					this.SendPropertyChanged("Id_paciente");
					this.OnId_pacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_nom", DbType="Char(30)")]
		public string paciente_nom
		{
			get
			{
				return this._paciente_nom;
			}
			set
			{
				if ((this._paciente_nom != value))
				{
					this.Onpaciente_nomChanging(value);
					this.SendPropertyChanging();
					this._paciente_nom = value;
					this.SendPropertyChanged("paciente_nom");
					this.Onpaciente_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_ape", DbType="Char(30)")]
		public string paciente_ape
		{
			get
			{
				return this._paciente_ape;
			}
			set
			{
				if ((this._paciente_ape != value))
				{
					this.Onpaciente_apeChanging(value);
					this.SendPropertyChanging();
					this._paciente_ape = value;
					this.SendPropertyChanged("paciente_ape");
					this.Onpaciente_apeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_tel", DbType="Char(30)")]
		public string paciente_tel
		{
			get
			{
				return this._paciente_tel;
			}
			set
			{
				if ((this._paciente_tel != value))
				{
					this.Onpaciente_telChanging(value);
					this.SendPropertyChanging();
					this._paciente_tel = value;
					this.SendPropertyChanged("paciente_tel");
					this.Onpaciente_telChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_dom", DbType="Char(30)")]
		public string paciente_dom
		{
			get
			{
				return this._paciente_dom;
			}
			set
			{
				if ((this._paciente_dom != value))
				{
					this.Onpaciente_domChanging(value);
					this.SendPropertyChanging();
					this._paciente_dom = value;
					this.SendPropertyChanged("paciente_dom");
					this.Onpaciente_domChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_idobrasocial", DbType="Int")]
		public System.Nullable<int> paciente_idobrasocial
		{
			get
			{
				return this._paciente_idobrasocial;
			}
			set
			{
				if ((this._paciente_idobrasocial != value))
				{
					if (this._obrasocial.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onpaciente_idobrasocialChanging(value);
					this.SendPropertyChanging();
					this._paciente_idobrasocial = value;
					this.SendPropertyChanged("paciente_idobrasocial");
					this.Onpaciente_idobrasocialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_fecnac", DbType="Date")]
		public System.Nullable<System.DateTime> paciente_fecnac
		{
			get
			{
				return this._paciente_fecnac;
			}
			set
			{
				if ((this._paciente_fecnac != value))
				{
					this.Onpaciente_fecnacChanging(value);
					this.SendPropertyChanging();
					this._paciente_fecnac = value;
					this.SendPropertyChanged("paciente_fecnac");
					this.Onpaciente_fecnacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_doc", DbType="NChar(30)")]
		public string paciente_doc
		{
			get
			{
				return this._paciente_doc;
			}
			set
			{
				if ((this._paciente_doc != value))
				{
					this.Onpaciente_docChanging(value);
					this.SendPropertyChanging();
					this._paciente_doc = value;
					this.SendPropertyChanged("paciente_doc");
					this.Onpaciente_docChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="obrasocial_paciente", Storage="_obrasocial", ThisKey="paciente_idobrasocial", OtherKey="Id_ObraSocial", IsForeignKey=true)]
		public obrasocial obrasocial
		{
			get
			{
				return this._obrasocial.Entity;
			}
			set
			{
				obrasocial previousValue = this._obrasocial.Entity;
				if (((previousValue != value) 
							|| (this._obrasocial.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._obrasocial.Entity = null;
						previousValue.pacientes.Remove(this);
					}
					this._obrasocial.Entity = value;
					if ((value != null))
					{
						value.pacientes.Add(this);
						this._paciente_idobrasocial = value.Id_ObraSocial;
					}
					else
					{
						this._paciente_idobrasocial = default(Nullable<int>);
					}
					this.SendPropertyChanged("obrasocial");
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
	
	public partial class ListarPacientesResult
	{
		
		private int _Id_paciente;
		
		private string _paciente_nom;
		
		private string _paciente_ape;
		
		private string _paciente_doc;
		
		private System.Nullable<System.DateTime> _paciente_fecnac;
		
		private string _paciente_tel;
		
		private string _paciente_dom;
		
		private string _obrasocial_nom;
		
		public ListarPacientesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_paciente", DbType="Int NOT NULL")]
		public int Id_paciente
		{
			get
			{
				return this._Id_paciente;
			}
			set
			{
				if ((this._Id_paciente != value))
				{
					this._Id_paciente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_nom", DbType="Char(30)")]
		public string paciente_nom
		{
			get
			{
				return this._paciente_nom;
			}
			set
			{
				if ((this._paciente_nom != value))
				{
					this._paciente_nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_ape", DbType="Char(30)")]
		public string paciente_ape
		{
			get
			{
				return this._paciente_ape;
			}
			set
			{
				if ((this._paciente_ape != value))
				{
					this._paciente_ape = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_doc", DbType="NChar(30)")]
		public string paciente_doc
		{
			get
			{
				return this._paciente_doc;
			}
			set
			{
				if ((this._paciente_doc != value))
				{
					this._paciente_doc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_fecnac", DbType="Date")]
		public System.Nullable<System.DateTime> paciente_fecnac
		{
			get
			{
				return this._paciente_fecnac;
			}
			set
			{
				if ((this._paciente_fecnac != value))
				{
					this._paciente_fecnac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_tel", DbType="Char(30)")]
		public string paciente_tel
		{
			get
			{
				return this._paciente_tel;
			}
			set
			{
				if ((this._paciente_tel != value))
				{
					this._paciente_tel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paciente_dom", DbType="Char(30)")]
		public string paciente_dom
		{
			get
			{
				return this._paciente_dom;
			}
			set
			{
				if ((this._paciente_dom != value))
				{
					this._paciente_dom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_obrasocial_nom", DbType="Char(30)")]
		public string obrasocial_nom
		{
			get
			{
				return this._obrasocial_nom;
			}
			set
			{
				if ((this._obrasocial_nom != value))
				{
					this._obrasocial_nom = value;
				}
			}
		}
	}
	
	public partial class ListarTerapeutasResult
	{
		
		private int _Id_terapeuta;
		
		private string _terapeuta_nom;
		
		private string _terapeuta_ape;
		
		private string _terapeuta_doc;
		
		private string _terapeuta_tel;
		
		private string _terapeuta_matricula;
		
		private string _terapeuta_mail;
		
		private string _terapeuta_dom;
		
		private string _profesion_nom;
		
		public ListarTerapeutasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_terapeuta", DbType="Int NOT NULL")]
		public int Id_terapeuta
		{
			get
			{
				return this._Id_terapeuta;
			}
			set
			{
				if ((this._Id_terapeuta != value))
				{
					this._Id_terapeuta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_nom", DbType="Char(30)")]
		public string terapeuta_nom
		{
			get
			{
				return this._terapeuta_nom;
			}
			set
			{
				if ((this._terapeuta_nom != value))
				{
					this._terapeuta_nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_ape", DbType="Char(30)")]
		public string terapeuta_ape
		{
			get
			{
				return this._terapeuta_ape;
			}
			set
			{
				if ((this._terapeuta_ape != value))
				{
					this._terapeuta_ape = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_doc", DbType="NChar(50)")]
		public string terapeuta_doc
		{
			get
			{
				return this._terapeuta_doc;
			}
			set
			{
				if ((this._terapeuta_doc != value))
				{
					this._terapeuta_doc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_tel", DbType="NChar(50)")]
		public string terapeuta_tel
		{
			get
			{
				return this._terapeuta_tel;
			}
			set
			{
				if ((this._terapeuta_tel != value))
				{
					this._terapeuta_tel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_matricula", DbType="NChar(30)")]
		public string terapeuta_matricula
		{
			get
			{
				return this._terapeuta_matricula;
			}
			set
			{
				if ((this._terapeuta_matricula != value))
				{
					this._terapeuta_matricula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_mail", DbType="NChar(50)")]
		public string terapeuta_mail
		{
			get
			{
				return this._terapeuta_mail;
			}
			set
			{
				if ((this._terapeuta_mail != value))
				{
					this._terapeuta_mail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terapeuta_dom", DbType="NChar(50)")]
		public string terapeuta_dom
		{
			get
			{
				return this._terapeuta_dom;
			}
			set
			{
				if ((this._terapeuta_dom != value))
				{
					this._terapeuta_dom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profesion_nom", DbType="Char(30)")]
		public string profesion_nom
		{
			get
			{
				return this._profesion_nom;
			}
			set
			{
				if ((this._profesion_nom != value))
				{
					this._profesion_nom = value;
				}
			}
		}
	}
}
#pragma warning restore 1591