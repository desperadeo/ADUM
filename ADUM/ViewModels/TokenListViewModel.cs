using ADUM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.ViewModels
{
    public class TokenListViewModel
    {
        public IEnumerable<Token> Tokens { get; set; }
    }
}
