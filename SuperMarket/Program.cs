using Microsoft.EntityFrameworkCore;
using SuperMarket.Database;
using SuperMarket.Services.Abstracts;

namespace SuperMarket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //var emailConfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfigOptions>();
            //builder.Services.AddSingleton(emailConfig);

            //builder.Services.AddScoped<IEmailService, IEmailService>();
            builder.Services
                .AddDbContext<DataContext>(o =>
                {
                    o.UseSqlServer(builder.Configuration.GetConnectionString("Zeynal"));
                })
                .AddMvc();
                //.AddRazorRuntimeCompilation();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}");

            app.Run();

        }
    }
}