using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassJob
    {
        public DataTable GET_ALL_JOB()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_JOB", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SELECT_SAME_JOB(String jobTit)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] SelectUserParam = new SqlParameter[1];
            SelectUserParam[0] = new SqlParameter("@jobTit", SqlDbType.VarChar, 50);
            SelectUserParam[0].Value = jobTit;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SELECT_SAME_JOB", SelectUserParam);
            DAL.Close();
            return Dt;
        }

        public void INSERT_JOB_TIT(string jobTit)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] InsertUserParam = new SqlParameter[1];
            InsertUserParam[0] = new SqlParameter("@jobTit", SqlDbType.VarChar, 50);
            InsertUserParam[0].Value = jobTit;
            DAL.ExecuteCommand("INSERT_JOB_TIT", InsertUserParam);

            DAL.Close();
        }

        public void UPDATE_JOB(int JobId,string JobTit)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] UpdateDocParam = new SqlParameter[2];

            UpdateDocParam[0] = new SqlParameter("@jobId", SqlDbType.Int)
            {
                Value = JobId
            };
            UpdateDocParam[1] = new SqlParameter("@jobTit", SqlDbType.VarChar, 50)
            {
                Value = JobTit
            };
            
            DAL.ExecuteCommand("UPDATE_JOB", UpdateDocParam);
            DAL.Close();
        }

        public void DELETE_JOB(int JobId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] DeleteUserParam = new SqlParameter[1];
            DeleteUserParam[0] = new SqlParameter("@jobId", SqlDbType.Int);
            DeleteUserParam[0].Value = JobId;
            DAL.ExecuteCommand("DELETE_JOB", DeleteUserParam);
            DAL.Close();
        }
    }
}
