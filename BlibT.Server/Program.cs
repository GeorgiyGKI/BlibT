using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using NLog;
using Repository;
using Repository.Configuration;
using WebLibWebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

//logger
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);


builder.Services.AddFileService();

builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
});


var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(logger);


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<RepositoryContext>();
        var userManager = services.GetRequiredService<UserManager<User>>();

        var adminSeeder = new AdminSeeder(context, userManager);
        await adminSeeder.Seed();
    }
    catch (Exception ex)
    {
        var loggerDB = services.GetRequiredService<ILoggerManager>();
        loggerDB.LogError("An error occurred while seeding the database.");
    }

}

//app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Uploads")),
    RequestPath = "/resources"
});
// Configure the HTTP request pipeline.

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

//app.MigrateDatabase().Run(); будет лучше
app.Run();
