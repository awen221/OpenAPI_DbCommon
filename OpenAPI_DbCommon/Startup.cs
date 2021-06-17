namespace OpenAPI_DbCommon
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.OpenApi.Models;
    public class Startup : OpenAPI_Base.Startup
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) => base.Configure(app, env);
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
