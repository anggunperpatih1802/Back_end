using WebApiCoreWithEF.Models;

namespace WebApiCoreWithEF.Interface
{
    public interface ITrbpkb
    {
        public List<tr_bpkb> GetListTrbpkb();
        public void AddTrbpkb(tr_bpkb tr_bpkb);

    }
}
