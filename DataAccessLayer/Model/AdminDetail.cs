using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdminDetail
    {
        public string User_Id { get; set; }
        public string Password { get; set; }
        public string Email_Id { get; set; }

        public string status { get; set; }

        public string New_Email_Id { get; set; }

        public string Confirm_New_Password { get; set; }

    }
}
