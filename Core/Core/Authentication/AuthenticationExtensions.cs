using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Photography.Management.Suite.Core.Configurations;
using Photography.Management.Suite.Core.Transformers;

namespace Photography.Management.Suite.Core.Authentication;

/// <summary>
/// Static Class AuthenticationExtensions.
/// </summary>
public static class AuthenticationExtensions
{
   /// <summary>
   /// Adds the key cloak authentication.
   /// </summary>
   /// <param name="services">The services.</param>
   /// <returns>IServiceCollection.</returns>
   public static IServiceCollection AddKeyCloakAuthentication(this IServiceCollection services)
   {
      var oidcConfig = new OidcConfiguration();

      services.AddSingleton(oidcConfig);
      services.AddSingleton<IClaimsTransformation, CustomClaimsTransformer>();
      services.AddAuthentication
         (
            options =>
            {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
         )
         .AddJwtBearer
         (
            options =>
            {
               options.Authority = oidcConfig.Authority;
               options.Audience = oidcConfig.ClientId;
               options.RequireHttpsMetadata = true; // Setze dies nur in der Entwicklungsumgebung auf 'false'
               options.TokenValidationParameters = new TokenValidationParameters
               {
                  NameClaimType = "preferred_username",
                  ValidateIssuerSigningKey = true,
                  ValidateIssuer = true,
                  ValidateAudience = true,
                  ValidateLifetime = true,
                  ClockSkew = TimeSpan.FromMinutes(5)
               };
            }
         );

      return services;
   }
}
