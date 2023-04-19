using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Photography.Management.Suite.Core.Contracts.Authentication;

/// <summary>
/// Class TokenResponse. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class TokenResponse : IDisposable
{
   /// <summary>
   /// Gets or sets the access token.
   /// </summary>
   /// <value>The access token.</value>
   [JsonPropertyName("access_token")]
   public string AccessToken { get; set; }

   /// <summary>
   /// Gets or sets the expires in.
   /// </summary>
   /// <value>The expires in.</value>
   [JsonPropertyName("expires_in")]
   public int ExpiresIn { get; set; }

   /// <summary>
   /// Gets or sets the refresh expires in.
   /// </summary>
   /// <value>The refresh expires in.</value>
   [JsonPropertyName("refresh_expires_in")]
   public int RefreshExpiresIn { get; set; }

   /// <summary>
   /// Gets or sets the refresh token.
   /// </summary>
   /// <value>The refresh token.</value>
   [JsonPropertyName("refresh_token")]
   public string RefreshToken { get; set; }

   /// <summary>
   /// Gets or sets the type of the token.
   /// </summary>
   /// <value>The type of the token.</value>
   [JsonPropertyName("token_type")]
   public string TokenType { get; set; }

   /// <summary>
   /// Gets or sets the identifier token.
   /// </summary>
   /// <value>The identifier token.</value>
   [JsonPropertyName("id_token")]
   public string IdToken { get; set; }

   /// <summary>
   /// Gets or sets the not before policy.
   /// </summary>
   /// <value>The not before policy.</value>
   [JsonPropertyName("not-before-policy")]
   public int NotBeforePolicy { get; set; }

   /// <summary>
   /// Gets or sets the state of the session.
   /// </summary>
   /// <value>The state of the session.</value>
   [JsonPropertyName("session_state")]
   public string SessionState { get; set; }

   /// <summary>
   /// Gets or sets the scope.
   /// </summary>
   /// <value>The scope.</value>
   [JsonPropertyName("scope")]
   public string Scope { get; set; }

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
   /// Finalizes an instance of the <see cref="TokenResponse"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~TokenResponse()
   {
      this.Dispose(false);
   }

   #endregion
}
