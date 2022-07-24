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
    public class PaymentPlanController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public PaymentPlanController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPaymentPlans")]
        public IActionResult getPaymentPlans(int plotCategoryID, int plotNatureID, int plotTypeID)
        {
            try
            {
                if (plotCategoryID == 0 && plotNatureID == 0 && plotTypeID == 0)
                {
                    cmd = "select * from View_paymentPlans_02";
                }
                else
                {
                    cmd = "select * from View_paymentPlans_02 where plotCategoryId = " + plotCategoryID + " AND plotNatureId = " + plotNatureID + " AND plotTypeId = " + plotTypeID + "";
                }

                var appModule = dapperQuery.Qry<PaymentPlan>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getPaymentNatures")]
        public IActionResult getPaymentNatures()
        {
            try
            {
                cmd = "select * from View_PaymentNatures_04";
                var appModule = dapperQuery.Qry<PaymentNature>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getInstallmentsHeader")]
        public IActionResult getInstallmentsHeader()
        {
            try
            {
                cmd = "select * from View_Installments_Headers_01";
                var appModule = dapperQuery.Qry<InstallmentHeader>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpGet("getPaymentPlanDetail")]
        public IActionResult getPaymentPlanDetail(int paymentPlanID)
        {
            try
            {
                cmd = "select * from View_PaymentPlanDetail_03 where paymentPlanId = " + paymentPlanID + ";";
                var appModule = dapperQuery.Qry<PaymentPlanDetail>(cmd, _dbCon);
                return Ok(appModule);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePaymentPlan")]
        public IActionResult savePaymentPlan(PaymentPlanCreation paymentPlan)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_paymentPlanCRUD", paymentPlan, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        [HttpPost("savePaymentPlanDetail")]
        public IActionResult savePaymentPlanDetail(PaymentPlanDetailCreation paymentPlan)
        {
            try
            {

                var response = dapperQuery.SPReturn("sp_paymentPlanDetailCRUD", paymentPlan, _dbCon);

                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}