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
    public class PlotCategoryController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PlotCategoryController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPlotCategory")]
        public IActionResult getPlotCategory()
        {
            try
            {
                cmd = "select * from View_plotCategories";
                var appModule = dapperQuery.Qry<PlotCategory>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePlotCategory")]
        public IActionResult savePlotCategory(PlotCategoryCreation plotCategory)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_PlotCategoryCRUD", plotCategory, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}