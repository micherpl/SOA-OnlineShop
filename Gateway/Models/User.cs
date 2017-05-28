using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gateway.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
    }
}