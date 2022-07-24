using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using InventoryModuleAPI.Services;
using InventoryModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using InventoryModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace InventoryModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class InventoryDashboardController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public InventoryDashboardController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getTotalTagCount")]
        public IActionResult getTotalTagCount()
        {
            try
            {
                cmd = "select * from view_TotalTagsCountforDASHBOARD";
                var appModule = dapperQuery.Qry<InventoryDashboardCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCondemnedAssetCount")]
        public IActionResult getCondemnedAssetCount()
        {
            try
            {
                cmd = "select * from VIEW_CondenmedAssetsCount_DASHBOARD";
                var appModule = dapperQuery.Qry<InventoryDashboardCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCategoryWiseTagCount")]
        public IActionResult getCategoryWiseTagCount()
        {
            try
            {
                cmd = "select * from view_CategoryWiseTagsCountforDashBoard";
                var appModule = dapperQuery.Qry<InventoryDashboardCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getSectionWiseTag")]
        public IActionResult getSectionWiseTag()
        {
            try
            {
                cmd = "select * from view_SectionWiseTotaltags_DASHBOARD";
                var appModule = dapperQuery.Qry<InventoryDashboardCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getAccountCatWiseTagCount")]
        public IActionResult getAccountCatWiseTagCount()
        {
            try
            {
                cmd = "select * from View_AccountCategoryWiseTagsCountforDASHBOARD_PIVOT";
                var appModule = dapperQuery.Qry<AccountCatWiseTagCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}