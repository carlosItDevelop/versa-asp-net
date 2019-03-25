
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 22/03/2019 17:06:36
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
	/// Encapsulates the 'eMails' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(EMails))]	
	[XmlType("EMails")]
	public partial class EMails : esEMails
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new EMails();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Guid id)
		{
			var obj = new EMails();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Guid id, esSqlAccessType sqlAccessType)
		{
			var obj = new EMails();
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
	[XmlType("EMailsCollection")]
	public partial class EMailsCollection : esEMailsCollection, IEnumerable<EMails>
	{
		public EMails FindByPrimaryKey(System.Guid id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(EMails))]
		public class EMailsCollectionWCFPacket : esCollectionWCFPacket<EMailsCollection>
		{
			public static implicit operator EMailsCollection(EMailsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator EMailsCollectionWCFPacket(EMailsCollection collection)
			{
				return new EMailsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class EMailsQuery : esEMailsQuery
	{
		public EMailsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "EMailsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EMailsQuery query)
		{
			return EMailsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EMailsQuery(string query)
		{
			return (EMailsQuery)EMailsQuery.SerializeHelper.FromXml(query, typeof(EMailsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEMails : esEntity
	{
		public esEMails()
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
			EMailsQuery query = new EMailsQuery();
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
		/// Maps to eMails.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Guid? Id
		{
			get
			{
				return base.GetSystemGuid(EMailsMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemGuid(EMailsMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.DataInclusao
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DataInclusao
		{
			get
			{
				return base.GetSystemDateTime(EMailsMetadata.ColumnNames.DataInclusao);
			}
			
			set
			{
				if(base.SetSystemDateTime(EMailsMetadata.ColumnNames.DataInclusao, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.DataInclusao);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Email);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Nome
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Nome
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Nome);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Nome, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Nome);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Telefone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Telefone
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Telefone);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Telefone, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Telefone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Celular
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Celular
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Celular);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Celular, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Celular);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Administradora
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Administradora
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Administradora);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Administradora, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Administradora);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.TipoConsorcio
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TipoConsorcio
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.TipoConsorcio);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.TipoConsorcio, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.TipoConsorcio);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Grupo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Grupo
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Grupo);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Grupo, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Grupo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Cota
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cota
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Cota);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Cota, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Cota);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Contemplado
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contemplado
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Contemplado);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Contemplado, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Contemplado);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.TotalParcelas
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? TotalParcelas
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.TotalParcelas);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.TotalParcelas, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.TotalParcelas);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Entrada
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Entrada
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.Entrada);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.Entrada, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Entrada);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.ParcelasPagas
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? ParcelasPagas
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.ParcelasPagas);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.ParcelasPagas, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.ParcelasPagas);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.ParcelasEmAtraso
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? ParcelasEmAtraso
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.ParcelasEmAtraso);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.ParcelasEmAtraso, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.ParcelasEmAtraso);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.ValorDoBem
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? ValorDoBem
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.ValorDoBem);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.ValorDoBem, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.ValorDoBem);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.ValorDaParcela
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? ValorDaParcela
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.ValorDaParcela);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.ValorDaParcela, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.ValorDaParcela);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.SaldoDevedor
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? SaldoDevedor
		{
			get
			{
				return base.GetSystemDecimal(EMailsMetadata.ColumnNames.SaldoDevedor);
			}
			
			set
			{
				if(base.SetSystemDecimal(EMailsMetadata.ColumnNames.SaldoDevedor, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.SaldoDevedor);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Adicionais
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Adicionais
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Adicionais);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Adicionais, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Adicionais);
				}
			}
		}		
		
		/// <summary>
		/// Maps to eMails.Acao
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Acao
		{
			get
			{
				return base.GetSystemString(EMailsMetadata.ColumnNames.Acao);
			}
			
			set
			{
				if(base.SetSystemString(EMailsMetadata.ColumnNames.Acao, value))
				{
					OnPropertyChanged(EMailsMetadata.PropertyNames.Acao);
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
						case "DataInclusao": this.str().DataInclusao = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "Nome": this.str().Nome = (string)value; break;							
						case "Telefone": this.str().Telefone = (string)value; break;							
						case "Celular": this.str().Celular = (string)value; break;							
						case "Administradora": this.str().Administradora = (string)value; break;							
						case "TipoConsorcio": this.str().TipoConsorcio = (string)value; break;							
						case "Grupo": this.str().Grupo = (string)value; break;							
						case "Cota": this.str().Cota = (string)value; break;							
						case "Contemplado": this.str().Contemplado = (string)value; break;							
						case "TotalParcelas": this.str().TotalParcelas = (string)value; break;							
						case "Entrada": this.str().Entrada = (string)value; break;							
						case "ParcelasPagas": this.str().ParcelasPagas = (string)value; break;							
						case "ParcelasEmAtraso": this.str().ParcelasEmAtraso = (string)value; break;							
						case "ValorDoBem": this.str().ValorDoBem = (string)value; break;							
						case "ValorDaParcela": this.str().ValorDaParcela = (string)value; break;							
						case "SaldoDevedor": this.str().SaldoDevedor = (string)value; break;							
						case "Adicionais": this.str().Adicionais = (string)value; break;							
						case "Acao": this.str().Acao = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Guid)
								this.Id = (System.Guid?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.Id);
							break;
						
						case "DataInclusao":
						
							if (value == null || value is System.DateTime)
								this.DataInclusao = (System.DateTime?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.DataInclusao);
							break;
						
						case "TotalParcelas":
						
							if (value == null || value is System.Decimal)
								this.TotalParcelas = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.TotalParcelas);
							break;
						
						case "Entrada":
						
							if (value == null || value is System.Decimal)
								this.Entrada = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.Entrada);
							break;
						
						case "ParcelasPagas":
						
							if (value == null || value is System.Decimal)
								this.ParcelasPagas = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.ParcelasPagas);
							break;
						
						case "ParcelasEmAtraso":
						
							if (value == null || value is System.Decimal)
								this.ParcelasEmAtraso = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.ParcelasEmAtraso);
							break;
						
						case "ValorDoBem":
						
							if (value == null || value is System.Decimal)
								this.ValorDoBem = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.ValorDoBem);
							break;
						
						case "ValorDaParcela":
						
							if (value == null || value is System.Decimal)
								this.ValorDaParcela = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.ValorDaParcela);
							break;
						
						case "SaldoDevedor":
						
							if (value == null || value is System.Decimal)
								this.SaldoDevedor = (System.Decimal?)value;
								OnPropertyChanged(EMailsMetadata.PropertyNames.SaldoDevedor);
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
			public esStrings(esEMails entity)
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
				
			public System.String DataInclusao
			{
				get
				{
					System.DateTime? data = entity.DataInclusao;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DataInclusao = null;
					else entity.DataInclusao = Convert.ToDateTime(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String Nome
			{
				get
				{
					System.String data = entity.Nome;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Nome = null;
					else entity.Nome = Convert.ToString(value);
				}
			}
				
			public System.String Telefone
			{
				get
				{
					System.String data = entity.Telefone;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Telefone = null;
					else entity.Telefone = Convert.ToString(value);
				}
			}
				
			public System.String Celular
			{
				get
				{
					System.String data = entity.Celular;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Celular = null;
					else entity.Celular = Convert.ToString(value);
				}
			}
				
			public System.String Administradora
			{
				get
				{
					System.String data = entity.Administradora;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Administradora = null;
					else entity.Administradora = Convert.ToString(value);
				}
			}
				
			public System.String TipoConsorcio
			{
				get
				{
					System.String data = entity.TipoConsorcio;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TipoConsorcio = null;
					else entity.TipoConsorcio = Convert.ToString(value);
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
				
			public System.String Contemplado
			{
				get
				{
					System.String data = entity.Contemplado;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Contemplado = null;
					else entity.Contemplado = Convert.ToString(value);
				}
			}
				
			public System.String TotalParcelas
			{
				get
				{
					System.Decimal? data = entity.TotalParcelas;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TotalParcelas = null;
					else entity.TotalParcelas = Convert.ToDecimal(value);
				}
			}
				
			public System.String Entrada
			{
				get
				{
					System.Decimal? data = entity.Entrada;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Entrada = null;
					else entity.Entrada = Convert.ToDecimal(value);
				}
			}
				
			public System.String ParcelasPagas
			{
				get
				{
					System.Decimal? data = entity.ParcelasPagas;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ParcelasPagas = null;
					else entity.ParcelasPagas = Convert.ToDecimal(value);
				}
			}
				
			public System.String ParcelasEmAtraso
			{
				get
				{
					System.Decimal? data = entity.ParcelasEmAtraso;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ParcelasEmAtraso = null;
					else entity.ParcelasEmAtraso = Convert.ToDecimal(value);
				}
			}
				
			public System.String ValorDoBem
			{
				get
				{
					System.Decimal? data = entity.ValorDoBem;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ValorDoBem = null;
					else entity.ValorDoBem = Convert.ToDecimal(value);
				}
			}
				
			public System.String ValorDaParcela
			{
				get
				{
					System.Decimal? data = entity.ValorDaParcela;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ValorDaParcela = null;
					else entity.ValorDaParcela = Convert.ToDecimal(value);
				}
			}
				
			public System.String SaldoDevedor
			{
				get
				{
					System.Decimal? data = entity.SaldoDevedor;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaldoDevedor = null;
					else entity.SaldoDevedor = Convert.ToDecimal(value);
				}
			}
				
			public System.String Adicionais
			{
				get
				{
					System.String data = entity.Adicionais;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Adicionais = null;
					else entity.Adicionais = Convert.ToString(value);
				}
			}
				
			public System.String Acao
			{
				get
				{
					System.String data = entity.Acao;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Acao = null;
					else entity.Acao = Convert.ToString(value);
				}
			}
			

			private esEMails entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EMailsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EMailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EMailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EMailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EMailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EMailsQuery query;		
	}



	[Serializable]
	abstract public partial class esEMailsCollection : esEntityCollection<EMails>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EMailsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EMailsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EMailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EMailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EMailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EMailsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EMailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EMailsQuery)query);
		}

		#endregion
		
		private EMailsQuery query;
	}



	[Serializable]
	abstract public partial class esEMailsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EMailsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "DataInclusao": return this.DataInclusao;
				case "Email": return this.Email;
				case "Nome": return this.Nome;
				case "Telefone": return this.Telefone;
				case "Celular": return this.Celular;
				case "Administradora": return this.Administradora;
				case "TipoConsorcio": return this.TipoConsorcio;
				case "Grupo": return this.Grupo;
				case "Cota": return this.Cota;
				case "Contemplado": return this.Contemplado;
				case "TotalParcelas": return this.TotalParcelas;
				case "Entrada": return this.Entrada;
				case "ParcelasPagas": return this.ParcelasPagas;
				case "ParcelasEmAtraso": return this.ParcelasEmAtraso;
				case "ValorDoBem": return this.ValorDoBem;
				case "ValorDaParcela": return this.ValorDaParcela;
				case "SaldoDevedor": return this.SaldoDevedor;
				case "Adicionais": return this.Adicionais;
				case "Acao": return this.Acao;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Id, esSystemType.Guid); }
		} 
		
		public esQueryItem DataInclusao
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.DataInclusao, esSystemType.DateTime); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Nome
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Nome, esSystemType.String); }
		} 
		
		public esQueryItem Telefone
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Telefone, esSystemType.String); }
		} 
		
		public esQueryItem Celular
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Celular, esSystemType.String); }
		} 
		
		public esQueryItem Administradora
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Administradora, esSystemType.String); }
		} 
		
		public esQueryItem TipoConsorcio
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.TipoConsorcio, esSystemType.String); }
		} 
		
		public esQueryItem Grupo
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Grupo, esSystemType.String); }
		} 
		
		public esQueryItem Cota
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Cota, esSystemType.String); }
		} 
		
		public esQueryItem Contemplado
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Contemplado, esSystemType.String); }
		} 
		
		public esQueryItem TotalParcelas
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.TotalParcelas, esSystemType.Decimal); }
		} 
		
		public esQueryItem Entrada
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Entrada, esSystemType.Decimal); }
		} 
		
		public esQueryItem ParcelasPagas
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.ParcelasPagas, esSystemType.Decimal); }
		} 
		
		public esQueryItem ParcelasEmAtraso
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.ParcelasEmAtraso, esSystemType.Decimal); }
		} 
		
		public esQueryItem ValorDoBem
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.ValorDoBem, esSystemType.Decimal); }
		} 
		
		public esQueryItem ValorDaParcela
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.ValorDaParcela, esSystemType.Decimal); }
		} 
		
		public esQueryItem SaldoDevedor
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.SaldoDevedor, esSystemType.Decimal); }
		} 
		
		public esQueryItem Adicionais
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Adicionais, esSystemType.String); }
		} 
		
		public esQueryItem Acao
		{
			get { return new esQueryItem(this, EMailsMetadata.ColumnNames.Acao, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class EMails : esEMails
	{

		
		
	}
	



	[Serializable]
	public partial class EMailsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EMailsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Id, 0, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = EMailsMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.DataInclusao, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = EMailsMetadata.PropertyNames.DataInclusao;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Email, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 150;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Nome, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Nome;
			c.CharacterMaxLength = 150;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Telefone, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Telefone;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Celular, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Celular;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Administradora, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Administradora;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.TipoConsorcio, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.TipoConsorcio;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Grupo, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Grupo;
			c.CharacterMaxLength = 8;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Cota, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Cota;
			c.CharacterMaxLength = 8;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Contemplado, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Contemplado;
			c.CharacterMaxLength = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.TotalParcelas, 11, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.TotalParcelas;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Entrada, 12, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.Entrada;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.ParcelasPagas, 13, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.ParcelasPagas;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.ParcelasEmAtraso, 14, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.ParcelasEmAtraso;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.ValorDoBem, 15, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.ValorDoBem;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.ValorDaParcela, 16, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.ValorDaParcela;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.SaldoDevedor, 17, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EMailsMetadata.PropertyNames.SaldoDevedor;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Adicionais, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Adicionais;
			c.CharacterMaxLength = 300;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EMailsMetadata.ColumnNames.Acao, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = EMailsMetadata.PropertyNames.Acao;
			c.CharacterMaxLength = 300;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EMailsMetadata Meta()
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
			 public const string DataInclusao = "DataInclusao";
			 public const string Email = "Email";
			 public const string Nome = "Nome";
			 public const string Telefone = "Telefone";
			 public const string Celular = "Celular";
			 public const string Administradora = "Administradora";
			 public const string TipoConsorcio = "TipoConsorcio";
			 public const string Grupo = "Grupo";
			 public const string Cota = "Cota";
			 public const string Contemplado = "Contemplado";
			 public const string TotalParcelas = "TotalParcelas";
			 public const string Entrada = "Entrada";
			 public const string ParcelasPagas = "ParcelasPagas";
			 public const string ParcelasEmAtraso = "ParcelasEmAtraso";
			 public const string ValorDoBem = "ValorDoBem";
			 public const string ValorDaParcela = "ValorDaParcela";
			 public const string SaldoDevedor = "SaldoDevedor";
			 public const string Adicionais = "Adicionais";
			 public const string Acao = "Acao";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string DataInclusao = "DataInclusao";
			 public const string Email = "Email";
			 public const string Nome = "Nome";
			 public const string Telefone = "Telefone";
			 public const string Celular = "Celular";
			 public const string Administradora = "Administradora";
			 public const string TipoConsorcio = "TipoConsorcio";
			 public const string Grupo = "Grupo";
			 public const string Cota = "Cota";
			 public const string Contemplado = "Contemplado";
			 public const string TotalParcelas = "TotalParcelas";
			 public const string Entrada = "Entrada";
			 public const string ParcelasPagas = "ParcelasPagas";
			 public const string ParcelasEmAtraso = "ParcelasEmAtraso";
			 public const string ValorDoBem = "ValorDoBem";
			 public const string ValorDaParcela = "ValorDaParcela";
			 public const string SaldoDevedor = "SaldoDevedor";
			 public const string Adicionais = "Adicionais";
			 public const string Acao = "Acao";
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
			lock (typeof(EMailsMetadata))
			{
				if(EMailsMetadata.mapDelegates == null)
				{
					EMailsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EMailsMetadata.meta == null)
				{
					EMailsMetadata.meta = new EMailsMetadata();
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
				meta.AddTypeMap("DataInclusao", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Nome", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Telefone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Celular", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Administradora", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TipoConsorcio", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Grupo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Cota", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Contemplado", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TotalParcelas", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Entrada", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("ParcelasPagas", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("ParcelasEmAtraso", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("ValorDoBem", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("ValorDaParcela", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("SaldoDevedor", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Adicionais", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Acao", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "eMails";
				meta.Destination = "eMails";
				
				meta.spInsert = "proc_eMailsInsert";				
				meta.spUpdate = "proc_eMailsUpdate";		
				meta.spDelete = "proc_eMailsDelete";
				meta.spLoadAll = "proc_eMailsLoadAll";
				meta.spLoadByPrimaryKey = "proc_eMailsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EMailsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
