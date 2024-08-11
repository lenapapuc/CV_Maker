using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   
    public class Responsibility : BaseClass
    {
        public string Description { get; set; }
        public Experience Experience { get; set; }
        public Guid ExperienceId { get; set; }
    }
}
