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
    public class tr_bpkbController : ControllerBase
    {
        private readonly MAFDbContext _mafdbcontext;
        public IConfiguration _configuration;
        private readonly ITrbpkb _ITrbpkb;
        public tr_bpkbController(ITrbpkb ITrbpkb, MAFDbContext mafdbcontext, IConfiguration config)
        {
            _ITrbpkb = ITrbpkb;
            _mafdbcontext = mafdbcontext;
            _configuration = config;
        }

        [HttpGet]
        [Route("get-tr_bpkb")]
        public async Task<ActionResult<IEnumerable<tr_bpkb>>> Gettr_bpkbAsync()
        {
            return await Task.FromResult(_ITrbpkb.GetListTrbpkb());

        }
        [HttpPost]
        [Route("InsertTrbpkb")]
        public async Task<ActionResult<tr_bpkb>> Posttr_bpkb(tr_bpkb tr_bpkb)
        {

            _ITrbpkb.AddTrbpkb(tr_bpkb);
            //return await Task.FromResult(CreatedAtAction("GetEmployees", new { id = employee.EmployeeID }, employee));
            return await Task.FromResult(tr_bpkb);
        }

    }
}
