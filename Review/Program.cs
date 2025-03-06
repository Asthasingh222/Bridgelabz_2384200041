using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IReviewBL, ReviewBL>();
builder.Services.AddScoped<IReviewRL, ReviewRL>();

// For SQL connection
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<ReviewContext>(options => options.UseSqlServer(connectionString));

// Adding Swagger service
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Redis Connection
builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var redisHost = builder.Configuration["ConnectionStrings:Redis"] ?? "redis:6379";
    return ConnectionMultiplexer.Connect(redisHost);
});


var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
