using LocationsAPI.Models;
using LocationsAPI.Models.CityModel;
using LocationsAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LocationsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : ControllerBase
{
    private readonly ICityService _cityService;

    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet]
    public async Task<ResultModel<List<CityModel>>> GetAllCities()
    {
        return await _cityService.GetAllCities();
    }

    [HttpGet("{cityName}")]
    public async Task<ResultModel<List<CityModel>>> GetListCities([FromRoute] string cityName)
    {
        return await _cityService.GetListCities(cityName);
    }
}
