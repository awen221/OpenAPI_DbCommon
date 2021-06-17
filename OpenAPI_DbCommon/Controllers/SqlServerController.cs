﻿using Microsoft.AspNetCore.Components;

using OpenAPI_DbCommonBase.Controllers;

namespace OpenAPI_DbCommon.Controllers
{
    using SqlServerClient;
    [Route("[controller]/[action]")]
    public class SqlServerController : DbCommonController<SqlServerClient> { }
}
