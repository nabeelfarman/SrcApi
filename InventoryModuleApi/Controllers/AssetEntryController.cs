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
    public class AssetEntryController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public AssetEntryController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getCustodian")]
        public IActionResult getCustodian()
        {
            try
            {
                cmd = "select * from Parhrmis.dbo.view_AllEmployees_1 where memberType = 'employee'";
                var appModule = dapperQuery.Qry<Custodian>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getAssets")]
        public IActionResult getAssets()
        {
            try
            {
                cmd = "select * from View_Assets";
                var appModule = dapperQuery.Qry<Assets>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTagsPrint")]
        public IActionResult getTagsPrint()
        {
            try
            {
                cmd = "select * from VIEW_tagsforprints";
                var appModule = dapperQuery.Qry<TagsPrint>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveAsset")]
        public IActionResult saveAsset(AssetCreation obj)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_AssetsCRUD", obj, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}