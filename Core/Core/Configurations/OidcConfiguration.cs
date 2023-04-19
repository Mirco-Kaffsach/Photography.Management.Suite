using System.Diagnostics.CodeAnalysis;

namespace Photography.Management.Suite.Core.Configurations;

/// <summary>
/// Class OidcConfiguration. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class OidcConfiguration : IDisposable
{
   /// <summary>
   /// Gets the authority.
   /// </summary>
   /// <value>The authority.</value>
   public string Authority => Environment.GetEnvironmentVariable("OIDC_AUTHORITY") ?? string.Empty;

   /// <summary>
   /// Gets the client identifier.
   /// </summary>
   /// <value>The client identifier.</value>
   public string ClientId => Environment.GetEnvironmentVariable("OIDC_CLIENT_ID") ?? string.Empty;

   /// <summary>
   /// Gets the client secret.
   /// </summary>
   /// <value>The client secret.</value>
   public string ClientSecret => Environment.GetEnvironmentVariable("OIDC_CLIENT_SECRET") ?? string.Empty;

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
   /// Finalizes an instance of the <see cref="OidcConfiguration"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~OidcConfiguration()
   {
      this.Dispose(false);
   }

   #endregion
}
