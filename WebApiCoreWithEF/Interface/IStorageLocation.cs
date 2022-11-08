using WebApiCoreWithEF.Models;

namespace WebApiCoreWithEF.Interface
{
    public interface IStorageLocation
    {
        public List<ms_storage_location> GetListstorage();

    }
}
