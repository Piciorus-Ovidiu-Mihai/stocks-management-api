using Microsoft.AspNetCore.Mvc;

namespace StocksManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
    }
}
