﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniERP.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ERP_INFO")]
	public partial class MiniErpDB : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    #endregion
		
		public MiniErpDB() : 
				base(global::MiniERP.Properties.Settings.Default.ERP_INFOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MiniErpDB(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniErpDB(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniErpDB(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MiniErpDB(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.MODIFY_TRADE")]
		public int MODIFY_TRADE([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string trade_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string clerk_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string warehouse_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string trade_status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), trade_code, clerk_code, warehouse_code, trade_status);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_MANUFACTURE_DOC")]
		public ISingleResult<GET_MANUFACTURE_DOCResult> GET_MANUFACTURE_DOC([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Manufactdate", DbType="Date")] System.Nullable<System.DateTime> manufactdate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string warehouse_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), manufactdate, warehouse_code);
			return ((ISingleResult<GET_MANUFACTURE_DOCResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_RESOURCES_PLAN")]
		public ISingleResult<GET_RESOURCES_PLANResult> GET_RESOURCES_PLAN([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string ordere_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ordere_code);
			return ((ISingleResult<GET_RESOURCES_PLANResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_PURCHASE_PLAN")]
		public ISingleResult<GET_PURCHASE_PLANResult> GET_PURCHASE_PLAN([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string ordere_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ordere_code);
			return ((ISingleResult<GET_PURCHASE_PLANResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_ORDER")]
		public ISingleResult<GET_ORDERResult> GET_ORDER([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Order_code", DbType="NVarChar(20)")] string order_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), order_code);
			return ((ISingleResult<GET_ORDERResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SET_STOCK_ITEM")]
		public int SET_STOCK_ITEM([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string item_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string warehouse_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stock_count)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), item_code, warehouse_code, stock_count);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_STOCK")]
		public ISingleResult<GET_STOCKResult> GET_STOCK([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string warehouse_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string item_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), warehouse_code, item_code);
			return ((ISingleResult<GET_STOCKResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_DISTRIBUTION")]
		public ISingleResult<GET_DISTRIBUTIONResult> GET_DISTRIBUTION([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> low_date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> max_date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string before_warehouse, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string after_warehouse, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string item_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string status, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PageNumber", DbType="Int")] System.Nullable<int> pageNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RowsPerPage", DbType="Int")] System.Nullable<int> rowsPerPage)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), low_date, max_date, before_warehouse, after_warehouse, item_code, status, pageNumber, rowsPerPage);
			return ((ISingleResult<GET_DISTRIBUTIONResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Get_Export")]
		public ISingleResult<Get_ExportResult> Get_Export([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> move_date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string before_warehouse)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), move_date, before_warehouse);
			return ((ISingleResult<Get_ExportResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Get_Import")]
		public ISingleResult<Get_ImportResult> Get_Import([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> move_date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string after_warehouse)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), move_date, after_warehouse);
			return ((ISingleResult<Get_ImportResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_MANUFACTURE_PLAN")]
		public ISingleResult<GET_MANUFACTURE_PLANResult> GET_MANUFACTURE_PLAN([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string order_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), order_code);
			return ((ISingleResult<GET_MANUFACTURE_PLANResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SET_DISTRIBUTION")]
		public int SET_DISTRIBUTION([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string order_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string before_warehouse, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string after_warehouse, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string item_code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string distribution_count, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> move_date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), order_code, before_warehouse, after_warehouse, item_code, distribution_count, move_date);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Get_Specific_Business")]
		public ISingleResult<Get_Specific_BusinessResult> Get_Specific_Business([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Business_code", DbType="NVarChar(20)")] string business_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), business_code);
			return ((ISingleResult<Get_Specific_BusinessResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PROC_STATEMENT")]
		public ISingleResult<PROC_STATEMENTResult> PROC_STATEMENT([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string order_code)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), order_code);
			return ((ISingleResult<PROC_STATEMENTResult>)(result.ReturnValue));
		}
	}
	
	public partial class GET_MANUFACTURE_DOCResult
	{
		
		private string _Item_code;
		
		private string _item_name;
		
		private string _item_standard;
		
		private int _Distribution_count;
		
		public GET_MANUFACTURE_DOCResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Item_code
		{
			get
			{
				return this._Item_code;
			}
			set
			{
				if ((this._Item_code != value))
				{
					this._Item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string item_name
		{
			get
			{
				return this._item_name;
			}
			set
			{
				if ((this._item_name != value))
				{
					this._item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_standard", DbType="NVarChar(20)")]
		public string item_standard
		{
			get
			{
				return this._item_standard;
			}
			set
			{
				if ((this._item_standard != value))
				{
					this._item_standard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_count", DbType="Int NOT NULL")]
		public int Distribution_count
		{
			get
			{
				return this._Distribution_count;
			}
			set
			{
				if ((this._Distribution_count != value))
				{
					this._Distribution_count = value;
				}
			}
		}
	}
	
	public partial class GET_RESOURCES_PLANResult
	{
		
		private string _part_code;
		
		private string _item_name;
		
		private System.Nullable<int> _item_count;
		
		private string _item_standard;
		
		public GET_RESOURCES_PLANResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_part_code", DbType="NVarChar(20)")]
		public string part_code
		{
			get
			{
				return this._part_code;
			}
			set
			{
				if ((this._part_code != value))
				{
					this._part_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="NVarChar(50)")]
		public string item_name
		{
			get
			{
				return this._item_name;
			}
			set
			{
				if ((this._item_name != value))
				{
					this._item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_count", DbType="Int")]
		public System.Nullable<int> item_count
		{
			get
			{
				return this._item_count;
			}
			set
			{
				if ((this._item_count != value))
				{
					this._item_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_standard", DbType="NVarChar(20)")]
		public string item_standard
		{
			get
			{
				return this._item_standard;
			}
			set
			{
				if ((this._item_standard != value))
				{
					this._item_standard = value;
				}
			}
		}
	}
	
	public partial class GET_PURCHASE_PLANResult
	{
		
		private string _part_code;
		
		private string _item_name;
		
		private System.Nullable<int> _item_count;
		
		private string _item_standard;
		
		public GET_PURCHASE_PLANResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_part_code", DbType="NVarChar(20)")]
		public string part_code
		{
			get
			{
				return this._part_code;
			}
			set
			{
				if ((this._part_code != value))
				{
					this._part_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="NVarChar(50)")]
		public string item_name
		{
			get
			{
				return this._item_name;
			}
			set
			{
				if ((this._item_name != value))
				{
					this._item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_count", DbType="Int")]
		public System.Nullable<int> item_count
		{
			get
			{
				return this._item_count;
			}
			set
			{
				if ((this._item_count != value))
				{
					this._item_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_standard", DbType="NVarChar(20)")]
		public string item_standard
		{
			get
			{
				return this._item_standard;
			}
			set
			{
				if ((this._item_standard != value))
				{
					this._item_standard = value;
				}
			}
		}
	}
	
	public partial class GET_ORDERResult
	{
		
		private string _item_code;
		
		private string _Item_name;
		
		private int _Item_count;
		
		private int _Item_wrote_fee;
		
		private string _Item_standard;
		
		private string _Item_unit;
		
		public GET_ORDERResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string item_code
		{
			get
			{
				return this._item_code;
			}
			set
			{
				if ((this._item_code != value))
				{
					this._item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_name
		{
			get
			{
				return this._Item_name;
			}
			set
			{
				if ((this._Item_name != value))
				{
					this._Item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_count", DbType="Int NOT NULL")]
		public int Item_count
		{
			get
			{
				return this._Item_count;
			}
			set
			{
				if ((this._Item_count != value))
				{
					this._Item_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_wrote_fee", DbType="Int NOT NULL")]
		public int Item_wrote_fee
		{
			get
			{
				return this._Item_wrote_fee;
			}
			set
			{
				if ((this._Item_wrote_fee != value))
				{
					this._Item_wrote_fee = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_standard", DbType="NVarChar(20)")]
		public string Item_standard
		{
			get
			{
				return this._Item_standard;
			}
			set
			{
				if ((this._Item_standard != value))
				{
					this._Item_standard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_unit", DbType="NVarChar(20)")]
		public string Item_unit
		{
			get
			{
				return this._Item_unit;
			}
			set
			{
				if ((this._Item_unit != value))
				{
					this._Item_unit = value;
				}
			}
		}
	}
	
	public partial class GET_STOCKResult
	{
		
		private string _Item_code;
		
		private string _Item_name;
		
		private string _Warehouse_code;
		
		private string _Warehouse_name;
		
		private string _Item_standard;
		
		private int _Stock_count;
		
		public GET_STOCKResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Item_code
		{
			get
			{
				return this._Item_code;
			}
			set
			{
				if ((this._Item_code != value))
				{
					this._Item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_name
		{
			get
			{
				return this._Item_name;
			}
			set
			{
				if ((this._Item_name != value))
				{
					this._Item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warehouse_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Warehouse_code
		{
			get
			{
				return this._Warehouse_code;
			}
			set
			{
				if ((this._Warehouse_code != value))
				{
					this._Warehouse_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warehouse_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Warehouse_name
		{
			get
			{
				return this._Warehouse_name;
			}
			set
			{
				if ((this._Warehouse_name != value))
				{
					this._Warehouse_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_standard", DbType="NVarChar(20)")]
		public string Item_standard
		{
			get
			{
				return this._Item_standard;
			}
			set
			{
				if ((this._Item_standard != value))
				{
					this._Item_standard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock_count", DbType="Int NOT NULL")]
		public int Stock_count
		{
			get
			{
				return this._Stock_count;
			}
			set
			{
				if ((this._Stock_count != value))
				{
					this._Stock_count = value;
				}
			}
		}
	}
	
	public partial class GET_DISTRIBUTIONResult
	{
		
		private string _Distribution_code;
		
		private string _Before_warehouse;
		
		private string _After_warehouse;
		
		private string _Item_code;
		
		private string _Item_name;
		
		private int _Distribution_count;
		
		private string _Distribution_status;
		
		public GET_DISTRIBUTIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Distribution_code
		{
			get
			{
				return this._Distribution_code;
			}
			set
			{
				if ((this._Distribution_code != value))
				{
					this._Distribution_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Before_warehouse", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Before_warehouse
		{
			get
			{
				return this._Before_warehouse;
			}
			set
			{
				if ((this._Before_warehouse != value))
				{
					this._Before_warehouse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_After_warehouse", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string After_warehouse
		{
			get
			{
				return this._After_warehouse;
			}
			set
			{
				if ((this._After_warehouse != value))
				{
					this._After_warehouse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Item_code
		{
			get
			{
				return this._Item_code;
			}
			set
			{
				if ((this._Item_code != value))
				{
					this._Item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_name
		{
			get
			{
				return this._Item_name;
			}
			set
			{
				if ((this._Item_name != value))
				{
					this._Item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_count", DbType="Int NOT NULL")]
		public int Distribution_count
		{
			get
			{
				return this._Distribution_count;
			}
			set
			{
				if ((this._Distribution_count != value))
				{
					this._Distribution_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_status", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Distribution_status
		{
			get
			{
				return this._Distribution_status;
			}
			set
			{
				if ((this._Distribution_status != value))
				{
					this._Distribution_status = value;
				}
			}
		}
	}
	
	public partial class Get_ExportResult
	{
		
		private string _afterName;
		
		private string _item_name;
		
		private int _Distribution_count;
		
		private string _item_standard;
		
		public Get_ExportResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_afterName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string afterName
		{
			get
			{
				return this._afterName;
			}
			set
			{
				if ((this._afterName != value))
				{
					this._afterName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string item_name
		{
			get
			{
				return this._item_name;
			}
			set
			{
				if ((this._item_name != value))
				{
					this._item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_count", DbType="Int NOT NULL")]
		public int Distribution_count
		{
			get
			{
				return this._Distribution_count;
			}
			set
			{
				if ((this._Distribution_count != value))
				{
					this._Distribution_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_standard", DbType="NVarChar(20)")]
		public string item_standard
		{
			get
			{
				return this._item_standard;
			}
			set
			{
				if ((this._item_standard != value))
				{
					this._item_standard = value;
				}
			}
		}
	}
	
	public partial class Get_ImportResult
	{
		
		private string _beforeName;
		
		private string _item_name;
		
		private int _Distribution_count;
		
		private string _item_standard;
		
		public Get_ImportResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_beforeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string beforeName
		{
			get
			{
				return this._beforeName;
			}
			set
			{
				if ((this._beforeName != value))
				{
					this._beforeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string item_name
		{
			get
			{
				return this._item_name;
			}
			set
			{
				if ((this._item_name != value))
				{
					this._item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distribution_count", DbType="Int NOT NULL")]
		public int Distribution_count
		{
			get
			{
				return this._Distribution_count;
			}
			set
			{
				if ((this._Distribution_count != value))
				{
					this._Distribution_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_standard", DbType="NVarChar(20)")]
		public string item_standard
		{
			get
			{
				return this._item_standard;
			}
			set
			{
				if ((this._item_standard != value))
				{
					this._item_standard = value;
				}
			}
		}
	}
	
	public partial class GET_MANUFACTURE_PLANResult
	{
		
		private string _Item_code;
		
		private string _Item_name;
		
		private System.Nullable<int> _M;
		
		private string _Item_standard;
		
		private int _Item_wrote_fee;
		
		public GET_MANUFACTURE_PLANResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Item_code
		{
			get
			{
				return this._Item_code;
			}
			set
			{
				if ((this._Item_code != value))
				{
					this._Item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_name
		{
			get
			{
				return this._Item_name;
			}
			set
			{
				if ((this._Item_name != value))
				{
					this._Item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M", DbType="Int")]
		public System.Nullable<int> M
		{
			get
			{
				return this._M;
			}
			set
			{
				if ((this._M != value))
				{
					this._M = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_standard", DbType="NVarChar(20)")]
		public string Item_standard
		{
			get
			{
				return this._Item_standard;
			}
			set
			{
				if ((this._Item_standard != value))
				{
					this._Item_standard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_wrote_fee", DbType="Int NOT NULL")]
		public int Item_wrote_fee
		{
			get
			{
				return this._Item_wrote_fee;
			}
			set
			{
				if ((this._Item_wrote_fee != value))
				{
					this._Item_wrote_fee = value;
				}
			}
		}
	}
	
	public partial class Get_Specific_BusinessResult
	{
		
		private string _Business_code;
		
		private string _Business_name;
		
		private string _Business_tel;
		
		private string _Business_addr;
		
		private string _Business_email;
		
		private string _Business_presenter;
		
		public Get_Specific_BusinessResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Business_code
		{
			get
			{
				return this._Business_code;
			}
			set
			{
				if ((this._Business_code != value))
				{
					this._Business_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Business_name
		{
			get
			{
				return this._Business_name;
			}
			set
			{
				if ((this._Business_name != value))
				{
					this._Business_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_tel", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string Business_tel
		{
			get
			{
				return this._Business_tel;
			}
			set
			{
				if ((this._Business_tel != value))
				{
					this._Business_tel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_addr", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Business_addr
		{
			get
			{
				return this._Business_addr;
			}
			set
			{
				if ((this._Business_addr != value))
				{
					this._Business_addr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_email", DbType="NVarChar(50)")]
		public string Business_email
		{
			get
			{
				return this._Business_email;
			}
			set
			{
				if ((this._Business_email != value))
				{
					this._Business_email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Business_presenter", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Business_presenter
		{
			get
			{
				return this._Business_presenter;
			}
			set
			{
				if ((this._Business_presenter != value))
				{
					this._Business_presenter = value;
				}
			}
		}
	}
	
	public partial class PROC_STATEMENTResult
	{
		
		private string _Item_code;
		
		private string _Item_name;
		
		private string _Item_standard;
		
		private int _Item_count;
		
		private int _Item_wrote_fee;
		
		public PROC_STATEMENTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_code", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Item_code
		{
			get
			{
				return this._Item_code;
			}
			set
			{
				if ((this._Item_code != value))
				{
					this._Item_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_name
		{
			get
			{
				return this._Item_name;
			}
			set
			{
				if ((this._Item_name != value))
				{
					this._Item_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_standard", DbType="NVarChar(20)")]
		public string Item_standard
		{
			get
			{
				return this._Item_standard;
			}
			set
			{
				if ((this._Item_standard != value))
				{
					this._Item_standard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_count", DbType="Int NOT NULL")]
		public int Item_count
		{
			get
			{
				return this._Item_count;
			}
			set
			{
				if ((this._Item_count != value))
				{
					this._Item_count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_wrote_fee", DbType="Int NOT NULL")]
		public int Item_wrote_fee
		{
			get
			{
				return this._Item_wrote_fee;
			}
			set
			{
				if ((this._Item_wrote_fee != value))
				{
					this._Item_wrote_fee = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
