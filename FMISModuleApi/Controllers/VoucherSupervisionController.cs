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
    public class VoucherSupervisionController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public VoucherSupervisionController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getUnsupervisedTransaction")]
        public IActionResult getUnsupervisedTransaction(string voucherDate)
        {
            try
            {

                cmd = "select * from view_unSupervisedTransactions_23  where (trnDate = CONVERT(DATETIME, '" + voucherDate + "', 102))";
                var appModule = dapperQuery.Qry<UnsupervisedTransaction>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveTransaction")]
        public IActionResult saveTransaction(VoucherSuperviseCreation trans)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_TransactionSupervised", trans, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}