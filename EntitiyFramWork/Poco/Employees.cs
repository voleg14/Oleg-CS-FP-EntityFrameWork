using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitiyFramWork.Poco
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Alias { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }


        public ICollection<EmpReference> EmpReferences { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
