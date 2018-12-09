using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class Admin
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        public DataTable Login()
        {
            BusinessAccess BA = new BusinessAccess
            {
                AdminObj = this
            };

            return BA.SelectAdmin();
        }
    }
}
