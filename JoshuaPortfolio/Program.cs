namespace JoshuaPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Disable configuration file reload watchers.
            builder.Configuration.Sources
                .OfType<Microsoft.Extensions.Configuration.Json.JsonConfigurationSource>()
                .ToList()
                .ForEach(source => source.ReloadOnChange = false);

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run();
        }
    }
}