using Application.Address.Queries;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<AddressDTO>>> GetAllAddresses()
        {
            var result = await _mediator.Send(new GetAllAddressQuery());

            return Ok(result);
        }
    }
}