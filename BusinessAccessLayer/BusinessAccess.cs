using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessAccessLayer
{
    public class BusinessAccess
    {
        public User UserObj { get; set; }
        public Admin AdminObj { get; set; }

        public void AddNewUser()
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = DataAccess.AddParameter("@username", UserObj.UserName);
            parameters[1] = DataAccess.AddParameter("@fullname", UserObj.FullName);
            parameters[2] = DataAccess.AddParameter("@password", UserObj.Password);
            parameters[3] = DataAccess.AddParameter("@email", UserObj.Email);
            parameters[4] = DataAccess.AddParameter("@address", UserObj.Address);
            parameters[5] = DataAccess.AddParameter("@dob", UserObj.DOB);
            parameters[6] = DataAccess.AddParameter("@phonenumber", UserObj.PhoneNumber);

            DataAccess.ExecuteDTByProcedure("ADD_NEW_USER", parameters);
        }

        public DataTable SelectUser()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = DataAccess.AddParameter("@username", UserObj.UserName);
            parameters[1] = DataAccess.AddParameter("@password", UserObj.Password);
            DataTable dt = DataAccess.ExecuteDTByProcedure("SELECT_USER_BY_USERNAME_N_PASSWORD", parameters);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable SelectAdmin()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = DataAccess.AddParameter("@username", AdminObj.UserName);
            parameters[1] = DataAccess.AddParameter("@password", AdminObj.Password);
            DataTable dt = DataAccess.ExecuteDTByProcedure("SELECT_ADMIN_BY_USERNAME_N_PASSWORD", parameters);

            return dt == null ? new DataTable() : dt;
        }
    }
}
