namespace OpenAPI_DbCommon
{
    using Microsoft.OpenApi.Models;
    public class Startup : OpenAPI_Base.Startup
    {
        protected override string Name => nameof(OpenAPI_DbCommon);
        protected override OpenApiInfo OpenApiInfo => new OpenApiInfo()
        {
            Title = nameof(OpenAPI_DbCommon),
            Version = "1.0",
        };
    }
}
