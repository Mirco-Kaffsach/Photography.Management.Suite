//using System.Data;
//using Microsoft.Data.SqlClient;
//using Photography.Management.Suite.Core.Contracts.CodeTypes;

//namespace DataAdapter.MsSqlServer.Test;

//public static class SedcardTypeExtensions
//{
//   public static SedcardType Map(this SedcardType _, SqlDataReader reader)
//   {
//      var instance = new SedcardType();

//      instance.SystemId = reader.GetGuid("SystemId");
//      instance.Id = reader.GetInt32("Id");
//      instance.Title = reader.GetString("SedcardType");
//      instance.IsActive = reader.GetBoolean("IsActive");

//      return instance;
//   }
//}
