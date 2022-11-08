using MAFCoreCallWebAPI.Models;

namespace MAFCoreCallWebAPI.Services.Interfaces
{
    public interface ISaveLocService
    {
        Task<IEnumerable<ms_storage_location>> Getstoragelocation();
    }
}
