using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Worker.Commands.CreateWorker;
using Application.Worker.Queries.GetAllWorkers;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<WorkerDTO>>> GetAllWorkers()
        {
            var result = await _mediator.Send(new GetAllWorkersQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Create([FromBody] CreateWorkerCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}