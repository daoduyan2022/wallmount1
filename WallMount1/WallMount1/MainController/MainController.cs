using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMount1.MainController
{
    
    class MainController
    {
        public string PASSWORD_SETUP = "123456";
        public string USER_SETUP = "User";
        
        

        public bool RequestPassword(string userNameEnter, string userNameCorrect, string passwordEnter, string passwordCorrect)
        {
            if(passwordEnter == passwordCorrect && userNameEnter == userNameCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    
    }
}
