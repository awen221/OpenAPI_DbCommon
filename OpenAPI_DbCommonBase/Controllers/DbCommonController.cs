using System.Data;
using Microsoft.AspNetCore.Mvc;

using DbClient;

namespace OpenAPI_DbCommonBase.Controllers
{
    using Code;

    [Route("[controller]/[action]")]
    [ApiController]
    public class DbCommonController<T_Db> : Controller where T_Db : IDb_interface, new()
    {
        protected virtual DbCommonArgs ProcessDbCommonArgs(DbCommonArgs args) => args;

        [HttpPost]
        public DataTable DataAdapter_Fill_DataTable([FromForm]DbCommonArgs args)
        {
            args = ProcessDbCommonArgs(args);

            return new T_Db().DataAdapter_Fill_DataTable(args.ConnectionString, args.CommandText);
        }
        [HttpPost]
        public DataSet DataAdapter_Fill_DataSet([FromForm] DbCommonArgs args)
        {
            args = ProcessDbCommonArgs(args);

            return new T_Db().DataAdapter_Fill_DataSet(args.ConnectionString, args.CommandText);
        }
        [HttpPost]
        public bool DataReader_HasRows([FromForm] DbCommonArgs args)
        {
            args = ProcessDbCommonArgs(args);

            return new T_Db().DataReader_HasRows(args.ConnectionString, args.CommandText);
        }
        [HttpPost]
        public int ExecuteNonQuery([FromForm] DbCommonArgs args)
        {
            args = ProcessDbCommonArgs(args);

            return new T_Db().ExecuteNonQuery(args.ConnectionString, args.CommandText);
        }
    }
}
