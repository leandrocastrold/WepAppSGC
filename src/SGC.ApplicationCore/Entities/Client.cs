using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entities
{
    public class Client
    {
        public Client()
        {

        }

        public int ClientID { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }

    }
}
