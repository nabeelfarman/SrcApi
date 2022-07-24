using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
// using CMISModuleAPI.Models;
using CMISModuleAPI.Services;
using CMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using CMISModuleAPI.Configuration;
using Dapper;
using System.IO;

namespace CMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public BranchController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getBranch")]
        public IActionResult getBranch()
        {
            try
            {
                cmd = "select * from view_branches";
                var appModule = dapperQuery.Qry<Branch>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getBranchSection")]
        public IActionResult getBranchSection()
        {
            try
            {
                cmd = "select * from view_branchSections";
                var appModule = dapperQuery.Qry<BranchSection>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveBranch")]
        public IActionResult saveBranch(BranchCreation branch)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_branchCRUD", branch, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveBranchSection")]
        public IActionResult saveBranchSection(BranchSectionCreation brnchSec)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_branchSectionsCRUD", brnchSec, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}