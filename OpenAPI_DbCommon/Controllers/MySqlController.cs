using Microsoft.AspNetCore.Components;

using OpenAPI_DbCommonBase.Controllers;

namespace OpenAPI_DbCommon.Controllers
{
    using MySqlClient;

    [Route("[controller]/[action]")]
    public class MySqlController : DbCommonController<MySqlClient> { }
}
