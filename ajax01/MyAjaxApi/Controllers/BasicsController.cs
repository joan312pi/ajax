using Microsoft.AspNetCore.Mvc;

namespace MyAjaxApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasicsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { message = "您好" });

}
