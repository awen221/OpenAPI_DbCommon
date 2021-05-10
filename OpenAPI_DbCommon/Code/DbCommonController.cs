using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using DbClient;

namespace OpenAPI_DbCommon.Code
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DbCommonController<T_Db> : Controller
        where T_Db : Db_interface, new()
    {
        [HttpPost]
        public string DataAdapter_Fill_DataTable([FromForm]DbCommonArgs args)
        {
            var result = new T_Db().DataAdapter_Fill_DataTable(args.ConnectionString, args.CommandText);
            var JsonString = JsonConvert.SerializeObject(result);
            return JsonString;
        }
        [HttpPost]
        public string DataAdapter_Fill_DataSet([FromForm] DbCommonArgs args)
        {
            var result = new T_Db().DataAdapter_Fill_DataSet(args.ConnectionString, args.CommandText);
            var JsonString = JsonConvert.SerializeObject(result);
            return JsonString;
        }
        [HttpPost]
        public bool DataReader_HasRows([FromForm] DbCommonArgs args)
        {
            return new T_Db().DataReader_HasRows(args.ConnectionString, args.CommandText);
        }
        [HttpPost]
        public int ExecuteNonQuery([FromForm] DbCommonArgs args)
        {
            return new T_Db().ExecuteNonQuery(args.ConnectionString, args.CommandText);
        }
    }
}
