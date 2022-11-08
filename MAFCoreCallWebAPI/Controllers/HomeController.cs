using MAFCoreCallWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using MAFCoreCallWebAPI.Services;
using MAFCoreCallWebAPI.Services.Interfaces;

namespace MAFCoreCallWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISaveLocService _service;
        //private readonly Itrbkpbservice _service2;

        public HomeController(ISaveLocService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> Index(string submit,tr_bpkb tr_bpkb)
        {
            var storage_Locations = await _service.Getstoragelocation();
            IEnumerable<ms_storage_location> storage_Locations2 = storage_Locations;
            ViewBag.storage_Locations = storage_Locations2.AsEnumerable();
            if ((submit!=null)&& (submit.ToUpper()=="SAVE"))
            {
                //tr_bpkb newtrbpkb = new tr_bpkb();
                tr_bpkb.agreement_number = Request.Form["agree_no"].ToString().Trim();
                tr_bpkb.faktur_date = System.Convert.ToDateTime(Request.Form["faktur_date"]);
                tr_bpkb.branch_id = Request.Form["branch_id"].ToString().Trim();
                tr_bpkb.bpkb_no = Request.Form["nobpkb"].ToString().Trim();
                tr_bpkb.location_id = Request.Form["saveloc"].ToString().Trim();
                tr_bpkb.bpkb_date_in = System.Convert.ToDateTime(Request.Form["bpkb_date_in"]);
                tr_bpkb.bpkb_date = System.Convert.ToDateTime(Request.Form["bpkb_Date"]);

                tr_bpkb.faktur_no = Request.Form["fakturno"].ToString().Trim();
                tr_bpkb.faktur_date = System.Convert.ToDateTime(Request.Form["faktur_date"]);
                //var trbpkb = await _service2.insertbpkb(tr_bpkb);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7174/api/InsertTrbpkb");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<tr_bpkb>("tr_bpkb", tr_bpkb);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

    }
}