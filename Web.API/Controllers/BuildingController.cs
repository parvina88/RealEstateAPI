using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingController : ControllerBase
    {
        private readonly IBaseService<Building> _buildingService;
        private readonly IMapper _mapper;

        public BuildingController(IBaseService<Building> buildingService, IMapper mapper)
        {
            _buildingService = buildingService;
            _mapper = mapper;
        }

        [HttpPost(ApiEndpoints.Building.Create)]
        public async Task<IActionResult> Create([FromBody] CreateBuildingRequest request, CancellationToken token)
        {
            Building building = _mapper.Map<Building>(request);

            var response = await _buildingService.CreateAsync(building, token);
            return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
        }

        [HttpGet(ApiEndpoints.Building.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken token)
        {
            var buildingExist = await _buildingService.GetAsync(id);

            if (buildingExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleBuildingResponse>(buildingExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Building.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var buildings = await _buildingService.GetAllAsync(token);

            var response =  new GetAllBuildingsResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleBuildingResponse>>(buildings)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Building.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateBuildingRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Building building = _mapper.Map<Building>(request);

            await _buildingService.UpdateAsync(building, token);

            var response = _mapper.Map<SingleBuildingResponse>(building);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Building.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _buildingService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Building with ID {id} not found.");
        }
    }
}

