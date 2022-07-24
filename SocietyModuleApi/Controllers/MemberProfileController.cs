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
    public class MemberProfileController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public MemberProfileController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getApplicantProfile")]
        public IActionResult getApplicantProfile()
        {
            try
            {
                cmd = "select * from View_applicantProfile_15";
                var appModule = dapperQuery.Qry<MemberProfile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getMemberProfile")]
        public IActionResult getMemberProfile(int plotID)
        {
            try
            {
                if (plotID == 0)
                {
                    cmd = "select * from View_memberProfile_09";
                }
                else
                {
                    cmd = "select * from View_memberProfile_09 where plotFileID = '" + plotID + "';";
                }

                var appModule = dapperQuery.Qry<MemberProfile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveMemberProfile")]
        public IActionResult saveMemberProfile(MemberProfileCreation memProfile)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_MemberprofileCRUD", memProfile, _dbCon);

                var data = response.Select(row => new { res = row.ToString() });

                var memberId = data.First().res.Split("|||")[1];

                if (memProfile.memberPicturePath != null && memProfile.memberPicturePath != "")
                {
                    dapperQuery.saveImageFile(
                        memProfile.memberPicture,
                        memberId,
                        memProfile.memberPicturePath,
                        memProfile.memberPictureExtension);
                }

                if (memProfile.applicationEDocPath != null && memProfile.applicationEDocPath != "")
                {
                    dapperQuery.saveImageFile(
                        memProfile.applicationEDoc,
                        memberId,
                        memProfile.applicationEDocPath,
                        memProfile.applicationEdocExtenstion);
                }

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}