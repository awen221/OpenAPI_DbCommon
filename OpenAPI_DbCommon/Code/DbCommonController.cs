using System.Data;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using DbClient;

namespace OpenAPI_DbCommon.Code
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DbCommonController<T_Db> : Controller, Db_interface
        where T_Db : Db_interface, new()
    {
        [HttpPost]
        public object DataAdapter_Fill_DataTable(string connectString, string commandText)
        {
            var result = (DataTable)new T_Db().DataAdapter_Fill_DataTable(connectString, commandText);
            var resultJson = JsonConvert.SerializeObject(result);
            return Ok(resultJson);
        }
        [HttpPost]
        public object DataAdapter_Fill_DataSet(string connectString, string commandText)
        {
            var result = (DataSet)new T_Db().DataAdapter_Fill_DataSet(connectString, commandText);
            var resultJson = JsonConvert.SerializeObject(result);
            return Ok(resultJson);
        }
        [HttpPost]
        public object DataReader_HasRows(string connectString, string commandText)
        {
            var result = (bool)new T_Db().DataReader_HasRows(connectString, commandText);
            var resultJson = JsonConvert.SerializeObject(result);
            return Ok(resultJson);
        }
        [HttpPost]
        public object ExecuteNonQuery(string connectString, string commandText)
        {
            var result = (int)new T_Db().ExecuteNonQuery(connectString, commandText);
            var resultJson = JsonConvert.SerializeObject(result);
            return Ok(resultJson);
        }
    }
}
