using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    //enum TypeDocument
    //{
    //    0 = Dni;
    //}
    public class aePerson
    {
        public int IdPerson { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
        public string NroDocument { get; set; }
        public string Correo { get; set; }
        // public aeUser User { get; set; }
        // public aePerson(aeUser pUser)
        // {
        //     User = pUser;
        //     //this = daPerson.GetData(pUser.IdPersona);
        // }
        public aePerson(string pNombre,string pApellidos)
        {
            FirtsName = pNombre;
            LastName = pApellidos;
        }
        public aePerson()
        {

        }
        
    }
}
