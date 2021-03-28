using ADUM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Repository
{
    public class MookTokenRepository : ITokenRepository
    {
        public IEnumerable<Token> GetAllTokens()
        {
            return new List<Token>()
            {
                new Token{Id=1,SamAccountName="dan",ADGroup="G_INF_ADM",StartTime=new DateTime(2021,03,15,08,04,14),ExpiredTime=new DateTime(2021,03,15,08,04,14),Status=0},
                new Token{Id=1,SamAccountName="dan",ADGroup="G_INF_ADM",StartTime=new DateTime(2021,03,15,08,04,14),ExpiredTime=new DateTime(2021,03,15,08,04,14),Status=0},
                new Token{Id=1,SamAccountName="dan",ADGroup="G_INF_ADM",StartTime=new DateTime(2021,03,15,08,04,14),ExpiredTime=new DateTime(2021,03,15,08,04,14),Status=0}
            };
        }

        public Token GetEventById(int id)
        {
            return GetAllTokens().FirstOrDefault(t => t.Id == id);
        }
    }
}
