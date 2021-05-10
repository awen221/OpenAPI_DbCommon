using System.ComponentModel.DataAnnotations;

namespace OpenAPI_DbCommon.Code
{
    public class DbCommonArgs : DbCommonArgs_interface
    {
        [Required]
        public string ConnectionString { get; set; }
        [Required]
        public string CommandText { get; set; }
    }
}
