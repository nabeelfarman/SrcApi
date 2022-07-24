using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using FMISModuleAPI.Services;
using FMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using FMISModuleAPI.Configuration;
using Dapper;
using System.IO;

namespace FMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SubGroupController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public SubGroupController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getSubGroup")]
        public IActionResult getSubGroup()
        {
            try
            {

                cmd = "select * from view_SubGroup_8";
                var appModule = dapperQuery.Qry<SubGroups>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}