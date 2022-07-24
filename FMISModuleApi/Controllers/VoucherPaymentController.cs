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
    public class VoucherPaymentController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public VoucherPaymentController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getUnpaidTransaction")]
        public IActionResult getUnpaidTransaction()
        {
            try
            {

                cmd = "select * from view_UnpaidTransactions_6";
                var appModule = dapperQuery.Qry<UnpaidTransaction>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBankAccountCheqBook")]
        public IActionResult getBankAccountCheqBook()
        {
            try
            {

                cmd = "select * from view_bankAccountChequebooks_19";
                var appModule = dapperQuery.Qry<BankAccountCheqBook>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBankAccountCheqBookCheqNo")]
        public IActionResult getBankAccountCheqBookCheqNo()
        {
            try
            {

                cmd = "select * from view_BankAccountChequeBookChequeNos_20";
                var appModule = dapperQuery.Qry<BankAccountCheqBookCheqNo>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePayment")]
        public IActionResult savePayment(VoucherPaymentCreation trans)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_TransactionPayment", trans, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}