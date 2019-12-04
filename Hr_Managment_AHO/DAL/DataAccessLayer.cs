using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hr_Managment_AHO.DAL
{
    class DataAccessLayer
    {

        public SqlConnection sqlconnection;

        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection("Server=IDEAPAD310;Database=AHO_DB;Integrated Security=True");
        }
        public DataAccessLayer(bool restore)
        {
            sqlconnection = new SqlConnection("Server=DESKTOP-N8H8C20;Database=AHO_DB;Integrated Security=True");
        }
        //to check the database is open
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();

            }
        }

        //to check the database is close
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();

            }
        }
        
        // to read data from database to app
        public DataTable SelectData(string stored_procedure, SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if(param !=  null)
            {
                for(int i =0; i < param.Length; i++) // way to add array to parameter
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
             
                
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
            DataTable dataTable = new DataTable();
             dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //to insert, update, delete from database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null) 
            {
                sqlcmd.Parameters.AddRange(param); // other way
            }

            sqlcmd.ExecuteNonQuery();
        }

    }
}
