using System.ComponentModel.DataAnnotations;

namespace OpenAPI_DbCommonBase.Code
{
    public class DbCommonArgs : IDbCommonArgs_interface
    {
        [Required]
        public string ConnectionString { get; set; }
        [Required]
        public string CommandText { get; set; }
    }
}
