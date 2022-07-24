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

namespace SocietyModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MemberPlotFileController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public MemberPlotFileController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getMemberApplicant")]
        public IActionResult getMemberApplicant(int plotID)
        {
            try
            {
                if (plotID == 0)
                {
                    cmd = "select * from view_member_ApplicantProfile_18";
                }
                else
                {
                    cmd = "select * from view_member_ApplicantProfile_18 where plotFileId = " + plotID + "";
                }
                var appModule = dapperQuery.Qry<MemberApplicantProfile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getAcquisitionType")]
        public IActionResult getAcquisitionType()
        {
            try
            {
                cmd = "select * from acquistionTypes";
                var appModule = dapperQuery.Qry<AcquisitionType>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }
        [HttpGet("getMemberEDoc")]
        public IActionResult getMemberEDoc(int plotFileID)
        {
            try
            {
                cmd = "select * from membersFilesGroup where plotFileId = " + plotFileID + " and applicationEDoc is not Null";

                var appModule = dapperQuery.Qry<MemberPlotEDoc>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getMemberPlotFile")]
        public IActionResult getMemberPlotFile(int memberID, string page)
        {
            try
            {
                if (page == "memberFile")
                {
                    cmd = "select * from View_memberFiles_08 where plotFileID = '" + memberID + "' order by isActivated desc";
                }
                else
                {
                    cmd = "select * from View_memberFiles_08 where memberProfileId= '" + memberID + "' order by isActivated desc";
                }

                var appModule = dapperQuery.Qry<MemberPlotFile>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getMemberFileXml")]
        public IActionResult getMemberFileXml()
        {
            try
            {
                cmd = "select * from View_memberFiles_XML_10";

                var appModule = dapperQuery.Qry<MemberFileXml>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveMemberPlotFile")]
        public IActionResult saveMemberPlotFile(MemberPlotFileCreation memPlotFile)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_membersFilesGroupCRUD", memPlotFile, _dbCon);

                if (memPlotFile.applicationEDocPath != null && memPlotFile.applicationEDocPath != "")
                {
                    dapperQuery.saveImageFile(
                        memPlotFile.applicationEDoc,
                        memPlotFile.plotFileId.ToString(),
                        memPlotFile.applicationEDocPath,
                        memPlotFile.applicationEdocExtenstion);
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