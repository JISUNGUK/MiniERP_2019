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
	}
}
#pragma warning restore 1591
