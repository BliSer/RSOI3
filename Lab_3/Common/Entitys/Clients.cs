using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Client
    {
        public int id;
        public string name;
        public string address;
        public string email;

        public Client()
        {
        }

        public Client(int id, string name, string address, string email)
        {   this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;
        }
    }
}
