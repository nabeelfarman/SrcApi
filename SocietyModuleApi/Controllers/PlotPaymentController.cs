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

namespace SocietyModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlotPaymentController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotPaymentController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPlotPayment")]
        public IActionResult getPlotPayment()
        {
            try
            {
                cmd = "select * from View_PaymentNatures_04";
                var appModule = dapperQuery.Qry<PlotPayment>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotPayment")]
        public IActionResult savePlotPayment(PlotPaymentCreation plotPayment)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_PaymentNatureCRUD", plotPayment, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}