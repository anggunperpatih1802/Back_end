using MAFCoreCallWebAPI.Models;
using MAFCoreCallWebAPI.Helpers;
using MAFCoreCallWebAPI.Services.Interfaces;

namespace MAFCoreCallWebAPI.Services
{

    public class ServiceSaveloc: ISaveLocService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/get-liststorage";

        public ServiceSaveloc(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ms_storage_location>> Getstoragelocation()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<IEnumerable<ms_storage_location>>();
        }

    }
}
