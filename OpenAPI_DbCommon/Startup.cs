namespace OpenAPI_DbCommon
{
    using Microsoft.OpenApi.Models;
    public class Startup : OpenAPI_Base.Startup
    {
        /// <summary>
        /// 
        /// </summary>
        protected override void Init() => base.Init();
        /// <summary>
        /// 
        /// </summary>
        protected override bool AlwaysUseSwaggerUI => base.AlwaysUseSwaggerUI;
        /// <summary>
        /// 
        /// </summary>
        protected override string Name => nameof(OpenAPI_DbCommon);
        /// <summary>
        /// 
        /// </summary>
        protected override OpenApiInfo OpenApiInfo => new()
        {
            Title = nameof(OpenAPI_DbCommon),
            Version = "1.0.0.0",
        };
    }
}
