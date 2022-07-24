using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LandModuleAPI.Services;
using LandModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using LandModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace LandModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LandOwnerController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public LandOwnerController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getLandOwner")]
        public IActionResult getLandOwner()
        {
            try
            {
                cmd = "select * from view_landOwnerAll_103";
                var appModule = dapperQuery.Qry<LandOwner>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveLandOwner")]
        public IActionResult saveLandOwner(LandOwnerCreation land)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_landOwnerCRUD", land, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}