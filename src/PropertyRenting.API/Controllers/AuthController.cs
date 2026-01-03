using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PropertyRenting.Application.Users.Commands;
using PropertyRenting.Application.Users.DTOs;

namespace PropertyRenting.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register (RegisterUserDto dto)
        {
            var id = await _mediator.Send(new RegisterUserCommand(dto));
            return Ok(new { userId = id });
        }
    }
}