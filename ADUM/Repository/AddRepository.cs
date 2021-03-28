using ADUM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Repository
{
    public class AddRepository : IAddRepository
    {
        private readonly AppDbContext _appDbContext;

        public AddRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void CreateToken(Token token)
        {
            token.StartTime = DateTime.Now;
            //token.SamAccountName = "Toan";
            token.Status = 1;
            token.ExpiredTime = DateTime.Now.AddMinutes(60);
            //token.ADGroup = "G_INF_RPD";
            _appDbContext.Tokens.Add(token);
            _appDbContext.SaveChanges();
        }
    }
}
