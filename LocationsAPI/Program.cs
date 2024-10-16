using LocationsAPI.Services;
using LocationsAPI.Rest;
using LocationsAPI.Rest.Interface;
using LocationsAPI.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<IBrazilApiRest, BrazilApiRest>();
builder.Services.AddSingleton<ICityService, CityService>();
builder.Services.AddSingleton<IClimateService, ClimateService>();
builder.Services.AddSingleton<IOceanService, OceanService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
