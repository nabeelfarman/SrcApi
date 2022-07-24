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
    public class VoucherController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public VoucherController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getVoucherDetail")]
        public IActionResult getVoucherDetail(string trnID)
        {
            try
            {

                cmd = "select * from view_VoucherDetail_34  where trnId = " + trnID + ";";
                var appModule = dapperQuery.Qry<VoucherDetail>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getVoucher")]
        public IActionResult getVoucher()
        {
            try
            {

                cmd = "select * from view_tempVOucherDetail_35";
                var appModule = dapperQuery.Qry<Vouchers>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getVoucherType")]
        public IActionResult getVoucherType()
        {
            try
            {

                cmd = "select * from transactionTypes";
                var appModule = dapperQuery.Qry<TrnType>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveVoucher")]
        public IActionResult saveVoucher(VoucherCreation obj)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_Trndetail", obj, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }
    }
}