using DataAdapter.MsSqlServer.SystemData;
using Photography.Management.Suite.Core.Contracts;
using Photography.Management.Suite.Core.Contracts.CodeTypes;


var test = new SedcardType();
var name = nameof(test);
var type = typeof(SedcardType).Name;


switch (test.GetType().Name)
{
   case nameof(SedcardType):
      Console.WriteLine("SedcardType");
      break;
   case nameof(User):
      Console.WriteLine("User");
      break;
   default:
      Console.WriteLine("! ! !  U N K N O W N  ! ! !");
      break;
}









var manager = new SedcardTypeManager();
var list = await manager.GetSedcardTypesAsync(CancellationToken.None);


foreach (var item in list)
{
   Console.WriteLine(item.Title);
}