using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LandModuleAPI.Services;
using LandModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using LandModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace LandModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LandPlotController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public LandPlotController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getLandPlot")]
        public IActionResult getLandPlot()
        {
            try
            {
                cmd = "select * from View_plots_05";
                var appModule = dapperQuery.Qry<LandPlot>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveLandPlot")]
        public IActionResult saveLandPlot(LandPlotCreation obj)
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