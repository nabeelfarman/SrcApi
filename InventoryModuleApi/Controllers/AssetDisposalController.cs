using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using InventoryModuleAPI.Services;
using InventoryModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using InventoryModuleAPI.Configuration;
using Dapper;
using System.IO;
using System.Linq;

namespace InventoryModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AssetDisposalController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public AssetDisposalController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }
    }
}