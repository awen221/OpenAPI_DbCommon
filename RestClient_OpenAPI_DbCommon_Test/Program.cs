using RestClient_OpenAPI_DbCommon;

namespace RestClient_OpenAPI_DbCommon_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "";        //依實際需要賦值
            string connectString = "";  //依實際需要賦值
            string commandText = "";    //依實際需要賦值

            var response = new DbCommonClient(baseUrl).SqlServer.DataAdapter_Fill_DataTable(connectString, commandText);
        }
    }
}
