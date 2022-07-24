using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
// using CMISModuleAPI.Models;
using CMISModuleAPI.Services;
using CMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using CMISModuleAPI.Configuration;
using Dapper;
using System.IO;

namespace CMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SectionController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public SectionController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getSection")]
        public IActionResult getSection()
        {
            try
            {
                cmd = "select * from view_sections";
                var appModule = dapperQuery.Qry<Section>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveSection")]
        public IActionResult saveSection(SectionCreation sect)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_SectionsCRUD", sect, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}