using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;

namespace UMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserRoleController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public UserRoleController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getRoles")]
        public IActionResult getRoles()
        {
            try
            {
                cmd = "SELECT roleId, roleTItle, roleDescription FROM dbo.roles";
                var appModule = dapperQuery.Qry<Roles>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getAppModule")]
        public IActionResult getAppModule()
        {
            try
            {
                cmd = "select * from view_application_modules";
                var appModule = dapperQuery.Qry<AppModule>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }


        [HttpPost("getTotalRole")]
        public IActionResult getTotalRole(TotalRole userRole)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_LoadMenuListAll_Roles_WOParent", userRole, _dbCon);
                // var response = dapperQuery.SPReturn("sp_LoadMenuListAll_Roles", userRole, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getRoleOption")]
        public IActionResult getRoleOption()
        {
            try
            {
                cmd = "select * from view_roles_options";
                var appModule = dapperQuery.Qry<RoleOption>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getApplicationMenu")]
        public IActionResult getApplicationMenu()
        {
            try
            {
                cmd = "select * from view_applicationMenu";
                var appModule = dapperQuery.Qry<ApplicationMenu>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveRole")]
        public IActionResult saveRole(UserRole userRole)
        {
            try
            {
                var response = dapperQuery.SPReturn("Sp_RoleDetailNEW", userRole, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}
