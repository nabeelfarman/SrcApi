using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using HRMISModuleAPI.Services;
using HRMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using HRMISModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace HRMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DesignationController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public DesignationController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getDesignation")]
        public IActionResult getDesignation()
        {
            try
            {
                cmd = "select * from tblDesignations";
                var appModule = dapperQuery.Qry<Designation>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}