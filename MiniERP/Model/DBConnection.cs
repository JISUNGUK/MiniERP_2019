using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model
{
    class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }

        #region 설정
        /// <summary>
        /// 열려있는 DB연결객체를 반환합니다.
        /// </summary>
        /// <returns>DB에 연결된 SqlConnection객체(con)를 반환합니다.</returns>
        private SqlConnection OpenSqlConnection()
        {
            if (con.State == System.Data.ConnectionState.Broken || con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        /// <summary>
        /// SqlCommand 객체를 저장프로시저타입으로 설정 후 반환합니다.
        /// </summary>
        /// <param name="sqlConnection">SqlConnection 객체입니다.</param>
        /// <param name="storedProcedureName">수행할 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행할 저장프로시저에 필요한 파라메터입니다.</param>
        /// <param name="sqlTransaction">SqlCommand가 실행될 SqlTransaction입니다.</param>
        /// <returns></returns>
        private SqlCommand GetSqlCommand(SqlConnection sqlConnection, string storedProcedureName, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedureName;
            if (sqlParameters != null)
            {
                sqlCommand.Parameters.AddRange(sqlParameters);
            }

            return sqlCommand;
        }
        #endregion

        #region 실행
        /// <summary>
        /// 저장된 프로시저의 결과를 읽어옵니다.
        /// </summary>
        /// <param name="storeProcedureName">수행할 저장프로시저의 이름입니다.</param>
        /// <returns>Table의 모든 내용을 SqlDataReader객체로 반환합니다.</returns>
        public SqlDataReader ExecuteSelect(string storeProcedureName, SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlDataReader;
            using (SqlConnection sqlConnection = OpenSqlConnection())
            {
                SqlCommand sqlCommand = GetSqlCommand(sqlConnection, storeProcedureName, sqlParameters);
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }

                try
                {
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return sqlDataReader;
        }

        /// <summary>
        /// 저장된 프로시저를 실행합니다. 영향받은 행의 갯수만 반환합니다.
        /// </summary>
        /// <param name="storedProcedureName">수행될 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행될 저장프로시저에 필요한 파라메터입니다.</param>
        /// <returns>프로시저 실행이 정상적으로 완료되면 영향받은 행의 갯수를 반환합니다.</returns>
        public int ExecuteNonQuery(string storedProcedureName, SqlParameter[] sqlParameters)
        {
            int result;

            using (SqlConnection sqlConnection = OpenSqlConnection())
            {
                using (SqlTransaction tran = sqlConnection.BeginTransaction())
                {
                    SqlCommand sqlCommand = GetSqlCommand(sqlConnection, storedProcedureName, sqlParameters);
                    sqlCommand.Transaction = tran;
                    try
                    {
                        result = sqlCommand.ExecuteNonQuery();
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Query로 select 결과 읽어오기
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public SqlDataReader SelectQuery(string query)
        {
            SqlDataReader sqlDataReader;
            using (SqlConnection sqlConnection = OpenSqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = query;

                sqlDataReader = sqlCommand.ExecuteReader();
            }

            try
            {
                return sqlDataReader;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Query로 DML 실행
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int NonQuery(string query)
        {
            int result;

            using (SqlConnection sqlConnection = OpenSqlConnection())
            {
                using (SqlTransaction tran = sqlConnection.BeginTransaction())
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = query;

                    try
                    {
                        result = sqlCommand.ExecuteNonQuery();
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }

            return result;
        } 
        #endregion
    }
}

