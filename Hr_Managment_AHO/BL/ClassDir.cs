using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassDir
    {

        public DataTable GET_ALL_DIR()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DIR", null);
            DAL.Close();
            return Dt;
        }

    }
}
