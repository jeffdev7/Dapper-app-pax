using Dapper.menu.Domain.Persistence.Interfaces;
using Dapper.menu.Domain.Persistence.Repositories;
using Dapper.menu.WebAPI.Core;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Serilog;

SerilogExtensions.AddSerilog("API Pax");

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog(Log.Logger);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPaxRepository, PaxRepository>(_ =>
{
    return new PaxRepository(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddSingleton<DatabaseExtensions>();
builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IStartupFilter, MigrationManager>());

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
