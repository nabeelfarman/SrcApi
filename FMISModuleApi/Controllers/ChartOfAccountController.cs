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
    public class ChartOfAccountController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public ChartOfAccountController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getChartOfAccount")]
        public IActionResult getChartOfAccount()
        {
            try
            {

                cmd = "select * from view_ChartofAccount_5";
                var appModule = dapperQuery.Qry<ChartOfAccount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getChartOfAccountLevel1")]
        public IActionResult getChartOfAccountLevel1()
        {
            try
            {

                cmd = "select * from view_ChartofAccount_Level1_26";
                var appModule = dapperQuery.Qry<COALevel123>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getChartOfAccountLevel2")]
        public IActionResult getChartOfAccountLevel2()
        {
            try
            {

                cmd = "select * from view_ChartofAccount_level2_27";
                var appModule = dapperQuery.Qry<COALevel123>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getChartOfAccountLevel3")]
        public IActionResult getChartOfAccountLevel3()
        {
            try
            {

                cmd = "select * from view_ChartofAccount_level3_28";
                var appModule = dapperQuery.Qry<COALevel123>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getChartOfAccountLevels")]
        public IActionResult getChartOfAccountLevels()
        {
            try
            {

                cmd = "select * from view_ChartofAccountLevels_13";
                var appModule = dapperQuery.Qry<COALevels>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveChartOfAccount")]
        public IActionResult saveChartOfAccount(ChartOfAccountCreation plots)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_ChartofAccountCRUD", plots, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}