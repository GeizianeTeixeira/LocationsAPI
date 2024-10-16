using LocationsAPI.Models;
using LocationsAPI.Models.Climate;

namespace LocationsAPI.Services.Interface
{
    public interface IClimateService
    {
        Task<ResultModel<AirportCapClimateModel>> ClimateByAirportCode(string icaoCode);
        //Task<ResultModel<List<AirportCapClimateModel>>> ClimateByCapitals();
        Task<ResultModel<CityClimateModel>> ClimateCity(string city);
        Task<ResultModel<CityClimateModel>> PrevisionCityClimateByDays(int cityCode, int days);
    }
}