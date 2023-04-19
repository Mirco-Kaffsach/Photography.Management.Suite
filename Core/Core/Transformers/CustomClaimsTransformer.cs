using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Photography.Management.Suite.Core.Configurations;

namespace Photography.Management.Suite.Core.Transformers;

/// <summary>
/// Class CustomClaimsTransformer. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class CustomClaimsTransformer : IClaimsTransformation, IDisposable
{
   private readonly OidcConfiguration oidcConfiguration;

   public CustomClaimsTransformer(OidcConfiguration oidcConfiguration)
   {
      this.oidcConfiguration = oidcConfiguration;
   }

   /// <summary>
   /// Transforms the asynchronous.
   /// </summary>
   /// <param name="principal">The principal.</param>
   /// <returns>Task&lt;ClaimsPrincipal&gt;.</returns>
   public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
   {
      var clientId = this.oidcConfiguration.ClientId;
      var resourceAccessClaim = principal.Claims.FirstOrDefault(c => c.Type == "resource_access");

      if (resourceAccessClaim == null)
         return Task.FromResult(principal);

      var resourceAccess = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(resourceAccessClaim.Value);

      if (resourceAccess == null || !resourceAccess.TryGetValue(clientId, out var clientAccess))
         return Task.FromResult(principal);

      var clientRoles = clientAccess.GetProperty("roles").EnumerateArray().Select(x => x.GetString()).ToList();
      var identity = (ClaimsIdentity?)principal.Identity;

      if (identity == null)
         return Task.FromResult(principal);

      foreach (var role in clientRoles)
      {
         if (role == null)
            continue;

         var newClaim = new Claim(ClaimTypes.Role, role);
         
         if (identity.HasClaim(x=>x.Type == newClaim.Type && x.Value == newClaim.Value) == false)
            identity.AddClaim(newClaim);
      }

      return Task.FromResult(principal);
   }

   #region IDisposable Interface Implementation

   private bool disposed;

   /// <summary>
   /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
   /// </summary>
   [ExcludeFromCodeCoverage]
   public void Dispose()
   {
      this.Dispose(true);
      GC.SuppressFinalize(this);
   }

   /// <summary>
   /// Releases unmanaged and - optionally - managed resources.
   /// </summary>
   /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
   [ExcludeFromCodeCoverage]
   private void Dispose(bool disposing)
   {
      if (!this.disposed && disposing)
      {
         // Disposing Logic
      }

      this.disposed = true;
   }

   /// <summary>
   /// Finalizes an instance of the <see cref="CustomClaimsTransformer"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~CustomClaimsTransformer()
   {
      this.Dispose(false);
   }

   #endregion
}
