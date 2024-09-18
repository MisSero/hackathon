﻿using Events.Service.Auth;
using Events.Service.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;

namespace Events.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = AuthOptions.Issuer,
                    ValidateAudience = true,
                    ValidAudience = AuthOptions.Audience,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey()
                };
            });
            builder.Services.AddAuthorization();

            string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DbContext, AppDbContext>(options =>
                options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IEventStorage, EventStorage>();

            builder.Services.AddControllers().AddJsonOptions(options =>
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            builder.Services.AddSwaggerGen(config =>
            {
                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                config.IncludeXmlComments(xmlPath);

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "Enter JWT Bearer token",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                config.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                config.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { }}
                });
            });

            var app = builder.Build();

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader());

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.MapGet("/", () => "Hello world from EventsService");

            app.Run();
        }
    }
}
