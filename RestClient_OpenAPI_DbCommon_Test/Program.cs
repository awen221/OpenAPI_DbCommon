using RestClient_OpenAPI_DbCommon;
using System;

namespace RestClient_OpenAPI_DbCommon_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "";        //依實際需要賦值
            string ConnectionString = "";  //依實際需要賦值
            string CommandText = "";    //依實際需要賦值
            try
            {
                var response = new DbCommonClient(baseUrl).SqlServer.DataAdapter_Fill_DataTable(ConnectionString, CommandText);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}
