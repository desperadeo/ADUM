using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.ViewModels
{
    public class StatusViewModel
    {
        public Int32 Status { get; set; }
        public List<SelectListItem> Pouet { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "0", Text = "KO"},
            new SelectListItem { Value = "1", Text = "OK"},
        };
    }
}
