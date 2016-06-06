using System;
using System.Collections.Generic;
using System.Xml;
using System.Data.SQLite;
using System.Collections;
using System.Data;
using System.Configuration;


public class SQLiteDBHelper
{
    //public static string connectionString = ConfigurationManager.AppSettings["conn"].ToString();
    //public static string connectionString = "Data Source=G:\\mpos.db";

    public static string connectionString = "Data Source=" + Environment.CurrentDirectory + "\\db\\local.db";

    public static bool Exists(string strSql, params SQLiteParameter[] cmdParms)
    {
        object obj = GetSingle(strSql, cmdParms);
        int cmdresult;
        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
        {
            cmdresult = 0;
        }
        else
        {
            cmdresult = int.Parse(obj.ToString());
        }

        if (cmdresult == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static object GetSingle(string SQLString, params SQLiteParameter[] cmdParms)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    object obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                catch (SQLiteException e)
                {
                    throw e;
                }
            }
        }
    }

    public static int ExecuteSql(string SQLString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
            {
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (SQLiteException ex)
                {
                    connection.Close();
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

    public static int ExecuteSqlByTime(string SQLString, int Times)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
                try
                {
                    connection.Open();
                    cmd.CommandTimeout = Times;
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (SQLiteException e)
                {
                    connection.Close();
                    throw e;
                }
        }
    }


    public static int ExecuteSqlTran(List<String> SQLStringList)
    {
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            SQLiteTransaction tx = conn.BeginTransaction();
            cmd.Transaction = tx;

            try
            {
                int count = 0;
                for (int n = 0; n < SQLStringList.Count; n++)
                {
                    string strsql = SQLStringList[n];
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        count += cmd.ExecuteNonQuery();
                    }
                }
                tx.Commit();
                return count;
            }
            catch (Exception ex)
            {
                tx.Rollback();
                return 0;
            }
        }
    }

    public static SQLiteDataReader ExecuteReader(string strSQL)
    {
        SQLiteConnection connection = new SQLiteConnection(connectionString);
        SQLiteCommand cmd = new SQLiteCommand(strSQL, connection);
        try
        {
            connection.Open();
            SQLiteDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myReader;
        }
        catch (SQLiteException e)
        {
            throw e;
        }
    }


    public static DataSet Query(string SQLString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                SQLiteDataAdapter command = new SQLiteDataAdapter(SQLString, connection);
                command.Fill(ds, "ds");
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }
    }

      

    public static int ExecuteSql(string SQLString, params SQLiteParameter[] cmdParms)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    int rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return rows;
                }
                catch (SQLiteException e)
                {
                    throw e;
                }
            }
        }
    }

    public static void ExecuteSqlTran(Hashtable SQLStringList)
    {
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            using (SQLiteTransaction trans = conn.BeginTransaction())
            {
                SQLiteCommand cmd = new SQLiteCommand();
                try
                {

                    foreach (DictionaryEntry myDE in SQLStringList)
                    {
                        string cmdText = myDE.Key.ToString();
                        SQLiteParameter[] cmdParms = (SQLiteParameter[])myDE.Value;
                        PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                        int val = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }

    public static SQLiteDataReader ExecuteReader(string SQLString, params SQLiteParameter[] cmdParms)
    {
        SQLiteConnection connection = new SQLiteConnection(connectionString);
        SQLiteCommand cmd = new SQLiteCommand();
        try
        {
            PrepareCommand(cmd, connection, null, SQLString, cmdParms);
            SQLiteDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return myReader;
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            throw e;
        }
    }

    public static DataSet Query(string SQLString, params SQLiteParameter[] cmdParms)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            SQLiteCommand cmd = new SQLiteCommand();
            PrepareCommand(cmd, connection, null, SQLString, cmdParms);
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds, "ds");
                    cmd.Parameters.Clear();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
    }

    private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, SQLiteParameter[] cmdParms)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        if (trans != null)
            cmd.Transaction = trans;
        cmd.CommandType = CommandType.Text;//cmdType;
        if (cmdParms != null)
        {


            foreach (SQLiteParameter parameter in cmdParms)
            {
                if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                    (parameter.Value == null))
                {
                    parameter.Value = DBNull.Value;
                }
                cmd.Parameters.Add(parameter);
            }
        }
    }

    public static SQLiteDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
    {
        SQLiteConnection connection = new SQLiteConnection(connectionString);
        SQLiteDataReader returnReader;
        connection.Open();
        SQLiteCommand command = BuildQueryCommand(connection, storedProcName, parameters);
        command.CommandType = CommandType.StoredProcedure;
        returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return returnReader;

    }

    public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            DataSet dataSet = new DataSet();
            connection.Open();
            SQLiteDataAdapter sqlDA = new SQLiteDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            connection.Close();
            return dataSet;
        }
    }

    private static SQLiteCommand BuildQueryCommand(SQLiteConnection connection, string storedProcName, IDataParameter[] parameters)
    {
        SQLiteCommand command = new SQLiteCommand(storedProcName, connection);
        command.CommandType = CommandType.StoredProcedure;
        foreach (SQLiteParameter parameter in parameters)
        {
            if (parameter != null)
            {
                if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                    (parameter.Value == null))
                {
                    parameter.Value = DBNull.Value;
                }
                command.Parameters.Add(parameter);
            }
        }

        return command;
    }

    public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            int result;
            connection.Open();
            SQLiteCommand command = BuildIntCommand(connection, storedProcName, parameters);
            rowsAffected = command.ExecuteNonQuery();
            result = (int)command.Parameters["ReturnValue"].Value;
            //Connection.Close();
            return result;
        }
    }

    private static SQLiteCommand BuildIntCommand(SQLiteConnection connection, string storedProcName, IDataParameter[] parameters)
    {
        SQLiteCommand command = BuildQueryCommand(connection, storedProcName, parameters);
        command.Parameters.Add(
            new SQLiteParameter("ReturnValue",
            DbType.Int32, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));
        return command;
    }

    public static int ExecureData(DataSet ds, string strTblName)
    {
        //创建一个数据库连接  
        using (SQLiteConnection Connection = new SQLiteConnection(connectionString))
        {

            //创建一个用于填充DataSet的对象  
            SQLiteCommand myCommand = new SQLiteCommand("SELECT * FROM " + strTblName + " WHERE 1=0 ", Connection);
           
            try
            {

                if (Connection.State != ConnectionState.Open)
                    Connection.Open();

                SQLiteDataAdapter myAdapter = new SQLiteDataAdapter();
                //获取SQL语句，用于在数据库中选择记录  
                myAdapter.SelectCommand = myCommand;
              
                //自动生成单表命令，用于将对DataSet所做的更改与数据库更改相对应  
                SQLiteCommandBuilder myCommandBuilder = new SQLiteCommandBuilder(myAdapter);

                return myAdapter.Update(ds, strTblName);  //更新ds数据  

            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                myCommand.Dispose();
                Connection.Close();
            }
        }

    }
}

