using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using FMISModuleAPI.Services;
using FMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using FMISModuleAPI.Configuration;
using Dapper;
using System.IO;

namespace FMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LedgerController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public LedgerController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpPost("generateReport")]
        public IActionResult generateReport(Ledger ledger)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_ledger", ledger, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}