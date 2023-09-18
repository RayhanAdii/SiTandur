using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiTandurApp
{
    internal class User
    {
        private int _userID;
        private string _emailUser;
        private string _passwordUser;
        private bool _isAdmin;

        public int UserID 
        { 
            get { return _userID; } 
        }

        public string EmailUser
        {
            get { return _emailUser; }
            set { _emailUser = value; }
        }

        public string PasswordUser
        {
            get { return _passwordUser; }
            set { _passwordUser = value; }
        }

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public Boolean Login(String emailUser, String passwordUser)
        {
            // Ini nanti diganti menyesuaikan GUI dan Database
            // Bau bau diganti sangat kuat wkwkkw

            if (emailUser == "sayaadmin@gmail.com" & passwordUser == "qwerty")
            {
                _isAdmin = true;
                return true;
            }else if (emailUser == "sayapetani@gmail.com" & passwordUser == "nandurismylife")
            {
                _isAdmin = false;
                return false;
            }
            else
            {
                return false;
            }


            
        }
    }
}
