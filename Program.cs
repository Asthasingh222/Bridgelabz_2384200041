using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using NLog;
using NLog.Web;

// Configure NLog
var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
logger.Info("Application Starting...");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Set NLog as the default logger
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    builder.Services.AddControllers();
    builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

    // For SQL connection
    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
    builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

    // Adding Swagger service
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Enable Swagger
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application stopped due to an exception.");
    throw;
}
finally
{
    LogManager.Shutdown();
}
