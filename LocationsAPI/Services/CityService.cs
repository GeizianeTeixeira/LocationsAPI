using LocationsAPI.Models;
using LocationsAPI.Models.CityModel;
using LocationsAPI.Rest.Interface;
using LocationsAPI.Services.Interface;
using System.Net.Http;
using System.Text.Json;

namespace LocationsAPI.Services
{
    public class CityService : ICityService
    {
        private readonly IBrazilApiRest _brazilApiRest;

        public CityService(IBrazilApiRest brazilApiRest)
        {
            _brazilApiRest = brazilApiRest;
        }

        public async Task<ResultModel<List<CityModel>>> GetAllCities()
        {
            return await _brazilApiRest.GetAllCities();
        }

        public async Task<ResultModel<List<CityModel>>> GetListCities(string cityName)
        {
            return await _brazilApiRest.GetListCities(cityName);
        }
    }
}
