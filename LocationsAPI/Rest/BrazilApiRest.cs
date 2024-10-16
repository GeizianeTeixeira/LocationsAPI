using LocationsAPI.Models;
using LocationsAPI.Models.CityModel;
using LocationsAPI.Models.Climate;
using LocationsAPI.Models.OceanModels;
using LocationsAPI.Rest.Interface;
using System.Net;
using System.Text.Json;

namespace LocationsAPI.Rest;

public class BrazilApiRest : IBrazilApiRest
{
    private readonly HttpClient _httpClient;
    public BrazilApiRest(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ResultModel<List<CityModel>>> GetAllCities()
    {
        var request = await _httpClient.GetAsync("https://brasilapi.com.br/api/cptec/v1/cidade");
        var content = await request.Content.ReadAsStringAsync();
        var objResponse = JsonSerializer.Deserialize<List<CityModel>>(content);
        return ResultModel<List<CityModel>>.SuccessResult(objResponse!);
    }

    public async Task<ResultModel<List<CityModel>>> GetListCities(string cityName)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/cidade/{cityName}");
        var content = await request.Content.ReadAsStringAsync();

        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<List<CityModel>>.ErrorResult(HttpStatusCode.NotFound, content);
        }

        var objResponse = JsonSerializer.Deserialize<List<CityModel>>(content);
        return ResultModel<List<CityModel>>.SuccessResult(objResponse!);

    }

    // Está com problema na API, não retorna as informações corretas.
    //public async Task<ResultModel<List<AirportCapClimateModel>>> ClimateByCapitals() // retorna realmente uma list?
    //{
    //    var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/capital");
    //    var content = await request.Content.ReadAsStringAsync();

    //    if (!request.IsSuccessStatusCode)
    //    {
    //        return ResultModel<List<AirportCapClimateModel>>.ErrorResult(HttpStatusCode.NotFound, content);
    //    }

    //    var response = JsonSerializer.Deserialize<List<AirportCapClimateModel>>(content);
    //    return ResultModel<List<AirportCapClimateModel>>.SuccessResult(response!);
    //}


    public async Task<ResultModel<AirportCapClimateModel>> ClimateByAirportCode(string icaoCode)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{icaoCode}");
        var content = await request.Content.ReadAsStringAsync();

        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<AirportCapClimateModel>.ErrorResult(HttpStatusCode.NotFound, content);
        }

        var response = JsonSerializer.Deserialize<AirportCapClimateModel>(content);
        return ResultModel<AirportCapClimateModel>.SuccessResult(response!);
    }

    public async Task<ResultModel<CityClimateModel>> ClimateCity(string city)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{city}");
        var content = await request.Content.ReadAsStringAsync();

        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<CityClimateModel>.ErrorResult(HttpStatusCode.NotFound, content);
        }

        var response = JsonSerializer.Deserialize<CityClimateModel>(content);
        return ResultModel<CityClimateModel>.SuccessResult(response!);
    }

    public async Task<ResultModel<CityClimateModel>> PrevisionCityClimateByDays(int cityCode, int days)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cityCode}/{days}");
        var content = await request.Content.ReadAsStringAsync();
        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<CityClimateModel>.ErrorResult(HttpStatusCode.NotFound, content);
        }
        var response = JsonSerializer.Deserialize<CityClimateModel>(content);
        return ResultModel<CityClimateModel>.SuccessResult(response!);
    }

    public async Task<ResultModel<Waves_Model>> OceanPrevision(string cityCode)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/ondas/{cityCode}");
        var content = await request.Content.ReadAsStringAsync();
        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<Waves_Model>.ErrorResult(HttpStatusCode.NotFound, content);
        }
        var response = JsonSerializer.Deserialize<Waves_Model>(content);
        return ResultModel<Waves_Model>.SuccessResult(response!);
    }

    public async Task<ResultModel<Waves_Model>> OceanPrevisonByDays(string cityCode, int days)
    {
        var request = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/ondas/{cityCode}/{days}");
        var content = await request.Content.ReadAsStringAsync();
        if (!request.IsSuccessStatusCode)
        {
            return ResultModel<Waves_Model>.ErrorResult(HttpStatusCode.NotFound, content);
        }
        var response = JsonSerializer.Deserialize<Waves_Model>(content);
        return ResultModel<Waves_Model>.SuccessResult(response!);
    }
}
