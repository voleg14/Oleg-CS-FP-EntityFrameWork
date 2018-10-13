using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitiyFramWork.Poco
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        //[ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string SkillName { get; set; }

        public string BriefDescription { get; set; }

        public ICollection<SkillsInfo> skillsInfos { get; set; }
    }
}
