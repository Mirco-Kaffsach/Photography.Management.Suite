namespace Photography.Management.Suite.UserService.Extensions;

/// <summary>
/// Static Class AuthenticationExtensions.
/// </summary>
public static class AuthenticationExtensions
{
   public static IServiceCollection AddPolicies(this IServiceCollection services)
   {
      services.AddAuthorization
      (
         options =>
         {
            options.AddPolicy
            (
               "TestPolicy", policy =>
               {
                  policy.RequireAssertion(context =>
                     context.User.IsInRole("tester") || context.User.IsInRole("admin"));
               }
            );
         }
      );

      return services;
   }
}
