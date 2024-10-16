using LocationsAPI.Models;
using LocationsAPI.Models.OceanModels;

namespace LocationsAPI.Services.Interface
{
    public interface IOceanService
    {
        Task<ResultModel<Waves_Model>> OceanPrevision(string cityCode);
        Task<ResultModel<Waves_Model>> OceanPrevisonByDays(string cityCode, int days);
    }
}