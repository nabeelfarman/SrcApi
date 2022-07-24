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
    public class PlotNatureController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotNatureController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPlotNature")]
        public IActionResult getPlotNature()
        {
            try
            {
                cmd = "select * from View_PlotNatures";
                var appModule = dapperQuery.Qry<PlotNature>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotNature")]
        public IActionResult savePlotNature(PlotNatureCreation plotNature)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_PlotNatureCRUD", plotNature, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}