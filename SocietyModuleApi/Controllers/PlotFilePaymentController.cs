using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocietyModuleAPI.Services;
using SocietyModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using SocietyModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace SocietyModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlotFilePaymentController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotFilePaymentController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getAllBank")]
        public IActionResult getAllBank()
        {
            try
            {
                cmd = "select * from ParFMIS.dbo.View_AllBanks_3";
                var appModule = dapperQuery.Qry<AllBank>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getChartofAccount")]
        public IActionResult getChartofAccount()
        {
            try
            {
                cmd = "select * from ParFMIS.dbo.view_ChartOfAccount_forReceipt_4";
                var appModule = dapperQuery.Qry<ChartofAccount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getplotFilePayment")]
        public IActionResult getplotFilePayment()
        {
            try
            {
                cmd = "select * from view_fileplotPayments_31";
                var appModule = dapperQuery.Qry<PlotFilePayment>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getPlotFilePaymentSummary")]
        public IActionResult getPlotFilePaymentSummary(int plotFileID)
        {
            try
            {
                cmd = "select * from view_plotFilePayment_Nabeel_01 where plotFileID = " + plotFileID + " order by receiptDate desc";
                var appModule = dapperQuery.Qry<PlotFilePaymentSummary>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotFilePayment")]
        public IActionResult savePlotFilePayment(PlotFilePaymentCreation payment)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_plotFilePayments", payment, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}