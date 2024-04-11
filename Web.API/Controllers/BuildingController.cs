using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly BuildingService _service;



        //[HttpPost]
        //public Task<IActionResult<Building>> Create([FromBody] CreateBuildingRequest request, CancellationToken token)
        //{
        //    _service.CreateAsync(  request)
        //}
    }
}
