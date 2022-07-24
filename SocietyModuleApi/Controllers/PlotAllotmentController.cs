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
    public class PlotAllotmentController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotAllotmentController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPlotAllotment")]
        public IActionResult getPlotAllotment()
        {
            try
            {
                cmd = "select * from View_plots_05";
                var appModule = dapperQuery.Qry<PlotAllotment>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotAllotment")]
        public IActionResult savePlotAllotment(PlotAllotmentCreation obj)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_PlotsCRUD", obj, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}