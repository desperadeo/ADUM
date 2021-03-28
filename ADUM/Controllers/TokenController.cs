using ADUM.Repository;
using ADUM.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Controllers
{
    public class TokenController : Controller
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenController(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }
        
        public IActionResult List()
        {
            var tokenListViewModel = new TokenListViewModel();
            //var tokens = _tokenRepository.GetAllTokens();
            tokenListViewModel.Tokens = _tokenRepository.GetAllTokens();
            return View(tokenListViewModel);
        }

        public IActionResult Past()
        {
            var tokenListViewModel = new TokenListViewModel();
            tokenListViewModel.Tokens = _tokenRepository.GetAllTokens();
            return View(tokenListViewModel);
        }

    }
}
