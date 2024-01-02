using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.App.UseCases.CreateUser;
using CleanArch.App.UseCases.DeleteUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArch.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) 
        {
          _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<CreateUserRequest>> Create(CreateUserRequest request, 
                                                                    CancellationToken cancellationToken)
        {
          var validator = new CreateUserValidator();
          var validationResult = await validator.ValidateAsync(request, cancellationToken);

          if(!validationResult.IsValid) return BadRequest(validationResult.Errors);
  
          var response = await _mediator.Send(request, cancellationToken);
          return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteUserRequest>> Delete(Guid? id,
                                                                    CancellationToken cancellationToken)
        {
          if(id is null) return BadRequest();
          var deleteUserRequest = new DeleteUserRequest(id.Value);
          var response = await _mediator.Send(deleteUserRequest, cancellationToken);
          return Ok(response);
       } 
    }
}