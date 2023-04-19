using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;
using Microsoft.AspNetCore.Builder;

namespace Photography.Management.Suite.Web.ConfigExtensions;

/// <summary>
/// Static Class CompressionExtensions.
/// </summary>
public static class CompressionExtensions
{
   public static IServiceCollection ConfigureResponseCompression(this IServiceCollection services)
   {
      services.AddResponseCompression(options =>
      {
         options.EnableForHttps = true;
         options.Providers.Add<BrotliCompressionProvider>();
         options.Providers.Add<GzipCompressionProvider>();
      });

      services.Configure<BrotliCompressionProviderOptions>(options =>
      {
         options.Level = CompressionLevel.Fastest;
      });

      services.Configure<GzipCompressionProviderOptions>(options =>
      {
         options.Level = CompressionLevel.Fastest;
      });

      return services;
   }
}
