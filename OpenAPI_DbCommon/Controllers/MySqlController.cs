using Microsoft.AspNetCore.Components;

namespace OpenAPI_DbCommon.Controllers
{
    using MySqlClient;
    [Route("[controller]/[action]")]
    public class MySqlController : Code.DbCommonController<MySqlClient> { }
}
