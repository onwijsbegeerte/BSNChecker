using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSNChecker.ConsoleApp;
using Microsoft.AspNetCore.Mvc;

namespace fastWebapi.Controllers
{
    [Route("api/[controller]")]
    public class BSNController : Controller
    {
        private readonly IBSNValidator _bsnValidator;
        public BSNController(IBSNValidator bsnValidator)
        {
            this._bsnValidator = bsnValidator;
        }

        // GET api/BSN/5
        [HttpGet("{BsnNumber}")]
        public bool Get(string BsnNumber)
        {
            Console.WriteLine(BsnNumber);
            var result = _bsnValidator.Validate(BsnNumber);
            return result;
        }
    }
}
