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
using System.Linq;

namespace SocietyModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CheckListController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public CheckListController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getCheckList")]
        public IActionResult getCheckList()
        {
            try
            {
                cmd = "select * from view_AllChecklists_11";
                var appModule = dapperQuery.Qry<CheckList>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCheckListType")]
        public IActionResult getCheckListType()
        {
            try
            {
                cmd = "select * from view_ChecklistTypes_13";
                var appModule = dapperQuery.Qry<CheckListType>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveCheckList")]
        public IActionResult saveCheckList(CheckListCreation checkList)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_checkListsCRUD", checkList, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}