using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassEmployee
    {
        public DataTable SEARCH_DEP_EMPLOYEE(int id, string txt)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTableSearch = new DataTable();
            SqlParameter[] SearchtUserParam = new SqlParameter[2];
            SearchtUserParam[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };
            SearchtUserParam[1] = new SqlParameter("@txt", SqlDbType.VarChar, 50)
            {
                Value = txt
            };
            dataTableSearch = DAL.SelectData("SEARCH_DEP_EMPLOYEE", SearchtUserParam);
            DAL.Close();
            return (dataTableSearch);

        }

        public DataTable GET_EMP_BY_JOB_TITLE(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] jobTitParam = new SqlParameter[1];
            jobTitParam[0] = new SqlParameter("@JobTitId", SqlDbType.Int);
            jobTitParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_BY_JOB_TITLE", jobTitParam);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_EMP_BY_EMPJOBSTAT(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] empDepParam = new SqlParameter[1];
            empDepParam[0] = new SqlParameter("@empJobStat", SqlDbType.Int);
            empDepParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_BY_EMPJOBSTAT", empDepParam);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_EMP_BY_DIR(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] empDepParam = new SqlParameter[1];
            empDepParam[0] = new SqlParameter("@dirId", SqlDbType.Int);
            empDepParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_BY_DIR", empDepParam);
            DAL.Close();
            return Dt;
        }
        
        public DataTable GET_EMP_BY_DEP(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] empDepParam = new SqlParameter[1];
            empDepParam[0] = new SqlParameter("@depId", SqlDbType.Int);
            empDepParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_BY_DEP", empDepParam);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_EMP_IMAGE(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] ImageParam = new SqlParameter[1];
            ImageParam[0] = new SqlParameter("@id", SqlDbType.Int);
            ImageParam[0].Value = id;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_EMP_IMAGE", ImageParam);
            DAL.Close();
            return Dt;
        }
        public void UPDATE_DOC(
                int  DocId,
                byte[] DocFile,
                string DocTit,
                string DocDesc,
                string DocIssue,
                DateTime DocDate,
                int userId
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] UpdateDocParam = new SqlParameter[7];

            UpdateDocParam[0] = new SqlParameter("@DocId", SqlDbType.Int)
            {
                Value = DocId
            };
            UpdateDocParam[1] = new SqlParameter("@DocFile", SqlDbType.Image)
            {
                Value = DocFile
            };
            UpdateDocParam[2] = new SqlParameter("@DocTit", SqlDbType.VarChar, 50)
            {
                Value = DocTit
            };
            UpdateDocParam[3] = new SqlParameter("@DocDesc", SqlDbType.VarChar, 50)
            {
                Value = DocDesc
            };
            UpdateDocParam[4] = new SqlParameter("@DocIssue", SqlDbType.VarChar, 50)
            {
                Value = DocIssue
            };
            UpdateDocParam[5] = new SqlParameter("@DocDate", SqlDbType.Date)
            {
                Value = DocDate
            };
            
            UpdateDocParam[6] = new SqlParameter("@userId", SqlDbType.Int)
            {
                Value = userId
            };
            DAL.ExecuteCommand("UPDATE_DOC", UpdateDocParam);
            DAL.Close();
        }
        
        public void DELETE_EMPLOYEE(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] DeleteUserParam = new SqlParameter[1];
            DeleteUserParam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            DeleteUserParam[0].Value = id;
            DAL.ExecuteCommand("DELETE_EMPLOYEE", DeleteUserParam);

            DAL.Close();
        }

        public DataTable SELECT_EMPLOYEE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_EMPLOYEE", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SELECT_EMPLOYEE(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();            
            SqlParameter[] EmployeeParam = new SqlParameter[1];
            EmployeeParam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            EmployeeParam[0].Value = id;
            Dt = DAL.SelectData("SELECT_EMPLOYEE", EmployeeParam);

            DAL.Close();
            return (Dt);
        }

        public DataTable SEARCH_EMPLOYEE(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dataTableSearch = new DataTable();
            SqlParameter[] SearchtUserParam = new SqlParameter[1];
            SearchtUserParam[0] = new SqlParameter("@search", SqlDbType.VarChar,50)
            {
                Value = search
            };
            dataTableSearch = DAL.SelectData("SEARCH_EMPLOYEE", SearchtUserParam);
            DAL.Close();
            return (dataTableSearch);

        }
        
       
        
        public DataTable GET_ALL_EMP_STAT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_EMP_STAT", null);
            DAL.Close();
            return Dt;
        }
        
        public void INSERT_EMP(

            string empName,
            string empNid,
            string empNidIssue,
            string empSex,
            string empRelation,
            DateTime empDoB,
            string empPoB,
            string empAddress,
            string empPhone,
            string empEmail,
            byte[] empImage,
            string empJobId,
            DateTime empDoH,
            int empJobTit,
            int empJobStat,
            int DirId,
            DateTime empDoD,
            string empGrad,
            string empGradTitle,
            string empGradSpec,
            string empGradAccSpec,
            int ID,
            int DepTypeId,
            int empDep)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] InsertEmpParam = new SqlParameter[24];
            InsertEmpParam[0] = new SqlParameter("@empName", SqlDbType.VarChar, 50)
            {
                Value = empName
            };
            InsertEmpParam[1] = new SqlParameter("@empNid", SqlDbType.VarChar, 50)
            {
                Value = empNid
            };
            InsertEmpParam[2] = new SqlParameter("@empNidIssue", SqlDbType.VarChar, 50)
            {
                Value = empNidIssue
            };
            InsertEmpParam[3] = new SqlParameter("@empSex", SqlDbType.VarChar, 50)
            {
                Value = empSex
            };
            InsertEmpParam[4] = new SqlParameter("@empRelation", SqlDbType.VarChar, 50)
            {
                Value = empRelation
            };
            InsertEmpParam[5] = new SqlParameter("@empDoB", SqlDbType.Date)
            {
                Value = empDoB
            };
            InsertEmpParam[6] = new SqlParameter("@empPoB", SqlDbType.VarChar, 50)
            {
                Value = empPoB
            };
            InsertEmpParam[7] = new SqlParameter("@empAddress", SqlDbType.VarChar, 50)
            {
                Value = empAddress
            };
            InsertEmpParam[8] = new SqlParameter("@empPhone", SqlDbType.VarChar, 50)
            {
                Value = empPhone
            };
            InsertEmpParam[9] = new SqlParameter("@empEmail", SqlDbType.VarChar, 50)
            {
                Value = empEmail
            };
            InsertEmpParam[10] = new SqlParameter("@empImage", SqlDbType.Image)
            {
                Value = empImage
            };
            InsertEmpParam[11] = new SqlParameter("@empJobId", SqlDbType.VarChar, 50)
            {
                Value = empJobId
            };
            InsertEmpParam[12] = new SqlParameter("@empDoH", SqlDbType.Date)
            {
                Value = empDoH
            };
            InsertEmpParam[13] = new SqlParameter("@empJobTit", SqlDbType.VarChar, 50)
            {
                Value = empJobTit
            };
            InsertEmpParam[14] = new SqlParameter("@empJobStat", SqlDbType.Int)
            {
                Value = empJobStat
            };
            InsertEmpParam[15] = new SqlParameter("@DirId", SqlDbType.Int)
            {
                Value = DirId
            };
            InsertEmpParam[16] = new SqlParameter("@empDoD", SqlDbType.Date)
            {
                Value = empDoD
            };
            
            InsertEmpParam[17] = new SqlParameter("@empGrad", SqlDbType.VarChar, 50)
            {
                Value = empGrad
            };
            InsertEmpParam[18] = new SqlParameter("@empGradTitle", SqlDbType.VarChar, 50)
            {
                Value = empGradTitle
            };
            InsertEmpParam[19] = new SqlParameter("@empGradSpec", SqlDbType.VarChar, 50)
            {
                Value = empGradSpec
            };
            InsertEmpParam[20] = new SqlParameter("@empGradAccSpec", SqlDbType.VarChar, 50)
            {
                Value = empGradAccSpec
            };
            InsertEmpParam[21] = new SqlParameter("@ID", SqlDbType.Int)
            {
                Value = ID
            };
            InsertEmpParam[22] = new SqlParameter("@DepTypeId", SqlDbType.Int)
            {
                Value = DepTypeId
            };
            InsertEmpParam[23] = new SqlParameter("@empDep", SqlDbType.Int)
            {
                Value = empDep
            };

            DAL.ExecuteCommand("ADD_EMP", InsertEmpParam);
            DAL.Close();
        }

        public void UPDATE_EMPLOYEE(

            string empId,
          string empName,
          string empNid,
          string empNidIssue,
          string empSex,
          string empRelation,
          DateTime empDoB,
          string empPoB,
          string empAddress,
          string empPhone,
          string empEmail,
          byte[] empImage,
          string empJobId,
          DateTime empDoH,
          int empJobTit,
          int empJobStat,
          int DirId,
          DateTime empDoD,
          string empGrad,
          string empGradTitle,
          string empGradSpec,
          string empGradAccSpec,
          int ID,
          int DepTypeId,
          int empDep)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] EmployeeParam = new SqlParameter[25];
            EmployeeParam[0] = new SqlParameter("@empName", SqlDbType.VarChar, 50)
            {
                Value = empName
            };
            EmployeeParam[1] = new SqlParameter("@empNid", SqlDbType.VarChar, 50)
            {
                Value = empNid
            };
            EmployeeParam[2] = new SqlParameter("@empNidIssue", SqlDbType.VarChar, 50)
            {
                Value = empNidIssue
            };
            EmployeeParam[3] = new SqlParameter("@empSex", SqlDbType.VarChar, 50)
            {
                Value = empSex
            };
            EmployeeParam[4] = new SqlParameter("@empRelation", SqlDbType.VarChar, 50)
            {
                Value = empRelation
            };
            EmployeeParam[5] = new SqlParameter("@empDoB", SqlDbType.Date)
            {
                Value = empDoB
            };
            EmployeeParam[6] = new SqlParameter("@empPoB", SqlDbType.VarChar, 50)
            {
                Value = empPoB
            };
            EmployeeParam[7] = new SqlParameter("@empAddress", SqlDbType.VarChar, 50)
            {
                Value = empAddress
            };
            EmployeeParam[8] = new SqlParameter("@empPhone", SqlDbType.VarChar, 50)
            {
                Value = empPhone
            };
            EmployeeParam[9] = new SqlParameter("@empEmail", SqlDbType.VarChar, 50)
            {
                Value = empEmail
            };
            EmployeeParam[10] = new SqlParameter("@empImage", SqlDbType.Image)
            {
                Value = empImage
            };
            EmployeeParam[11] = new SqlParameter("@empJobId", SqlDbType.VarChar, 50)
            {
                Value = empJobId
            };
            EmployeeParam[12] = new SqlParameter("@empDoH", SqlDbType.Date)
            {
                Value = empDoH
            };
            EmployeeParam[13] = new SqlParameter("@empJobTit", SqlDbType.VarChar, 50)
            {
                Value = empJobTit
            };
            EmployeeParam[14] = new SqlParameter("@empJobStat", SqlDbType.Int)
            {
                Value = empJobStat
            };
            EmployeeParam[15] = new SqlParameter("@DirId", SqlDbType.Int)
            {
                Value = DirId
            };
            EmployeeParam[16] = new SqlParameter("@empDoD", SqlDbType.Date)
            {
                Value = empDoD
            };

            EmployeeParam[17] = new SqlParameter("@empGrad", SqlDbType.VarChar, 50)
            {
                Value = empGrad
            };
            EmployeeParam[18] = new SqlParameter("@empGradTitle", SqlDbType.VarChar, 50)
            {
                Value = empGradTitle
            };
            EmployeeParam[19] = new SqlParameter("@empGradSpec", SqlDbType.VarChar, 50)
            {
                Value = empGradSpec
            };
            EmployeeParam[20] = new SqlParameter("@empGradAccSpec", SqlDbType.VarChar, 50)
            {
                Value = empGradAccSpec
            };
            EmployeeParam[21] = new SqlParameter("@ID", SqlDbType.Int)
            {
                Value = ID
            };
            EmployeeParam[22] = new SqlParameter("@DepTypeId", SqlDbType.Int)
            {
                Value = DepTypeId
            };
            EmployeeParam[23] = new SqlParameter("@empDep", SqlDbType.Int)
            {
                Value = empDep
            };
            EmployeeParam[24] = new SqlParameter("@empId", SqlDbType.VarChar, 50)
            {
                Value = empDep
            };

            DAL.ExecuteCommand("UPDATE_EMP", EmployeeParam);
            DAL.Close();
        }
    }
    
}

