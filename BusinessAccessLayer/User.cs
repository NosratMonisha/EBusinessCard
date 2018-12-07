using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class User
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public DataTable Login()
        {
            BusinessAccess BA = new BusinessAccess
            {
                UserObj = this
            };

            return BA.SelectUser();
        }

        public bool Registration()
        {
            BusinessAccess BA = new BusinessAccess
            {
                UserObj = this
            };

            BA.AddNewUser();

            return true;
        }
    }
}
