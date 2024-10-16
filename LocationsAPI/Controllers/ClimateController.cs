using LocationsAPI.Models;
using LocationsAPI.Models.Climate;
using LocationsAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
namespace LocationsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClimateController : ControllerBase
{
    private readonly IClimateService _climateService;

    public ClimateController(IClimateService climateService)
    {
        _climateService = climateService;
    }

    [HttpGet]
    public async Task<ResultModel<AirportCapClimateModel>> ClimateByAirportCode(string icaoCode)
    {
        return await _climateService.ClimateByAirportCode(icaoCode);
    }

    [HttpGet("{city}")]
    public async Task<ResultModel<CityClimateModel>> ClimateCity([FromRoute]string city)
    {
        return await _climateService.ClimateCity(city);
    }

    [HttpGet("climaByDays")]
    public async Task<ResultModel<CityClimateModel>> PrevisionCityClimateByDays([FromQuery] int cityCode, [FromQuery] int days)
    {
        return await _climateService.PrevisionCityClimateByDays(cityCode, days);
    }
}
