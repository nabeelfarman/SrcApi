using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
// using CMISModuleAPI.Models;
using CMISModuleAPI.Services;
using CMISModuleAPI.Entities;
using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;
using CMISModuleAPI.Configuration;
using Dapper;
using System.IO;

namespace CMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public CompanyController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getCompany")]
        public IActionResult getCompany()
        {
            try
            {
                cmd = "select * from View_companies";
                var appModule = dapperQuery.Qry<Company>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getPartner")]
        public IActionResult getPartner()
        {
            try
            {
                cmd = "select * from View_Partners";
                var appModule = dapperQuery.Qry<Partner>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCompanyType")]
        public IActionResult getCompanyType()
        {
            try
            {
                cmd = "select * from View_companyType";
                var appModule = dapperQuery.Qry<CompanyType>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCountry")]
        public IActionResult getCountry()
        {
            try
            {
                cmd = "select * from View_Countries";
                var appModule = dapperQuery.Qry<Country>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getCity")]
        public IActionResult getCity(int countryId)
        {
            try
            {
                if (countryId == 0)
                {
                    cmd = "select * from View_Cities";
                }
                else
                {
                    cmd = "select * from View_Cities where countryId = " + countryId + ";";
                }

                var appModule = dapperQuery.Qry<City>(cmd, _dbCon);
                return Ok(appModule);

            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getDesignation")]
        public IActionResult getDesignation()
        {
            try
            {
                cmd = "select * from View_Designation";
                var appModule = dapperQuery.Qry<Designation>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("saveCompany")]
        public IActionResult saveCompany(CompanyCreation company)
        {
            try
            {

                var response = dapperQuery.SPReturn("SP_companyCRUD", company, _dbCon);

                if (company.path != null)
                {
                    dapperQuery.saveImage(
                        company.registrationDoc,
                        company.shortName,
                        company.path);
                }

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePartner")]
        public IActionResult savePartner(PartnerCreation partner)
        {
            try
            {

                var response = dapperQuery.SPReturn("SP_PartnerCRUD", partner, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}