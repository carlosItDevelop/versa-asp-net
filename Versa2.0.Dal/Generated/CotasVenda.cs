
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 22/03/2019 17:06:34
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace Versa2._0.Dal
{
	/// <summary>
	/// Encapsulates the 'CotasVenda' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(CotasVenda))]	
	[XmlType("CotasVenda")]
	public partial class CotasVenda : esCotasVenda
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CotasVenda();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Guid id)
		{
			var obj = new CotasVenda();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Guid id, esSqlAccessType sqlAccessType)
		{
			var obj = new CotasVenda();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("CotasVendaCollection")]
	public partial class CotasVendaCollection : esCotasVendaCollection, IEnumerable<CotasVenda>
	{
		public CotasVenda FindByPrimaryKey(System.Guid id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(CotasVenda))]
		public class CotasVendaCollectionWCFPacket : esCollectionWCFPacket<CotasVendaCollection>
		{
			public static implicit operator CotasVendaCollection(CotasVendaCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CotasVendaCollectionWCFPacket(CotasVendaCollection collection)
			{
				return new CotasVendaCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class CotasVendaQuery : esCotasVendaQuery
	{
		public CotasVendaQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CotasVendaQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CotasVendaQuery query)
		{
			return CotasVendaQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CotasVendaQuery(string query)
		{
			return (CotasVendaQuery)CotasVendaQuery.SerializeHelper.FromXml(query, typeof(CotasVendaQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCotasVenda : esEntity
	{
		public esCotasVenda()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Guid id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Guid id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Guid id)
		{
			CotasVendaQuery query = new CotasVendaQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Guid id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to CotasVenda.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Guid? Id
		{
			get
			{
				return base.GetSystemGuid(CotasVendaMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemGuid(CotasVendaMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Credito
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Credito
		{
			get
			{
				return base.GetSystemDecimal(CotasVendaMetadata.ColumnNames.Credito);
			}
			
			set
			{
				if(base.SetSystemDecimal(CotasVendaMetadata.ColumnNames.Credito, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Credito);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Parcela
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Parcela
		{
			get
			{
				return base.GetSystemDecimal(CotasVendaMetadata.ColumnNames.Parcela);
			}
			
			set
			{
				if(base.SetSystemDecimal(CotasVendaMetadata.ColumnNames.Parcela, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Parcela);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.NumParcela
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? NumParcela
		{
			get
			{
				return base.GetSystemInt32(CotasVendaMetadata.ColumnNames.NumParcela);
			}
			
			set
			{
				if(base.SetSystemInt32(CotasVendaMetadata.ColumnNames.NumParcela, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.NumParcela);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Valor
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Valor
		{
			get
			{
				return base.GetSystemDecimal(CotasVendaMetadata.ColumnNames.Valor);
			}
			
			set
			{
				if(base.SetSystemDecimal(CotasVendaMetadata.ColumnNames.Valor, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Valor);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Status
		{
			get
			{
				return base.GetSystemBoolean(CotasVendaMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemBoolean(CotasVendaMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Status);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Vencimento
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Vencimento
		{
			get
			{
				return base.GetSystemDateTime(CotasVendaMetadata.ColumnNames.Vencimento);
			}
			
			set
			{
				if(base.SetSystemDateTime(CotasVendaMetadata.ColumnNames.Vencimento, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Vencimento);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.TipoCota
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TipoCota
		{
			get
			{
				return base.GetSystemInt32(CotasVendaMetadata.ColumnNames.TipoCota);
			}
			
			set
			{
				if(base.SetSystemInt32(CotasVendaMetadata.ColumnNames.TipoCota, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.TipoCota);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.AdministradoraId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AdministradoraId
		{
			get
			{
				return base.GetSystemInt32(CotasVendaMetadata.ColumnNames.AdministradoraId);
			}
			
			set
			{
				if(base.SetSystemInt32(CotasVendaMetadata.ColumnNames.AdministradoraId, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.AdministradoraId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Grupo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Grupo
		{
			get
			{
				return base.GetSystemString(CotasVendaMetadata.ColumnNames.Grupo);
			}
			
			set
			{
				if(base.SetSystemString(CotasVendaMetadata.ColumnNames.Grupo, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Grupo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.Cota
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cota
		{
			get
			{
				return base.GetSystemString(CotasVendaMetadata.ColumnNames.Cota);
			}
			
			set
			{
				if(base.SetSystemString(CotasVendaMetadata.ColumnNames.Cota, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Cota);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.NomeAdministradora
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NomeAdministradora
		{
			get
			{
				return base.GetSystemString(CotasVendaMetadata.ColumnNames.NomeAdministradora);
			}
			
			set
			{
				if(base.SetSystemString(CotasVendaMetadata.ColumnNames.NomeAdministradora, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.NomeAdministradora);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.DemaisParcelas
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? DemaisParcelas
		{
			get
			{
				return base.GetSystemDecimal(CotasVendaMetadata.ColumnNames.DemaisParcelas);
			}
			
			set
			{
				if(base.SetSystemDecimal(CotasVendaMetadata.ColumnNames.DemaisParcelas, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.DemaisParcelas);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CotasVenda.INCC
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Incc
		{
			get
			{
				return base.GetSystemString(CotasVendaMetadata.ColumnNames.Incc);
			}
			
			set
			{
				if(base.SetSystemString(CotasVendaMetadata.ColumnNames.Incc, value))
				{
					OnPropertyChanged(CotasVendaMetadata.PropertyNames.Incc);
				}
			}
		}		
		
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str().Id = (string)value; break;							
						case "Credito": this.str().Credito = (string)value; break;							
						case "Parcela": this.str().Parcela = (string)value; break;							
						case "NumParcela": this.str().NumParcela = (string)value; break;							
						case "Valor": this.str().Valor = (string)value; break;							
						case "Status": this.str().Status = (string)value; break;							
						case "Vencimento": this.str().Vencimento = (string)value; break;							
						case "TipoCota": this.str().TipoCota = (string)value; break;							
						case "AdministradoraId": this.str().AdministradoraId = (string)value; break;							
						case "Grupo": this.str().Grupo = (string)value; break;							
						case "Cota": this.str().Cota = (string)value; break;							
						case "NomeAdministradora": this.str().NomeAdministradora = (string)value; break;							
						case "DemaisParcelas": this.str().DemaisParcelas = (string)value; break;							
						case "Incc": this.str().Incc = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Guid)
								this.Id = (System.Guid?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Id);
							break;
						
						case "Credito":
						
							if (value == null || value is System.Decimal)
								this.Credito = (System.Decimal?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Credito);
							break;
						
						case "Parcela":
						
							if (value == null || value is System.Decimal)
								this.Parcela = (System.Decimal?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Parcela);
							break;
						
						case "NumParcela":
						
							if (value == null || value is System.Int32)
								this.NumParcela = (System.Int32?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.NumParcela);
							break;
						
						case "Valor":
						
							if (value == null || value is System.Decimal)
								this.Valor = (System.Decimal?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Valor);
							break;
						
						case "Status":
						
							if (value == null || value is System.Boolean)
								this.Status = (System.Boolean?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Status);
							break;
						
						case "Vencimento":
						
							if (value == null || value is System.DateTime)
								this.Vencimento = (System.DateTime?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.Vencimento);
							break;
						
						case "TipoCota":
						
							if (value == null || value is System.Int32)
								this.TipoCota = (System.Int32?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.TipoCota);
							break;
						
						case "AdministradoraId":
						
							if (value == null || value is System.Int32)
								this.AdministradoraId = (System.Int32?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.AdministradoraId);
							break;
						
						case "DemaisParcelas":
						
							if (value == null || value is System.Decimal)
								this.DemaisParcelas = (System.Decimal?)value;
								OnPropertyChanged(CotasVendaMetadata.PropertyNames.DemaisParcelas);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esCotasVenda entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Guid? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = new Guid(value);
				}
			}
				
			public System.String Credito
			{
				get
				{
					System.Decimal? data = entity.Credito;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Credito = null;
					else entity.Credito = Convert.ToDecimal(value);
				}
			}
				
			public System.String Parcela
			{
				get
				{
					System.Decimal? data = entity.Parcela;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Parcela = null;
					else entity.Parcela = Convert.ToDecimal(value);
				}
			}
				
			public System.String NumParcela
			{
				get
				{
					System.Int32? data = entity.NumParcela;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NumParcela = null;
					else entity.NumParcela = Convert.ToInt32(value);
				}
			}
				
			public System.String Valor
			{
				get
				{
					System.Decimal? data = entity.Valor;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Valor = null;
					else entity.Valor = Convert.ToDecimal(value);
				}
			}
				
			public System.String Status
			{
				get
				{
					System.Boolean? data = entity.Status;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Status = null;
					else entity.Status = Convert.ToBoolean(value);
				}
			}
				
			public System.String Vencimento
			{
				get
				{
					System.DateTime? data = entity.Vencimento;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vencimento = null;
					else entity.Vencimento = Convert.ToDateTime(value);
				}
			}
				
			public System.String TipoCota
			{
				get
				{
					System.Int32? data = entity.TipoCota;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TipoCota = null;
					else entity.TipoCota = Convert.ToInt32(value);
				}
			}
				
			public System.String AdministradoraId
			{
				get
				{
					System.Int32? data = entity.AdministradoraId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdministradoraId = null;
					else entity.AdministradoraId = Convert.ToInt32(value);
				}
			}
				
			public System.String Grupo
			{
				get
				{
					System.String data = entity.Grupo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Grupo = null;
					else entity.Grupo = Convert.ToString(value);
				}
			}
				
			public System.String Cota
			{
				get
				{
					System.String data = entity.Cota;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Cota = null;
					else entity.Cota = Convert.ToString(value);
				}
			}
				
			public System.String NomeAdministradora
			{
				get
				{
					System.String data = entity.NomeAdministradora;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NomeAdministradora = null;
					else entity.NomeAdministradora = Convert.ToString(value);
				}
			}
				
			public System.String DemaisParcelas
			{
				get
				{
					System.Decimal? data = entity.DemaisParcelas;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DemaisParcelas = null;
					else entity.DemaisParcelas = Convert.ToDecimal(value);
				}
			}
				
			public System.String Incc
			{
				get
				{
					System.String data = entity.Incc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Incc = null;
					else entity.Incc = Convert.ToString(value);
				}
			}
			

			private esCotasVenda entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CotasVendaMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CotasVendaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CotasVendaQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CotasVendaQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CotasVendaQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CotasVendaQuery query;		
	}



	[Serializable]
	abstract public partial class esCotasVendaCollection : esEntityCollection<CotasVenda>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CotasVendaMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CotasVendaCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CotasVendaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CotasVendaQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CotasVendaQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CotasVendaQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CotasVendaQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CotasVendaQuery)query);
		}

		#endregion
		
		private CotasVendaQuery query;
	}



	[Serializable]
	abstract public partial class esCotasVendaQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CotasVendaMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Credito": return this.Credito;
				case "Parcela": return this.Parcela;
				case "NumParcela": return this.NumParcela;
				case "Valor": return this.Valor;
				case "Status": return this.Status;
				case "Vencimento": return this.Vencimento;
				case "TipoCota": return this.TipoCota;
				case "AdministradoraId": return this.AdministradoraId;
				case "Grupo": return this.Grupo;
				case "Cota": return this.Cota;
				case "NomeAdministradora": return this.NomeAdministradora;
				case "DemaisParcelas": return this.DemaisParcelas;
				case "Incc": return this.Incc;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Id, esSystemType.Guid); }
		} 
		
		public esQueryItem Credito
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Credito, esSystemType.Decimal); }
		} 
		
		public esQueryItem Parcela
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Parcela, esSystemType.Decimal); }
		} 
		
		public esQueryItem NumParcela
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.NumParcela, esSystemType.Int32); }
		} 
		
		public esQueryItem Valor
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Valor, esSystemType.Decimal); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Status, esSystemType.Boolean); }
		} 
		
		public esQueryItem Vencimento
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Vencimento, esSystemType.DateTime); }
		} 
		
		public esQueryItem TipoCota
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.TipoCota, esSystemType.Int32); }
		} 
		
		public esQueryItem AdministradoraId
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.AdministradoraId, esSystemType.Int32); }
		} 
		
		public esQueryItem Grupo
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Grupo, esSystemType.String); }
		} 
		
		public esQueryItem Cota
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Cota, esSystemType.String); }
		} 
		
		public esQueryItem NomeAdministradora
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.NomeAdministradora, esSystemType.String); }
		} 
		
		public esQueryItem DemaisParcelas
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.DemaisParcelas, esSystemType.Decimal); }
		} 
		
		public esQueryItem Incc
		{
			get { return new esQueryItem(this, CotasVendaMetadata.ColumnNames.Incc, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CotasVenda : esCotasVenda
	{

		
		
	}
	



	[Serializable]
	public partial class CotasVendaMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CotasVendaMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Id, 0, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Credito, 1, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Credito;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Parcela, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Parcela;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.NumParcela, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CotasVendaMetadata.PropertyNames.NumParcela;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Valor, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Valor;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Status, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Status;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Vencimento, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Vencimento;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.TipoCota, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CotasVendaMetadata.PropertyNames.TipoCota;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.AdministradoraId, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CotasVendaMetadata.PropertyNames.AdministradoraId;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Grupo, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Grupo;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Cota, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Cota;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.NomeAdministradora, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = CotasVendaMetadata.PropertyNames.NomeAdministradora;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.DemaisParcelas, 12, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = CotasVendaMetadata.PropertyNames.DemaisParcelas;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CotasVendaMetadata.ColumnNames.Incc, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = CotasVendaMetadata.PropertyNames.Incc;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CotasVendaMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "Id";
			 public const string Credito = "Credito";
			 public const string Parcela = "Parcela";
			 public const string NumParcela = "NumParcela";
			 public const string Valor = "Valor";
			 public const string Status = "Status";
			 public const string Vencimento = "Vencimento";
			 public const string TipoCota = "TipoCota";
			 public const string AdministradoraId = "AdministradoraId";
			 public const string Grupo = "Grupo";
			 public const string Cota = "Cota";
			 public const string NomeAdministradora = "NomeAdministradora";
			 public const string DemaisParcelas = "DemaisParcelas";
			 public const string Incc = "INCC";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Credito = "Credito";
			 public const string Parcela = "Parcela";
			 public const string NumParcela = "NumParcela";
			 public const string Valor = "Valor";
			 public const string Status = "Status";
			 public const string Vencimento = "Vencimento";
			 public const string TipoCota = "TipoCota";
			 public const string AdministradoraId = "AdministradoraId";
			 public const string Grupo = "Grupo";
			 public const string Cota = "Cota";
			 public const string NomeAdministradora = "NomeAdministradora";
			 public const string DemaisParcelas = "DemaisParcelas";
			 public const string Incc = "Incc";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(CotasVendaMetadata))
			{
				if(CotasVendaMetadata.mapDelegates == null)
				{
					CotasVendaMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CotasVendaMetadata.meta == null)
				{
					CotasVendaMetadata.meta = new CotasVendaMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Id", new esTypeMap("uniqueidentifier", "System.Guid"));
				meta.AddTypeMap("Credito", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Parcela", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("NumParcela", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Valor", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Status", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Vencimento", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("TipoCota", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdministradoraId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Grupo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Cota", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("NomeAdministradora", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("DemaisParcelas", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Incc", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "CotasVenda";
				meta.Destination = "CotasVenda";
				
				meta.spInsert = "proc_CotasVendaInsert";				
				meta.spUpdate = "proc_CotasVendaUpdate";		
				meta.spDelete = "proc_CotasVendaDelete";
				meta.spLoadAll = "proc_CotasVendaLoadAll";
				meta.spLoadByPrimaryKey = "proc_CotasVendaLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CotasVendaMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
