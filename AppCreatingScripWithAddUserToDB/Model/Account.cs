using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCreatingScripWithAddUserToDB.Model
{
    public class Account
    {
        private string _Login;
        private string _Password;

        public Account(string login)
        {
            _Login = login;
            _Password = "Passw0rd";
        }
    }
}
