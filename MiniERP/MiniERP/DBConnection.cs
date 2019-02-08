using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }

        /// <summary>
        /// DB연결이 닫혀있거나 끊어져 있을 경우 다시 연결합니다.
        /// </summary>
        /// <returns>DB에 연결된 SqlConnection객체(con)를 반환합니다.</returns>
        private SqlConnection OpenSqlConnection()
        {
            if(con.State == System.Data.ConnectionState.Broken || con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        /// <summary>
        /// SqlConnection객체를 받아 SqlTransaction객체를 시작합니다.
        /// </summary>
        /// <param name="sqlConnection">연결된 SqlConnection객체입니다.</param>
        /// <returns>SqlConnection객체를 받아 시작된 SqlTransaction객체를 반환합니다.</returns>
        private SqlTransaction GetSqlTransaction(SqlConnection sqlConnection)
        {
            return sqlConnection.BeginTransaction();
        }

        /// <summary>
        /// Table에 대하여 수행할 SqlCommand를 반환합니다.
        /// </summary>
        /// <param name="sqlConnection">SqlConnection 객체입니다.</param>
        /// <param name="storedProcedureName">수행할 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행할 저장프로시저에 필요한 파라메터입니다.</param>
        /// <param name="sqlTransaction">SqlCommand가 실행될 SqlTransaction입니다.</param>
        /// <returns>수행할 SqlCommand객체(sqlCommand)를 반환합니다.</returns>
        private SqlCommand GetSqlCommand(SqlConnection sqlConnection, string storedProcedureName, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedureName;
            sqlCommand.Transaction = sqlTransaction;
            sqlCommand.Parameters.AddRange(sqlParameters);

            return sqlCommand;
        }

        /// <summary>
        /// Table의 내용을 읽어옵니다.
        /// </summary>
        /// <param name="storeProcedureName">수행할 저장프로시저의 이름입니다.</param>
        /// <returns>Table의 내용을 SqlDataReader객체로 반환합니다.</returns>
        private SqlDataReader ExecuteSelect(string storeProcedureName)
        {
            SqlConnection sqlConnection = OpenSqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = storeProcedureName;

            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Table에 Insert, Update, Delete를 수행합니다.
        /// </summary>
        /// <param name="storedProcedureName">수행될 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행될 저장프로시저에 필요한 파라메터입니다.</param>
        /// <returns>Insert작업이 성공하면 true, 그렇지 않으면 false를 반환합니다.</returns>
        private bool ExcuteProcedure(string storedProcedureName, SqlParameter[] sqlParameters)
        {
            bool result = false;

            SqlConnection sqlConnection = OpenSqlConnection();
            SqlTransaction sqlTransaction = GetSqlTransaction(sqlConnection);

            using (sqlTransaction)
            {
                SqlCommand sqlCommand = GetSqlCommand(sqlConnection, storedProcedureName, sqlParameters, sqlTransaction);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                    throw;
                }
                return result;
            }
        }
    }
}
