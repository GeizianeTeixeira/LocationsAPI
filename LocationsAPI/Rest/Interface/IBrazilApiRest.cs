using LocationsAPI.Models;
using LocationsAPI.Models.CityModel;
using LocationsAPI.Models.Climate;
using LocationsAPI.Models.OceanModels;

namespace LocationsAPI.Rest.Interface
{
    public interface IBrazilApiRest
    {
        Task<ResultModel<AirportCapClimateModel>> ClimateByAirportCode(string icaoCode);
       // Task<ResultModel<List<AirportCapClimateModel>>> ClimateByCapitals();
        Task<ResultModel<CityClimateModel>> ClimateCity(string city);
        Task<ResultModel<List<CityModel>>> GetAllCities();
        Task<ResultModel<List<CityModel>>> GetListCities(string cityName);
        Task<ResultModel<Waves_Model>> OceanPrevision(string cityCode);
        Task<ResultModel<Waves_Model>> OceanPrevisonByDays(string cityCode, int days);
        Task<ResultModel<CityClimateModel>> PrevisionCityClimateByDays(int cityCode, int days);
    }
}