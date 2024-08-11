using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Skill : BaseClass
    {
        public string Name {  get; set; }
        public SkillCategory Category { get; set; }
        public Guid CategoryId {  get; set; }
        public List<СV>? CVs { get; set; }
    }
}
