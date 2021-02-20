using EFSqlLogging.Log;
using Microsoft.AspNetCore.Mvc;

namespace EFSqlLogging.Controllers
{
    [ApiController]
    [Route("Sql")]
    public class SqlController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return SqlLogger.GenerateSqlStr();
        }
    }
}