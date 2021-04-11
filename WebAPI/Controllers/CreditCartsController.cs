using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCartsController : ControllerBase
    {
        ICreditCartService _creditCartService;
        public CreditCartsController(ICreditCartService creditCartService)
        {
            _creditCartService = creditCartService;
        }
        [HttpGet("getbycartid")]
        public IActionResult GetCreditCartById(int id)
        {
            var result = _creditCartService.GetCreditCartById(id);

            return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCart creditCart)
        {
            var result = _creditCartService.Add(creditCart);

            return Ok(result);

            return BadRequest(result);
        }
    }
}
