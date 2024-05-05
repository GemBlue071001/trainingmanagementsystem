using Application;
using Infrastructures;
using Microsoft.Exchange.WebServices.Data;
using WebAPI;
using WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration.Get<AppConfiguration>();
builder.Services.AddInfrastructuresService(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddWebAPIService(configuration);

builder.Services.AddSingleton(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(p=>p.AllowAnyHeader().AllowAnyHeader().AllowAnyOrigin() );
app.UseMiddleware<GlobalExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
