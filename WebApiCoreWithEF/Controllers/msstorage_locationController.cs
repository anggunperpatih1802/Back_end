using Microsoft.AspNetCore.Mvc;
using WebApiCoreWithEF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using WebApiCoreWithEF.Interface;
namespace WebApiCoreWithEF.Controllers
{
    public class msstorage_locationController : ControllerBase
    {
        private readonly MAFDbContext _mafdbcontext;
        public IConfiguration _configuration;
        private readonly IStorageLocation _IStorageLocation;

        public msstorage_locationController(IStorageLocation IStorageLocation, MAFDbContext mafdbcontext, IConfiguration config)
        {
            _IStorageLocation = IStorageLocation;
            _mafdbcontext = mafdbcontext;
            _configuration = config;
        }
        [HttpGet]
        [Route("api/get-liststorage")]
        public async Task<ActionResult<List<ms_storage_location>>> Getstorage_locationAsync()
        {
            return await Task.FromResult(_IStorageLocation.GetListstorage());

        }

    }
}
