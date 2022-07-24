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
    public class AssetCategoryController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public AssetCategoryController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getAccountCategory")]
        public IActionResult getAccountCategory()
        {
            try
            {
                cmd = "select * from View_AccountsCategories";
                var appModule = dapperQuery.Qry<AccountCategory>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }
        [HttpGet("getAssetCategory")]
        public IActionResult getAssetCategory()
        {
            try
            {
                cmd = "select * from view_AssetCategories";
                var appModule = dapperQuery.Qry<AssetCategory>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveAssetCategory")]
        public IActionResult saveAssetCategory(AssetCategoryCreation obj)
        {
            try
            {

                var response = dapperQuery.SPReturn("Sp_AssetCatagoriesCRUD", obj, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}