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
    public class PlotFileController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotFileController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPlotFile")]
        public IActionResult getPlotFile(int plotID)
        {
            try
            {
                if (plotID == 0)
                {
                    cmd = "select * from View_PlotFilesAll_07";
                }
                else
                {
                    cmd = "select * from View_PlotFilesAll_07 where plotFileID = " + plotID + "";
                }
                var appModule = dapperQuery.Qry<PlotFile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotFile")]
        public IActionResult savePlotFile(PlotFileCreation plotFile)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_plotFileCRUD", plotFile, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}