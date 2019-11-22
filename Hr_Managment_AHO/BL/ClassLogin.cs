using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Hr_Managment_AHO.BL
{
    class ClassLogin
    {
        public DataTable SELECT_USER(String Name, String Password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] SelectUserParam = new SqlParameter[2];
            SelectUserParam[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            SelectUserParam[0].Value = Name;
            SelectUserParam[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            SelectUserParam[1].Value = Password;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", SelectUserParam);
            DAL.Close();
            return Dt;
        }

        public void INSERT_USER (string Name, string Password, string Type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] InsertUserParam = new SqlParameter[3];
            InsertUserParam[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            InsertUserParam[0].Value = Name;
            InsertUserParam[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            InsertUserParam[1].Value = Password;
            InsertUserParam[2] = new SqlParameter("@Type", SqlDbType.VarChar, 50);
            InsertUserParam[2].Value = Type;
            DAL.ExecuteCommand("ADD_USER", InsertUserParam);

            DAL.Close();            
        }

        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                        
            DataTable UsersTable = new DataTable();
            UsersTable = DAL.SelectData("GET_USERS_TABLE", null);
            DAL.Close();
            return UsersTable;
        }

        public DataTable SEARCH_USER(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] SearchtUserParam = new SqlParameter[1];
            SearchtUserParam[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            SearchtUserParam[0].Value = search;
            dt = DAL.SelectData("Search_User", SearchtUserParam);
            DAL.Close();
            return (dt);
        
        }

        public void DELETE_USER(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] DeleteUserParam = new SqlParameter[1];
            DeleteUserParam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            DeleteUserParam[0].Value = id;
            DAL.ExecuteCommand("DELETE_USER", DeleteUserParam);

            DAL.Close();
        }
    }
}
