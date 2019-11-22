using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Managment_AHO.BL
{
    class ClassUserParam
    {
        private static int userId;
        private static string userName;
        private static string userPassword;
        private static string userType;

        public static int UserId { get => userId; set => userId = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string UserPassword { get => userPassword; set => userPassword = value; }
        public static string UserType { get => userType; set => userType = value; }
    }
}
