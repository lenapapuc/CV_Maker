using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Experience : BaseClass
    {
        public string Title { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Address Address { get; set; }
        public List<string> Responsiblities {  get; set; }
        public List<string> Skills {  get; set; }
    }
}
