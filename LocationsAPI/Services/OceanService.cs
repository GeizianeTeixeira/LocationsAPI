using LocationsAPI.Models;
using LocationsAPI.Models.OceanModels;
using LocationsAPI.Rest.Interface;
using LocationsAPI.Services.Interface;
namespace LocationsAPI.Services;

public class OceanService : IOceanService
{
    private readonly IBrazilApiRest _brazilApiRest;
    public OceanService(IBrazilApiRest brazilApiRest)
    {
        _brazilApiRest = brazilApiRest;
    }

    public async Task<ResultModel<Waves_Model>> OceanPrevision(string cityCode)
    {
        return await _brazilApiRest.OceanPrevision(cityCode);
    }
    public async Task<ResultModel<Waves_Model>> OceanPrevisonByDays(string cityCode, int days)
    {
        return await _brazilApiRest.OceanPrevisonByDays(cityCode, days);
    }
}
