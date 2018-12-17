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
            SqlParameter[] parameters = new SqlParameter[14];
            parameters[0] = DataAccess.AddParameter("@cardsName", CardsObj.CardsName);
            parameters[1] = DataAccess.AddParameter("@themeIndex", CardsObj.ThemeIndex);
            parameters[2] = DataAccess.AddParameter("@actualCardBG", CardsObj.ActualCardBG);
            parameters[3] = DataAccess.AddParameter("@actualCardTextColor", CardsObj.ActualCardTextColor);
            parameters[4] = DataAccess.AddParameter("@cardsFontFamily", CardsObj.CardsFontFamily);
            parameters[5] = DataAccess.AddParameter("@cardHolderDisplay", CardsObj.CardHolderDisplay);
            parameters[6] = DataAccess.AddParameter("@cardHolderPadding", CardsObj.CardHolderPadding);
            parameters[7] = DataAccess.AddParameter("@cardHeadBG", CardsObj.CardHeadBG);
            parameters[8] = DataAccess.AddParameter("@cardHeadPadding", CardsObj.CardHeadPadding);
            parameters[9] = DataAccess.AddParameter("@workAreaDisplay", CardsObj.WorkAreaDisplay);
            parameters[10] = DataAccess.AddParameter("@cardBodyDisplay", CardsObj.CardBodyDisplay);
            parameters[11] = DataAccess.AddParameter("@cardFooterTextAlign", CardsObj.CardFooterTextAlign);
            parameters[12] = DataAccess.AddParameter("@cardFooterBorderTop", CardsObj.CardFooterBorderTop);
            parameters[13] = DataAccess.AddParameter("@cardFooterPaddingTop", CardsObj.CardFooterPaddingTop);

            DataTable dt = DataAccess.ExecuteDTByProcedure("ADD_NEW_CARDS", parameters);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable SelectAllCardIDs()
        {
            DataTable dt = DataAccess.ExecuteDTByProcedure("SELECT_ALL_CARD_IDs", null);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable SelectCardValuesByID(string cardID)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = DataAccess.AddParameter("@cardId", cardID);
            DataTable dt = DataAccess.ExecuteDTByProcedure("SELECT_CARD_VALUES_BY_ID", parameters);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable ModifyCardsByID(string cardId)
        {
            SqlParameter[] parameters = new SqlParameter[14];
            parameters[0] = DataAccess.AddParameter("@cardId", cardId);
            parameters[1] = DataAccess.AddParameter("@cardName", CardsObj.CardsName);
            parameters[2] = DataAccess.AddParameter("@themeIndex", CardsObj.ThemeIndex);
            parameters[3] = DataAccess.AddParameter("@actualCardBG", CardsObj.ActualCardBG);
            parameters[4] = DataAccess.AddParameter("@actualCardTextColor", CardsObj.ActualCardTextColor);
            parameters[5] = DataAccess.AddParameter("@cardHolderDisplay", CardsObj.CardHolderDisplay);
            parameters[6] = DataAccess.AddParameter("@cardHolderPadding", CardsObj.CardHolderPadding);
            parameters[7] = DataAccess.AddParameter("@cardHeadBG", CardsObj.CardHeadBG);
            parameters[8] = DataAccess.AddParameter("@cardHeadPadding", CardsObj.CardHeadPadding);
            parameters[9] = DataAccess.AddParameter("@workAreaDisplay", CardsObj.WorkAreaDisplay);
            parameters[10] = DataAccess.AddParameter("@cardBodyDisplay", CardsObj.CardBodyDisplay);
            parameters[11] = DataAccess.AddParameter("@cardFooterTextAlign", CardsObj.CardFooterTextAlign);
            parameters[12] = DataAccess.AddParameter("@cardFooterBorderTop", CardsObj.CardFooterBorderTop);
            parameters[13] = DataAccess.AddParameter("@cardFooterPaddingTop", CardsObj.CardFooterPaddingTop);

            DataTable dt = DataAccess.ExecuteDTByProcedure("MODIFY_CARD_BY_ID", parameters);

            return dt == null ? new DataTable() : dt;
        }

        public DataTable DelectCardById(string cardID)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = DataAccess.AddParameter("@cardId", cardID);
            DataTable dt = DataAccess.ExecuteDTByProcedure("DELETE_CARD_BY_ID", parameters);

            return dt == null ? new DataTable() : dt;
        }
    }
}
