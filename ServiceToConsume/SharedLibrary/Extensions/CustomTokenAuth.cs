using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedLibrary.Configurations;
using SharedLibrary.Services;

namespace SharedLibrary.Extensions
{
    public static class CustomTokenAuth
    {
        public static void AddCustomAuth(this IServiceCollection services, IConfiguration configuration, CustomTokenOption customTokenOption=null)
        {
            services.AddAuthentication(options =>
                        {
                            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                        }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opts =>
                        {
                            var tokenOptions = configuration.GetSection("TokenOption").Get<CustomTokenOption>();
                            opts.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                            {
                                ValidIssuer = tokenOptions.Issuer,
                                ValidAudience = tokenOptions.Audience[0],
                                IssuerSigningKey = SignService.GetSymmetricSecurityKey(tokenOptions.SecurityKey),
            
                                ValidateIssuerSigningKey = true,
                                ValidateAudience = true,
                                ValidateIssuer = true,
                                ValidateLifetime = true,
                                ClockSkew = TimeSpan.Zero
                            };
                        });
        }
    }
}