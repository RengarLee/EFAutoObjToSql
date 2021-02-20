using EFAutoObjToSql.Log;
using Microsoft.AspNetCore.Mvc;

namespace EFAutoObjToSql.Controllers
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