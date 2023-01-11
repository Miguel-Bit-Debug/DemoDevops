using Domain.Commands.AddProduct;
using Domain.InputModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductInputModel inputModel)
        {
            var command = new AddProductCommand(inputModel.ProductName,
                                                inputModel.Description);

            var result = await _mediator.Send(command);

            if(result == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
