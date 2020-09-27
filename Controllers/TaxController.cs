using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaxApp.Model;
using TaxApp.Service;

namespace TaxApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        readonly ITaxService _taxService;
        public TaxController(ITaxService taxService)
        {
            this._taxService = taxService;
        }

        [HttpPost]
        [Route("GetTax")]
        public async Task<IActionResult> GetTax([FromBody] TaxRequest taxRequest)
        {
            if (ModelState.IsValid)
                return Ok(await _taxService.GetTax(taxRequest));
            else
                return BadRequest(ModelState);
        }

        [HttpPost]
        [Route("AddTax")]
        public async Task<IActionResult> AddTax([FromBody] TaxEntity taxRequest)
        {
            if (ModelState.IsValid)
                return Ok(await _taxService.AddTax(taxRequest));
            else
                return BadRequest(ModelState);
        }

    }
}
