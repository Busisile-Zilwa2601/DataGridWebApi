using System.Text;
using DataGridWebApi.ContextData;
using DataGridWebApi.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    //Basic Info
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DataGridWebApi",
        Version = "v1"
    });

    //Add Jwt Bearer Auth
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter Bearer <Your Token>"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    { 
        {
            new OpenApiSecurityScheme { 
                Reference = new OpenApiReference { 
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

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

var jwtSection = builder.Configuration.GetSection("JwtSettings");
builder.Services.Configure<JwtSettings>(jwtSection);

var jwtSettings = jwtSection.Get<JwtSettings>();
var key = Encoding.UTF8.GetBytes(jwtSettings.Secret);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseCors("AllowAngularApp");

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI( c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataGridWebApi v1");
    }
);
app.UseAuthorization();
app.MapControllers();
app.Run();