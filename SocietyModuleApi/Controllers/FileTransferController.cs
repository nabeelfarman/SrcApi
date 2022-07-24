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
    public class FileTransferController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public FileTransferController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getTransferInProcess")]
        public IActionResult getTransferInProcess()
        {
            try
            {
                cmd = "select * from view_Transfers_19";
                var appModule = dapperQuery.Qry<TransferInProcess>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTransferMember")]
        public IActionResult getTransferMember(int transferID)
        {
            try
            {
                cmd = "select * from view_Transfers_memberProfiles_28 where transferId = " + transferID + ";";
                var appModule = dapperQuery.Qry<TransferMemberInProcess>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTransferSavedMember")]
        public IActionResult getTransferSavedMember()
        {
            try
            {
                cmd = "select * from view_Transfers_SAVED_memberProfiles_29";
                var appModule = dapperQuery.Qry<TransferMemberSaved>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveTransferComplete")]
        public IActionResult saveTransferComplete(TransferCreation transfer)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_TransfersCRUD", transfer, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}