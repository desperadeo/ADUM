using ADUM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Repository
{
    public interface ITokenRepository
    {
        IEnumerable<Token> GetAllTokens();
        Token GetEventById(int id);
    }
}
