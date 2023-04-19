//using Microsoft.Data.SqlClient;
//using System.Data;
//using Photography.Management.Suite.Core.Contracts;
//using Photography.Management.Suite.Core.Contracts.CodeTypes;

//namespace DataAdapter.MsSqlServer.Test;

//public static class DataMapper
//{
//   private static readonly Dictionary<Type, Func<SqlDataReader, object>> Mappings = new Dictionary<Type, Func<SqlDataReader, object>>
//   {
//      { typeof(SedcardType), MapSedcardType },
//      { typeof(User), MapUser }
//      // Weitere Mapping-Methoden können hier hinzugefügt werden
//   };

//   public static T Map<T>(SqlDataReader reader)
//   {
//      var targetType = typeof(T);

//      if (!Mappings.ContainsKey(targetType))
//      {
//         throw new ArgumentException($"No mapping defined for target type {targetType.Name}");
//      }

//      var mappingMethod = Mappings[targetType];
      
//      return (T)mappingMethod(reader);
//   }

//   private static SedcardType MapSedcardType(SqlDataReader reader)
//   {
//      var result = new SedcardType();

//      result.SystemId = reader.GetGuid("SystemId");
//      result.Id = reader.GetInt32("Id");
//      result.Title = reader.GetString("SedcardType");
//      result.IsActive = reader.GetBoolean("IsActive");
      
//      return result;
//   }

//   private static User MapUser(SqlDataReader reader)
//   {
//      var result = new User();

//      result.SystemId = reader.GetGuid("SystemId");
//      result.Id = reader.GetInt32("Id");
//      result.IsLocked = reader.GetBoolean("IsLocked");
      
//      return result;
//   }
//}
