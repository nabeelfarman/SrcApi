using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using HRMISModuleAPI.Services;
using HRMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using HRMISModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace HRMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public EmployeeController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getEmployee")]
        public IActionResult getEmployee()
        {
            try
            {
                cmd = "select * from view_AllEmployees_1";
                var appModule = dapperQuery.Qry<Employee>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveEmployee")]
        public IActionResult saveEmployee(EmployeeCreation employee)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_EmployeeCRUD", employee, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}