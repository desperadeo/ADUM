using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Models
{
    public class ADUser
    {
        public int Id { get; set; }
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        public string Samaccountname { get; set; }
    }
}
