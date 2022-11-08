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
    public class LocationRepository:IStorageLocation
    {
        readonly MAFDbContext _dbContext = new();
        public LocationRepository(MAFDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ms_storage_location> GetListstorage()
        {
            try
            {
                return _dbContext.ms_storage_location.ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
