using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using UMISModuleApi.dto.response;

namespace UMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private string cmd;
        private readonly IOptions<conStr> _dbCon;

        public UserController(IUserService userService, IOptions<conStr> dbCon)
        {
            _userService = userService;
            _dbCon = dbCon;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);
            if (response == null)
                return BadRequest(new { message = "user name or password is incorrect" });

            return Ok(response);
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            try
            {
                cmd = "select * from view_users";
                var appMenu = dapperQuery.Qry<UserForList>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCompanyLogo")]
        public IActionResult getCompanyLogo()
        {
            try
            {
                cmd = "select * from srcCompany.dbo.View_companies";
                var appMenu = dapperQuery.Qry<Company>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getUserDesignation")]
        public IActionResult getUserDesignation()
        {
            try
            {
                cmd = "select * from view_user_designation";
                var appMenu = dapperQuery.Qry<UserDesignation>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("verifyPin")]
        public IActionResult verifyPin(VerifyPin pin)
        {
            try
            {
                var response = dapperQuery.SPReturn("SP_verifyPin", pin, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}