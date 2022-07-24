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
    public class SocietyBlockController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public SocietyBlockController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getSocietyBlock")]
        public IActionResult getSocietyBlock()
        {
            try
            {
                cmd = "select * from view_SocietyBlocks_39";
                var appModule = dapperQuery.Qry<SocietyBlock>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveSocietyBlock")]
        public IActionResult saveSocietyBlock(SocietyBlockCreation obj)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_SocietyBlocksCRUD", obj, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}