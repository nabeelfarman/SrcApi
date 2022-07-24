using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using System.Collections.Generic;
using Dapper;

namespace UMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserCreationController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private IUserService _userService;

        public UserCreationController(IUserService userService, IOptions<conStr> dbCon)
        {
            _userService = userService;
            _dbCon = dbCon;
        }

        [HttpPost("saveUserCreation")]
        public IActionResult saveUserCreation(UserCreation userCreation)
        {
            try
            {
                var response = dapperQuery.SPReturn("SP_loginCRUD", userCreation, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpDelete("deactiveUser")]
        public IActionResult deactiveUser(int loginId)
        {
            try
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@userLoginId", loginId);
                var response = dapperQuery.SPReturn("sp_deActivateUser", parameter, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }
    }
}