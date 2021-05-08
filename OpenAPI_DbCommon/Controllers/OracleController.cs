using Microsoft.AspNetCore.Components;

namespace OpenAPI_DbCommon.Controllers
{
    using OracleClient;
    [Route("[controller]/[action]")]
    public class OracleController : Code.DbCommonController<OracleClient> { }
}
