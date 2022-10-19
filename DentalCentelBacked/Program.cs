using AutoMapper;
using DentalCenterDomain.Core.Interfaces;
using DentalCenterDomain.Infraestructura.Data;
using DentalCenterDomain.Infrastructure.Mapping;
using DentalCenterDomain.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conecctionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddDbContext<DentalCenterContext>(options => options.UseSqlServer(conecctionString));

//Add services to the container
builder.Services.AddTransient<IPacienteRepository, PacienteRepository>();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutomapperProfile());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
