using WebApiCoreWithEF.Interface;
using WebApiCoreWithEF.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Configuration;
namespace WebApiCoreWithEF.Repository
{
    public class TrbpkbRepository : ITrbpkb
    {
        readonly MAFDbContext _dbContext = new();

        public TrbpkbRepository(MAFDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<tr_bpkb> GetListTrbpkb()
        {
            try
            {
                return _dbContext.tr_bpkb.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddTrbpkb(tr_bpkb tr_bpkb)
        {
            try
            {
                _dbContext.tr_bpkb.Add(tr_bpkb);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
