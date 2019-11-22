using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassDoc
    {
        public void INSERT_DOC(
             byte[] DocFile,
           string DocTit,
           string DocDesc,
           string DocIssue,
           DateTime DocDate,
           int empId,
           int userId
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] InsertEmpParam = new SqlParameter[7];
            InsertEmpParam[0] = new SqlParameter("@DocFile", SqlDbType.Image)
            {
                Value = DocFile
            };
            InsertEmpParam[1] = new SqlParameter("@DocTit", SqlDbType.VarChar, 50)
            {
                Value = DocTit
            };
            InsertEmpParam[2] = new SqlParameter("@DocDesc", SqlDbType.VarChar, 50)
            {
                Value = DocDesc
            };
            InsertEmpParam[3] = new SqlParameter("@DocIssue", SqlDbType.VarChar, 50)
            {
                Value = DocIssue
            };
            InsertEmpParam[4] = new SqlParameter("@DocDate", SqlDbType.Date)
            {
                Value = DocDate
            };
            InsertEmpParam[5] = new SqlParameter("@empId", SqlDbType.Int)
            {
                Value = empId
            };
            InsertEmpParam[6] = new SqlParameter("@userId", SqlDbType.Int)
            {
                Value = userId
            };
            DAL.ExecuteCommand("ADD_DOC", InsertEmpParam);
            DAL.Close();
        }

        public DataTable GET_EMP_FOLDER(int empId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] SelectUserParam = new SqlParameter[1];
            SelectUserParam[0] = new SqlParameter("@empId", SqlDbType.Int);
            SelectUserParam[0].Value = empId;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_FOLDER", SelectUserParam);
            DAL.Close();
            return Dt;
        }

        public void DELETE_EMPLOYEE_DOC(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] DeleteDocParam = new SqlParameter[1];
            DeleteDocParam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            DeleteDocParam[0].Value = id;
            DAL.ExecuteCommand("DELETE_EMPLOYEE_DOC", DeleteDocParam);
            DAL.Close();
        }

        public DataTable GET_DOC_IMAGE(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] ImageParam = new SqlParameter[1];
            ImageParam[0] = new SqlParameter("@id", SqlDbType.Int);
            ImageParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_DOC_IMAGE", ImageParam);
            DAL.Close();
            return Dt;
        }

    }
}
