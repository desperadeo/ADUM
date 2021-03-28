using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Models
{
    public class Token
    {
        [BindNever]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a SamAccountName")]
        [Display(Name = "Sam Account Name")]
        [StringLength(50, MinimumLength = 3)]
        public string SamAccountName { get; set; }

        [Required(ErrorMessage = "Enter an ADGroup")]
        [Display(Name = "AD Group")]
        [StringLength(50)]
        public string ADGroup { get; set; }

        [BindNever]
        public DateTime StartTime { get; set; }

        [BindNever]
        public DateTime ExpiredTime { get; set; }
        public int Status { get; set; }
    }
}
