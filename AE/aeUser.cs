using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeUser :  aePerson
    {
        public aeUser()
        {

        }
        public aeUser(string pUser, string pPassword)
        {
            Alias = pUser;
            Password = pPassword;
        }
        public int IdUser { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public bool Estate { get; set; }
        public string RowVersion { get; set; }
        public List<aeRole> ListRoles { get; set; }
        public List<aeMenu> MenusGranted { get; set; }
        public List<aeMenu> MenusDenegated { get; set; }

    }
}
