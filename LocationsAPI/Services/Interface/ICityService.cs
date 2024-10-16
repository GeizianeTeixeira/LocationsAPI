using LocationsAPI.Models;
using LocationsAPI.Models.CityModel;

namespace LocationsAPI.Services.Interface
{
    public interface ICityService
    {
        Task<ResultModel<List<CityModel>>> GetAllCities();
        Task<ResultModel<List<CityModel>>> GetListCities(string cityName);
    }
}