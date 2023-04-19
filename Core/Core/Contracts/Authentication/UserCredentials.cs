using System.Diagnostics.CodeAnalysis;

namespace Photography.Management.Suite.Core.Contracts.Authentication;

/// <summary>
/// Class UserCredentials. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class UserCredentials : IDisposable
{
   /// <summary>
   /// Gets or sets the username.
   /// </summary>
   /// <value>The username.</value>
   public string Username { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the password.
   /// </summary>
   /// <value>The password.</value>
   public string Password { get; set; } = string.Empty;

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
   /// Finalizes an instance of the <see cref="UserCredentials"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~UserCredentials()
   {
      this.Dispose(false);
   }

   #endregion
}
