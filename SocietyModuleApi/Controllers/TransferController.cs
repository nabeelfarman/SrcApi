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
    public class TransferController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public TransferController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getTransfer")]
        public IActionResult getTransfer()
        {
            try
            {
                cmd = "select * from view_Transfers_19";
                var appModule = dapperQuery.Qry<Transfer>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getTransferApplicant")]
        public IActionResult getTransferApplicant(int transferID)
        {
            try
            {
                cmd = "select * from view_TransferApplicantDetail_20 where transferID = " + transferID + ";";
                var appModule = dapperQuery.Qry<TransferApplicant>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveTransfer")]
        public IActionResult saveTransfer(TransferCreation transfer)
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

        [HttpPost("saveTransferApplicant")]
        public IActionResult saveTransferApplicant(TransferApplicantCreation transferApplicant)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_TransferApplicantADD_CRUD", transferApplicant, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}