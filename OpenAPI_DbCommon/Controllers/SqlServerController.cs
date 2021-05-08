using Microsoft.AspNetCore.Components;

namespace OpenAPI_DbCommon.Controllers
{
    using SqlServerClient;
    [Route("[controller]/[action]")]
    public class SqlServerController : Code.DbCommonController<SqlServerClient> { }
}
