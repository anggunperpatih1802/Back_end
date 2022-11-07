namespace WebApiCoreWithEF.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ms_storage_location
    {
        [Key]
        public string location_id { get; set; }
        public string location_name { get; set; }

    }
}
