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
    public class BudgetHeadController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public BudgetHeadController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getBudgetSubCode")]
        public IActionResult getBudgetSubCode()
        {
            try
            {

                cmd = "select * from view_BudgetSubCodes_10";
                var appModule = dapperQuery.Qry<Budget>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBudgetMainCode")]
        public IActionResult getBudgetMainCode()
        {
            try
            {

                cmd = "select * from view_BudgetMainCodes_9";
                var appModule = dapperQuery.Qry<Budget>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        // [HttpPost("saveBudgetHead")]
        // public IActionResult saveBudgetHead(ExternalPartiesCreation parties)
        // {
        //     try
        //     {

        //         var response = dapperQuery.SPReturn("sp_ExternalPartyCRUD", parties, _dbCon);

        //         return Ok(response);
        //     }
        //     catch (Exception e)
        //     {
        //         return Ok(e);
        //     }

        // }

    }
}