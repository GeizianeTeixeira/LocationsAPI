using LocationsAPI.Models.OceanModels;
using LocationsAPI.Models;
using LocationsAPI.Rest.Interface;
using LocationsAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LocationsAPI.Controllers;

public class OceanController : ControllerBase
{
    private readonly IOceanService _oceanService;

    public OceanController(IOceanService oceanService)
    {
        _oceanService = oceanService;
    }

    [HttpGet]
    public async Task<ResultModel<Waves_Model>> OceanPrevision(string cityCode)
    {
        return await _oceanService.OceanPrevision(cityCode);
    }

    [HttpGet("PrevisionByDays")]
    public async Task<ResultModel<Waves_Model>> OceanPrevisonByDays(string cityCode, int days)
    {
        return await _oceanService.OceanPrevisonByDays(cityCode, days);
    }
}