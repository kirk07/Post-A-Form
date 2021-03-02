using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
{
    public class RegisterModel
    {
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Contact { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
