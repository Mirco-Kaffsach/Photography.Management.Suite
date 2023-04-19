using Photography.Management.Suite.AuthenticationService.Extensions;
using Photography.Management.Suite.Core.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Photography Management Suite Authentication
builder.Services
   .AddKeyCloakAuthentication()
   .AddPolicies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication(); // Füge dies vor UseAuthorization() ein
app.UseAuthorization();
app.MapControllers();
app.Run();
