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
        public Cards CardsObj { get; set; }
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

        public DataTable AddNewCards()
        {
            SqlParameter[] parameters = new SqlParameter[13];
            parameters[0] = DataAccess.AddParameter("@CardsName", CardsObj.CardsName);
            parameters[1] = DataAccess.AddParameter("@ActualCardBG", CardsObj.ActualCardBG);
            parameters[2] = DataAccess.AddParameter("@ActualCardTextColor", CardsObj.ActualCardTextColor);
            parameters[3] = DataAccess.AddParameter("@CardsFontFamily", CardsObj.CardsFontFamily);
            parameters[4] = DataAccess.AddParameter("@CardHolderDisplay", CardsObj.CardHolderDisplay);
            parameters[5] = DataAccess.AddParameter("@CardHolderPadding", CardsObj.CardHolderPadding);
            parameters[6] = DataAccess.AddParameter("@CardHeadBG", CardsObj.CardHeadBG);
            parameters[7] = DataAccess.AddParameter("@CardHeadPadding", CardsObj.CardHeadPadding);
            parameters[8] = DataAccess.AddParameter("@WorkAreaDisplay", CardsObj.WorkAreaDisplay);
            parameters[9] = DataAccess.AddParameter("@CardBodyDisplay", CardsObj.CardBodyDisplay);
            parameters[10] = DataAccess.AddParameter("@CardFooterTextAlign", CardsObj.CardFooterTextAlign);
            parameters[11] = DataAccess.AddParameter("@CardFooterBorderTop", CardsObj.CardFooterBorderTop);
            parameters[12] = DataAccess.AddParameter("@CardFooterPaddingTop", CardsObj.CardFooterPaddingTop);

            DataTable dt = DataAccess.ExecuteDTByProcedure("ADD_NEW_CARDS", parameters);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable SelectAllCardIDs()
        {
            DataTable dt = DataAccess.ExecuteDTByProcedure("SELECT_ALL_CARD_IDs", null);

            return dt == null ? new DataTable() : dt;
        }
    }
}
