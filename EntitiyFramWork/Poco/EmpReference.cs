using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntitiyFramWork.Poco
{
    public class EmpReference
    {
        [Key]
        public int ReferenceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        [MaxLength(50)]
        public string Alias { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        //[ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
    }
}
