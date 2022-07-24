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
    public class BankAccountController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public BankAccountController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getBankAccount")]
        public IActionResult getBankAccount()
        {
            try
            {

                cmd = "select * from View_AllBanks_3";
                var appModule = dapperQuery.Qry<BankAccount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBankName")]
        public IActionResult getBankName()
        {
            try
            {

                cmd = "select * from view_bankNames_15";
                var appModule = dapperQuery.Qry<Banks>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBankChartOfAccount")]
        public IActionResult getBankChartOfAccount()
        {
            try
            {

                cmd = "select * from view_BankChartofAccount_16";
                var appModule = dapperQuery.Qry<BankChartOfAccount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBankType")]
        public IActionResult getBankType()
        {
            try
            {

                cmd = "select * from view_BankTypes_25";
                var appModule = dapperQuery.Qry<BanksType>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveBanks")]
        public IActionResult saveBanks(BankCreation plots)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_BankAccountsCRUD", plots, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}