using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SkillCategory : BaseClass
    {
        public string Name { get; set; }
        public List<Skill> Skill { get; set; }
    }
}
