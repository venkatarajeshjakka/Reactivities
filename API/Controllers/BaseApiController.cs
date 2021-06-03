using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _meditor;

        protected IMediator Mediator => _meditor ??= HttpContext.RequestServices
        .GetService<IMediator>();
    }
}