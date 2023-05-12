using Server.Models;
namespace Server;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<dBContext>();
        builder.Services.AddSingleton<IFrivilligRepository, FrivilligRepository>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("policy",
                              policy =>
                              {
                                  policy.AllowAnyOrigin().AllowAnyMethod()
        .AllowAnyHeader();
                              });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseCors("policy");
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
