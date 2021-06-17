using Microsoft.AspNetCore.Components;

using OpenAPI_DbCommonBase.Controllers;

namespace OpenAPI_DbCommon.Controllers
{
    using OracleClient;

    [Route("[controller]/[action]")]
    public class OracleController : DbCommonController<OracleClient> { }
}
