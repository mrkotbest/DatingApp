using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // This route will be prefixed with "api/users" when the application is running
public class BaseApiController : ControllerBase
{

}
