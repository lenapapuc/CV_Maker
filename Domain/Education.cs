using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Education : BaseClass
    {
        public string Title { get; set; }
        public string Organisation { get; set; }
        public Address Address { get; set; }
        public  DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
