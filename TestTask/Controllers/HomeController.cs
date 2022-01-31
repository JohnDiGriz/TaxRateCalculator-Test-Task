using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Core.Interfaces;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITaxCalculationService _taxCalculationService;

        public HomeController(IUnitOfWork unitOfWork, ITaxCalculationService taxCalculationService)
        {
            _unitOfWork = unitOfWork;
            _taxCalculationService = taxCalculationService;
        }

        [HttpGet]
        [Route("/home/calculate")]
        public async Task<IActionResult> CalculateTax(string zipcode, string stateCode, string vehicleName)
        {
            try
            {
                return Ok(await _taxCalculationService.Calculate(zipcode, stateCode, vehicleName));
            }
            catch(ValidationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        //[HttpGet]
        //[Route("/home/getLog")]
        //public async Task<IActionResult> GetLog(string requestUrl)
        //{
        //    var res = new StringBuilder();
        //    using(var file = new StreamReader("log.txt"))
        //    {
        //        var line = String.Empty;
        //        while ((line = await file.ReadLineAsync()) != null)
        //        {
        //            if (line.Contains(requestUrl))
        //            {
        //                while ((line = await file.ReadLineAsync()) != null)
        //                {
        //                    if (line.Contains("|RESPONSE|"))
        //                    {
        //                        while(!(line = await file.ReadLineAsync()).Contains("|END|"))
        //                            res.Append(line);
        //                        break;
        //                    }
        //                }
        //                res.Append("|NEXT|");
        //            }
        //        }

        //    }
        //    return Ok(res.ToString());
        //}

        [HttpPatch]
        [Route("/home/editRate")]
        public async Task<IActionResult> EditRate(string stateCode, string vehicleName, double? newRate)
        {
            await _unitOfWork.Taxes.UpdateValidation(stateCode, vehicleName, newRate);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
