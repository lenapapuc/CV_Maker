using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class СV : BaseClass
    {
        public UserInfo UserInfo { get; set; }
        public List<Experience>? Experience { get; set; }
        public List<Education>?  Education { get; set; }
        public List<Skill>? Skills { get; set; }

    }
}
