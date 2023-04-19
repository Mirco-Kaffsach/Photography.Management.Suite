//using System.Data;
//using Microsoft.Data.SqlClient;
//using Photography.Management.Suite.Core.Contracts;

//namespace DataAdapter.MsSqlServer.Test;

///// <summary>
///// Class UserExtensions.
///// </summary>
//public static class UserExtensions
//{
//   /// <summary>
//   /// Maps the specified reader.
//   /// </summary>
//   /// <param name="reader">The reader.</param>
//   /// <returns>User.</returns>
//   public static User Map(this SqlDataReader reader)
//   {
//      var result = new User();

//      result.SystemId = reader.GetGuid("SystemId");
//      result.Id = reader.GetInt32("Id");
//      result.IsLocked = reader.GetBoolean("IsLocked");

//      return result;
//   }
//}
