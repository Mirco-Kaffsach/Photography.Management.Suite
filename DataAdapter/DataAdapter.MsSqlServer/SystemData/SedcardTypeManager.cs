using System.Data;
using System.Diagnostics.CodeAnalysis;
using DataAdapter.MsSqlServer.Test;
using Microsoft.Data.SqlClient;
using Photography.Management.Suite.Core.Contracts.CodeTypes;

namespace DataAdapter.MsSqlServer.SystemData;

/// <summary>
/// Class SedcardTypeManager. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class SedcardTypeManager : IDisposable
{
   /// <summary>
   /// Initializes a new instance of the <see cref="SedcardTypeManager"/> class.
   /// </summary>
   public SedcardTypeManager()
   {
      
   }

   public async Task<IEnumerable<SedcardType>> GetSedcardTypesAsync(CancellationToken cancellationToken)
   {
      await using (var sqlConnection = new SqlConnection("Server=10.215.1.50;Database=PhotographyManagementSuite_DEV;User Id=sa;Password=Develop#2022;Encrypt=false"))
      await using (var cmd = new SqlCommand("dbo.GetSedcardTypes", sqlConnection))
      {
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("IncludeInactive", true);

         await sqlConnection.OpenAsync(cancellationToken);
         await using (var reader = await cmd.ExecuteReaderAsync(cancellationToken))
         {
            //reader.Map<SedcardType>();


            var result = new List<SedcardType>();
            
            while (await reader.ReadAsync(cancellationToken))
            {
               
               result.Add(new SedcardType().Map(reader));

               //result.Add(new SedcardType().Map(reader));
               //result.Add(DataMapper.Map<SedcardType>(reader));
            }

            return result;
         }
      }
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
   /// Finalizes an instance of the <see cref="SedcardTypeManager"/> class.
   /// </summary>
   [ExcludeFromCodeCoverage]
   ~SedcardTypeManager()
   {
      this.Dispose(false);
   }

   #endregion
}
