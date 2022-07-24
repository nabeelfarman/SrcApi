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
    public class TransferInboxController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public TransferInboxController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getTransferInbox")]
        public IActionResult getTransferInbox(int userID)
        {
            try
            {
                cmd = "select * from view_TransferInbox_24 where userId = " + userID + ";";
                var appModule = dapperQuery.Qry<TransferInbox>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTransferApplicantDetail")]
        public IActionResult getTransferApplicantDetail(int transferID)
        {
            try
            {
                cmd = "select * from view_TransferApplicantDetail_20 where transferID = " + transferID + ";";
                var appModule = dapperQuery.Qry<TransferApplicantDetail>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getProcessCheckList")]
        public IActionResult getProcessCheckList(int transferID)
        {
            try
            {
                cmd = "select * from view_ProccessedChecklists_12 where TransferId = " + transferID + ";";
                var appModule = dapperQuery.Qry<ProcessCheckList>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInboxCount")]
        public IActionResult getInboxCount(int userID)
        {
            try
            {
                cmd = "select * from view_InboxCount_2 where userId = " + userID + ";";
                var appModule = dapperQuery.Qry<InboxCount>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveTransferInbox")]
        public IActionResult saveTransferInbox(TransferInboxCreation transfer)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_transferProcessCRUD", transfer, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveProceedChecklist")]
        public IActionResult saveProceedChecklist(ProceedChecklistCreation proceed)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_ProcessedChecklistCRUD", proceed, _dbCon);

                if (proceed.filePath != null && proceed.filePath != "")
                {

                    var data = response.Select(row => new { res = row.ToString() });

                    var proceedId = data.First().res.Split("|||")[1];

                    dapperQuery.saveImageFile(
                        proceed.filePath,
                        proceedId,
                        proceed.fileEdoc,
                        proceed.fileEdocExtension);
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