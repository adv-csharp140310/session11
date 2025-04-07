
using DependencyInjection.Services;

namespace DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        //DI Container
        //AddTransient -> harbar yek instance jadid besaz
        //AddScoped ->    baraye yek request yek instance jadid besaz
        //AddSingleton -> kolan yek instance misaze

        builder.Services.AddTransient<INotificationService, SmsNotificationSercice>();
        //builder.Services.AddTransient<INotificationService, EmailNotificationService>();

        //builder.Services.AddScoped<INotificationService, SmsNotificationSercice>();
        //builder.Services.AddSingleton<INotificationService, SmsNotificationSercice>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
