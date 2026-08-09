namespace JoshuaPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            // Serve files from wwwroot
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run();
        }
    }
}