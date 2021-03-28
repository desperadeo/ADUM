using ADUM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Repository
{
    public class TokenRepository : ITokenRepository
    {
        private readonly AppDbContext _appDbContext;

        public TokenRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Token> GetAllTokens()
        {
            return _appDbContext.Tokens;
        }

        public Token GetEventById(int id)
        {
            return _appDbContext.Tokens.FirstOrDefault(t => t.Id == id);
        }
    }
}
