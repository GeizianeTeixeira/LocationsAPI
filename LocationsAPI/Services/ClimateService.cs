using LocationsAPI.Models;
using LocationsAPI.Models.Climate;
using LocationsAPI.Rest.Interface;
using System.Net.Http;
using System.Net;
using System.Text.Json;
using LocationsAPI.Services.Interface;
namespace LocationsAPI.Services
{
    public class ClimateService : IClimateService
    {
        private readonly IBrazilApiRest _brazilApiRest;

        public ClimateService(IBrazilApiRest brazilApiRest)
        {
            _brazilApiRest = brazilApiRest;
        }

        //public async Task<ResultModel<List<AirportCapClimateModel>>> ClimateByCity()
        //{
        //    return await _brazilApiRest.ClimateByCapitals();
        //}

        public async Task<ResultModel<AirportCapClimateModel>> ClimateByAirportCode(string icaoCode)
        {
            return await _brazilApiRest.ClimateByAirportCode(icaoCode);
        }

        public async Task<ResultModel<CityClimateModel>> ClimateCity(string city)
        {
            return await _brazilApiRest.ClimateCity(city);
        }

        public async Task<ResultModel<CityClimateModel>> PrevisionCityClimateByDays(int cityCode, int days)
        {
            return await _brazilApiRest.PrevisionCityClimateByDays(cityCode, days);
        }

    }
}
