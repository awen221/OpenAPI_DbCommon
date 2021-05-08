using RestSharp;

using DbClient;
using Newtonsoft.Json;
using System.Data;

namespace RestClient_OpenAPI_DbCommon
{
    public class DbCommonClient
    {
        string BaseUrl { get; } = string.Empty;
        public DbCommonClient(string baseUrl) { BaseUrl = baseUrl; }

        public class DbCommon : Db_interface
        {
            string BaseAddress { set; get; }
            string controller { set; get; }
            public DbCommon(string baseAdder, string controllerName)
            {
                BaseAddress = baseAdder;
                controller = controllerName;
            }

            object Process<TResult>(string connectString, string commandText, string action)
            {
                RestClient restClient = new RestClient(BaseAddress);
                RestRequest restRequest = new RestRequest($"/{controller}/{action}", Method.POST, DataFormat.Json);

                restRequest.AddQueryParameter(nameof(connectString), connectString);
                restRequest.AddQueryParameter(nameof(commandText), commandText);

                var response = restClient.Execute(restRequest);
                string str = JsonConvert.DeserializeObject<string>(response.Content);
                
                return JsonConvert.DeserializeObject<TResult>(str);
            }
            public object DataAdapter_Fill_DataSet(string connectString, string commandText)
                => Process<DataSet>(connectString, commandText, nameof(DataAdapter_Fill_DataSet));
            public object DataAdapter_Fill_DataTable(string connectString, string commandText)
                => Process<DataTable>(connectString, commandText, nameof(DataAdapter_Fill_DataTable));
            public object DataReader_HasRows(string connectString, string commandText)
                => Process<bool>(connectString, commandText, nameof(DataReader_HasRows));
            public object ExecuteNonQuery(string connectString, string commandText)
                => Process<int>(connectString, commandText, nameof(ExecuteNonQuery));
        }

        public DbCommon SqlServer => new DbCommon(BaseUrl, nameof(SqlServer));
        public DbCommon MySql => new DbCommon(BaseUrl, nameof(MySql));
        public DbCommon Oracle => new DbCommon(BaseUrl, nameof(Oracle));
    }
    
}
