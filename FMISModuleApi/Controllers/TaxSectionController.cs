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
    public class TaxSectionController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public TaxSectionController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getTaxSection")]
        public IActionResult getTaxSection()
        {
            try
            {

                cmd = "select * from view_TaxSections_11";
                var appModule = dapperQuery.Qry<TaxSection>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTaxSectionDetail")]
        public IActionResult getTaxSectionDetail()
        {
            try
            {

                cmd = "select * from view_TaxSectionsDetail_12";
                var appModule = dapperQuery.Qry<TaxSectionDetail>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}