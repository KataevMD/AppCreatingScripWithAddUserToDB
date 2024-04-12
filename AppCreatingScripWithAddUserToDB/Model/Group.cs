using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCreatingScripWithAddUserToDB.Model
{
    public class Group
    {
        private string _TitleGroup;
        private int _NumberPeopleInGroup;

        private List<Account> Accounts;

        public Group(string titleGroup, int numberPeopleInGroup)
        {
            _TitleGroup = titleGroup;
            _NumberPeopleInGroup = numberPeopleInGroup;
        }

        public void CreateAccountGroup()
        {
            if (_NumberPeopleInGroup > 0)
            {
                for (int i = 1; i <= _NumberPeopleInGroup; i++)
                {
                    Account account = new Account(_TitleGroup+"-"+i);
                    Accounts.Add(account);
                }         
            }  
        }

        public void SaveToFileScript()
        {

        }
    }
}
