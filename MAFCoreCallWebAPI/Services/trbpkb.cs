using MAFCoreCallWebAPI.Models;
using MAFCoreCallWebAPI.Helpers;
using MAFCoreCallWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace MAFCoreCallWebAPI.Services
{

    public class trbpkb : Itrbkpbservice
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/InsertTrbpkb";

        public trbpkb(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async void insertbpkb(IEnumerable<trbpkb> trbpkb)
        {
            var response = await _client.GetAsync(BasePath);
            //return await response<IEnumerable<trbpkb>>();

        }

    }
}
