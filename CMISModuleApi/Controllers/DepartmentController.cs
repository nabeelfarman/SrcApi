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
    public class DepartmentController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public DepartmentController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getDepartment")]
        public IActionResult getDepartment()
        {
            try
            {
                cmd = "select * from view_Departments";
                var appModule = dapperQuery.Qry<Department>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveDepartment")]
        public IActionResult saveDepartment(DepartmentCreation dept)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_DepartmentCRUD", dept, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}