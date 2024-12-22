using System.Text.Json.Serialization;
using Yedidim;
using Yedidim.Api.Middlewares;
using Yedidim.Api.Models;
using Yedidim.Core;
using Yedidim.Core.Repositories;
using Yedidim.Core.Services;
using Yedidim.Data;
using Yedidim.Data.Repositories;
using Yedidim.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICallFromPeopleRepository, CallFromPeopleRepository>();
builder.Services.AddScoped<ITypesOfCalltRepository, TypesOfCallRepository>();
builder.Services.AddScoped<IVolunteerRepository, VolunteerRepository>();


builder.Services.AddScoped<ICallFromPeopleService, CallFromPeoplerService> ();
builder.Services.AddScoped<ITypesOfCallService, TypesOfCallService>();
builder.Services.AddScoped<IVolunteerService, VolunteerService>();

//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseTrack();

app.MapControllers();

app.Run();
