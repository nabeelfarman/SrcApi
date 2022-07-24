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
    public class InPersonController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public InPersonController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getActiveMemberPlotFile")]
        public IActionResult getActiveMemberPlotFile(int plotID)
        {
            try
            {
                if (plotID > 0)
                {
                    cmd = "select * from View_ActiveMembersPLotFile_23 where plotFileId = " + plotID + "";
                }
                else
                {
                    cmd = "select * from View_ActiveMembersPLotFile_23";
                }
                var appModule = dapperQuery.Qry<ActiveMemberPlotFile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInPersonMemberPlotFile")]
        public IActionResult getInPersonMemberPlotFile()
        {
            try
            {
                cmd = "select * from view_Inperson_transfersFileNos_27";
                var appModule = dapperQuery.Qry<InPersonMemberPlotFile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTransferMemberProfile")]
        public IActionResult getTransferMemberProfile(int plotID)
        {
            try
            {
                cmd = "select * from view_Transfers_memberProfiles_28 where plotFileId = " + plotID + "";
                var appModule = dapperQuery.Qry<TransferMemberProfile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInPerson")]
        public IActionResult getInPerson()
        {
            try
            {
                cmd = "select * from view_InPerson_17";
                var appModule = dapperQuery.Qry<InPerson>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInPersonNotAct")]
        public IActionResult getInPersonNotAct()
        {
            try
            {
                cmd = "select * from view_inPersonNOTActivated_26";
                var appModule = dapperQuery.Qry<InPersonNotAct>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInPersonCareOff")]
        public IActionResult getInPersonCareOff(int inPersonId)
        {
            try
            {
                cmd = "select * from view_inPersonCareoff_25 where inPersonId = " + inPersonId + "";
                var appModule = dapperQuery.Qry<CareOff>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveInPerson")]
        public IActionResult saveInPerson(InPersonCreation inPerson)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_InPersonCRUD", inPerson, _dbCon);
                var data = response.Select(row => new { res = row.ToString() });
                bool result = data.First().res.Contains("Success");

                if (result == true && (inPerson.memberPicturePath != null && inPerson.memberPicturePath != "" && inPerson.memberPicturePath != "null"))
                {

                    var inPersonId = data.First().res.Split("|||")[1];

                    dapperQuery.saveImageFile(
                        inPerson.memberPicture,
                        inPersonId,
                        inPerson.memberPicturePath,
                        inPerson.memberPictureExtension);
                }

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveInPersonCareOff")]
        public IActionResult saveInPersonCareOff(CareOffCreation careOff)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_InPersonCareOffCRUD", careOff, _dbCon);

                if (careOff.attorneyPath != null && careOff.attorneyPath != "" && careOff.attorneyPath != "null")
                {

                    var data = response.Select(row => new { res = row.ToString() });

                    var careOffId = data.First().res.Split("|||")[1];

                    dapperQuery.saveImageFile(
                        careOff.attorney,
                        careOffId,
                        careOff.attorneyPath,
                        careOff.attorneyExtension);
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