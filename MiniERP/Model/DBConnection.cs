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

        /// <summary>
        /// DB연결이 닫혀있거나 끊어져 있을 경우 다시 연결합니다.
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
        /// Table에 대하여 수행할 SqlCommand를 반환합니다.
        /// </summary>
        /// <param name="sqlConnection">SqlConnection 객체입니다.</param>
        /// <param name="storedProcedureName">수행할 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행할 저장프로시저에 필요한 파라메터입니다.</param>
        /// <param name="sqlTransaction">SqlCommand가 실행될 SqlTransaction입니다.</param>
        /// <returns></returns>
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
        /// <returns>Table의 모든 내용을 SqlDataReader객체로 반환합니다.</returns>
        public SqlDataReader ExecuteSelect(string storeProcedureName)
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
        /// Querry로 select
        /// </summary>
        /// <param name="querry"></param>
        /// <returns></returns>
        public SqlDataReader QuerrySelect(string querry)
        {
            SqlConnection sqlConnection = OpenSqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = querry;

            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region 수정될수있는 내용, 작성자: 조성호
        // 굳이 bool 타입으로 해야할 이유있음?
        // 어짜피 try ~catch로 오류반환 할거니 그걸로 확인하면 될거라고 생각하는데..

        /// <summary>
        /// Table에 Insert를 수행합니다.
        /// </summary>
        /// <param name="storedProcedureName">수행될 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행될 저장프로시저에 필요한 파라메터입니다.</param>
        /// <returns>Insert작업이 성공하면 true, 그렇지 않으면 false를 반환합니다.</returns>
        public bool ExcuteInsert(string storedProcedureName, SqlParameter[] sqlParameters)
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

        /// <summary>
        /// Table에 Update 또는 Delete를 수행합니다.
        /// </summary>
        /// <param name="storeProcedureName">수행될 저장프로시저의 이름입니다.</param>
        /// <param name="sqlParameters">수행될 저장프로시저에 필요한 파라메터입니다.</param>
        /// <returns>Update 또는 Delete가 정상적으로 수행되면 true, 그렇지 않으면 false를 반환합니다.</returns>
        public bool ExecuteUpdateOrDelete(string storeProcedureName, SqlParameter[] sqlParameters)
        {
            bool result = false;

            SqlConnection sqlConnection = OpenSqlConnection();
            SqlTransaction sqlTransaction = GetSqlTransaction(sqlConnection);

            using (sqlTransaction)
            {
                SqlCommand sqlCommand = GetSqlCommand(sqlConnection, storeProcedureName, sqlParameters, sqlTransaction);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }

        // 수정한다면 이런식으로. 바뀌는건 없음.
        // 기존 SqlCommand 메서드를 따라서 ExecuteNonquery 라는 이름으로 하면 어떨까 싶음
        public bool ExecuteNonquery(string storeProcedureName, SqlParameter[] sqlParameters)
        {
            bool result = false;

            SqlConnection sqlConnection = OpenSqlConnection();
            SqlTransaction sqlTransaction = GetSqlTransaction(sqlConnection);

            using (sqlTransaction)
            {
                SqlCommand sqlCommand = GetSqlCommand(sqlConnection, storeProcedureName, sqlParameters, sqlTransaction);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }


        // 이거 필요함? 궁금해서 그럼.
        /// <summary>
        /// SqlConnection객체를 받아 SqlTransaction객체를 시작합니다.
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <returns>SqlConnection객체를 받아 시작된 SqlTransaction객체를 반환합니다.</returns>
        private SqlTransaction GetSqlTransaction(SqlConnection sqlConnection)
        {
            return sqlConnection.BeginTransaction();
        }
        #endregion
    }
}

