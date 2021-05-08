using Microsoft.Extensions.Hosting;

namespace OpenAPI_DbCommon
{
    /// <summary>
    /// 
    /// </summary>
    public class Program 
    { 
        static void Main(string[] args) => OpenAPI_Base.Program.CreateHostBuilder<Startup>(args).Build().Run(); 
    }
}
