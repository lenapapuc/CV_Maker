using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Address : BaseClass
    {
        public string AddressLine { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set;}
    }
}
