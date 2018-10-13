using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitiyFramWork.Poco
{
    public class SkillsInfo
    {
        [Key]
        public int SkillInfoId { get; set; }

        [MaxLength(250)]
        public string URL { get; set; }

        //[ForeignKey("SkillId")]
        public int SkillId { get; set; }

    }
}
