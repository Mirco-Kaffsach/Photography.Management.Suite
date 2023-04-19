using System.Diagnostics.CodeAnalysis;

namespace Photography.Management.Suite.Core.Contracts;

/// <summary>
/// Class User. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class User : IDisposable
{
   public Guid SystemId { get; set; }

   public int Id { get; set; }

   public bool IsLocked { get; set; }

   /// <summary>
   /// Initializes a new instance of the <see cref="User"/> class.
   /// </summary>
   public User()
   {
      
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
   /// Finalizes an instance of the <see cref="User"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~User()
   {
      this.Dispose(false);
   }

   #endregion
}
