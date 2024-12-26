using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Stable.Data;
using Stable.Helpers;
using Stable.Repositories;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//solve file problem
builder.Services.AddControllers(options =>
{
    options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
    options.OutputFormatters.Add(new SystemTextJsonOutputFormatter(new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        ReferenceHandler = ReferenceHandler.Preserve,
    }));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("default"))
);

builder.Services.AddScoped(typeof(IGeneicRepository<>),typeof(GenericRepository<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();
//Explicitly
var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var loggerfactory = services.GetRequiredService<ILoggerFactory>();
try
{
    var dbcontext = services.GetRequiredService<ApplicationDbContext>();
    await dbcontext.Database.MigrateAsync();//update-database
    //var Identitydbcontext = services.GetRequiredService<AppIdentityDbContext>();
    //await Identitydbcontext.Database.MigrateAsync();//update-database
    //var usermaneger = services.GetRequiredService<UserManager<AppUser>>();
    //await AppIdentityDbContextSeed.SeedUsersAsync(usermaneger);
}
catch (Exception ex)
{
    var logger = loggerfactory.CreateLogger<Program>();
    logger.LogError(ex, "an error occurred when you apply migration");
}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
