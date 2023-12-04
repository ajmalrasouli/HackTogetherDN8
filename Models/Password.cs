using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PasswordStoreApp.Models
{
    public class Password
    {
        public int Id { get; set; } 
        public string Site { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Note { get; set; }
        public Password()
        {

        }
    }
}
