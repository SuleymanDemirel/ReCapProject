using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService; // multi constructur izin verilmiyor..
        private IPaymentService _paymentService;
        public RentalsController(IRentalService rentalService, IPaymentService paymentService)
        {
            _rentalService = rentalService;
            _paymentService = paymentService; 
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallrental")]

        public IActionResult GetAllRental()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallrentaldetails")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbyid")]
        public IActionResult GetRentalById(int id)
        {
            var result = _rentalService.GetRentalById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentaldetailsbyid")]
        public IActionResult GetRentalDetailsDto(int id)
        {
            var result = _rentalService.GetRentalDetailsDto(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("paymentadd")]
        public ActionResult PaymentAdd(PaymentDetailDto paymentDetailDto)
        {
            var paymentResult = _paymentService.CreditPayment(paymentDetailDto.Payment);
            if (!paymentResult.Success)
            {
                return BadRequest(paymentResult);
            }
            var result = _rentalService.Add(paymentDetailDto.Rental);

            if (result.Success)
                return Ok(result);
            else
            {
                throw new System.Exception(result.Message);
            }
        }

    }
}
