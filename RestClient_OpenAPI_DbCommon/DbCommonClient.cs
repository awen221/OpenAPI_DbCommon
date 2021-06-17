using System.Data;

using RestSharp;
using Newtonsoft.Json;

using OpenAPI_DbCommonBase.Code;

namespace RestClient_OpenAPI_DbCommon
{
    public class DbCommonClient
    {
        string BaseUrl { get; } = string.Empty;
        public DbCommonClient(string baseUrl) { BaseUrl = baseUrl; }

        public class DbCommon
        {
            string BaseAddress { set; get; }
            string controller { set; get; }
            public DbCommon(string baseAdder, string controllerName)
            {
                BaseAddress = baseAdder;
                controller = controllerName;
            }


            TResult Process<TResult>(string ConnectionString, string CommandText, string action)
            {
                RestClient restClient = new RestClient(BaseAddress);
                RestRequest restRequest = new RestRequest($"/{controller}/{action}", Method.POST, DataFormat.Json);

                restRequest.AddParameter(nameof(IDbCommonArgs_interface.ConnectionString), ConnectionString);
                restRequest.AddParameter(nameof(IDbCommonArgs_interface.CommandText), CommandText);

                var response = restClient.Execute(restRequest);
                
                return JsonConvert.DeserializeObject<TResult>(response.Content);
            }
            public DataSet DataAdapter_Fill_DataSet(string ConnectionString, string CommandText)
                => Process<DataSet>(ConnectionString, CommandText, nameof(DataAdapter_Fill_DataSet));
            public DataTable DataAdapter_Fill_DataTable(string ConnectionString, string CommandText)
                => Process<DataTable>(ConnectionString, CommandText, nameof(DataAdapter_Fill_DataTable));
            public bool DataReader_HasRows(string ConnectionString, string CommandText)
                => Process<bool>(ConnectionString, CommandText, nameof(DataReader_HasRows));
            public int ExecuteNonQuery(string ConnectionString, string CommandText)
                => Process<int>(ConnectionString, CommandText, nameof(ExecuteNonQuery));
        }

        public DbCommon SqlServer => new DbCommon(BaseUrl, nameof(SqlServer));
        public DbCommon MySql => new DbCommon(BaseUrl, nameof(MySql));
        public DbCommon Oracle => new DbCommon(BaseUrl, nameof(Oracle));
    }
    
}
