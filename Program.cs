using DataGridWebApi.ContextData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// For in-memory logic, you don’t need EF registration.
// If needed, register it as a singleton:
builder.Services.AddSingleton<InMemoryAddressContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", builder =>
       builder.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials());
});

var app = builder.Build();

app.UseCors("AllowAngularApp");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();