using System.Diagnostics.CodeAnalysis;

namespace Photography.Management.Suite.Web.Components;

/// <summary>
/// Class PsLeftSideBar. This class cannot be inherited.
/// Implements the <see cref="Microsoft.AspNetCore.Components.ComponentBase" />
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
/// <seealso cref="System.IDisposable" />
public sealed partial class PsLeftSideBar : IDisposable
{
   /// <summary>
   /// Initializes a new instance of the <see cref="PsLeftSideBar"/> class.
   /// </summary>
   public PsLeftSideBar()
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
   /// Finalizes an instance of the <see cref="PsLeftSideBar"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~PsLeftSideBar()
   {
      this.Dispose(false);
   }

   #endregion
}
