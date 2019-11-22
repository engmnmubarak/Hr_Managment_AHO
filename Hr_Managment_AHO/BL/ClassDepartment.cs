using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassDepartment
    {
        public DataTable GET_DEPARTMENT_EMPLOYEE(int empDep)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@empDep", SqlDbType.Int)
            {
                Value = empDep
            };
            dataTable = DAL.SelectData("GET_DEPARTMENT_EMPLOYEE", Param);
            DAL.Close();
            return (dataTable);
        }

        public DataTable GET_DEP_IMAGE(string depId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] ImageParam = new SqlParameter[1];
            ImageParam[0] = new SqlParameter("@depId", SqlDbType.Int);
            ImageParam[0].Value = depId;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_DEP_IMAGE", ImageParam);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_DEPARTMENT_TABLE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_DEPARTMENT_TABLE", null);
            DAL.Close();
            return Dt;
        }

        public void DELETE_DEPARTMENT(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] DeleteUserParam = new SqlParameter[1];
            DeleteUserParam[0] = new SqlParameter("@ID", SqlDbType.Int);
            DeleteUserParam[0].Value = id;
            DAL.ExecuteCommand("DELETE_DEPARTMENT", DeleteUserParam);

            DAL.Close();
        }

        public void ADD_DEP(

            string DepName
           ,string DepAddress
           ,int DepPhone 
           ,string DepEmail
           ,byte[] DepImg
           ,string DepOwner
           ,int DepType
           ,int DirId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] InsertEmpParam = new SqlParameter[8];
            InsertEmpParam[0] = new SqlParameter("@DepName", SqlDbType.VarChar)
            {
                Value = DepName
            };
            InsertEmpParam[1] = new SqlParameter("@DepAddress", SqlDbType.VarChar)
            {
                Value = DepAddress
            };
            InsertEmpParam[2] = new SqlParameter("@DepPhone", SqlDbType.VarChar)
            {
                Value = DepPhone
            };
            InsertEmpParam[3] = new SqlParameter("@DepEmail", SqlDbType.VarChar)
            {
                Value = DepEmail
            };
            InsertEmpParam[4] = new SqlParameter("@DepImg", SqlDbType.Image)
            {
                Value = DepImg
            };
            InsertEmpParam[5] = new SqlParameter("@DepOwner", SqlDbType.VarChar)
            {
                Value = DepOwner
            };
            InsertEmpParam[6] = new SqlParameter("@DepType", SqlDbType.Int)
            {
                Value = DepType
            };
            InsertEmpParam[7] = new SqlParameter("@DirId", SqlDbType.Int)
            {
                Value = DirId
            };
            DAL.ExecuteCommand("ADD_DEP", InsertEmpParam);
            DAL.Close();
        }

        public DataTable GET_ALL_DEPARTMENT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMENT", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SEARCH_DEPARTMENT(string text)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTableSearch = new DataTable();
            SqlParameter[] SearchtUserParam = new SqlParameter[1];
            SearchtUserParam[0] = new SqlParameter("@text", SqlDbType.VarChar, 50)
            {
                Value = text
            };
            dataTableSearch = DAL.SelectData("SEARCH_DEPARTMENT", SearchtUserParam);
            DAL.Close();
            return (dataTableSearch);
        }

        public DataTable GET_DEP_BY_DIR(int dirId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@dirId", SqlDbType.Int)
            {
                Value = dirId
            };
            dataTable = DAL.SelectData("GET_DEP_BY_DIR", Param);
            DAL.Close();
            return (dataTable);
        }

        
        public DataTable GET_DEP_BY_TYPE(int typeId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@typeId", SqlDbType.Int)
            {
                Value = typeId
            };
            dataTable = DAL.SelectData("GET_DEP_BY_TYPE", Param);
            DAL.Close();
            return (dataTable);
        }

        public DataTable GET_ALL_DEP_TYPE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEP_TYPE", null);
            DAL.Close();
            return Dt;
        }

        
    }
}
