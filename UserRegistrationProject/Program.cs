using BusinessLayer_.Service;
using Microsoft.EntityFrameworkCore;
using Repository_Layer.Context;
using Repository_Layer.Service;
using UserRegistrationProject.Controllers;

var builder = WebApplication.CreateBuilder(args);

//for sql connection
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<UserRegistrationContext>(options => options.UseSqlServer(connectionString));

//adding swagger service
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Logging
builder.Services.AddLogging();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<UserRegistrationBL>();
builder.Services.AddScoped<UserRegistrationRL>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
