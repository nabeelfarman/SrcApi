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
    public class ExternalPartiesController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public ExternalPartiesController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getExternalParties")]
        public IActionResult getExternalParties()
        {
            try
            {

                cmd = "select * from view_ExternalParties_24";
                var appModule = dapperQuery.Qry<ExternalParties>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveExternalParties")]
        public IActionResult saveExternalParties(ExternalPartiesCreation parties)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_ExternalPartyCRUD", parties, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}