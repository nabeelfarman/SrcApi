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
    public class BudgetController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public BudgetController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getBudgetEstimate")]
        public IActionResult getBudgetEstimate()
        {
            try
            {

                cmd = "select * from view_budgetEstimates_21";
                var appModule = dapperQuery.Qry<BudgetEstimate>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBudgeteEstimateSummary")]
        public IActionResult getBudgeteEstimateSummary()
        {
            try
            {

                cmd = "select * from view_budgetEstimatesSummary_22";
                var appModule = dapperQuery.Qry<BudgetEstimateSummary>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}