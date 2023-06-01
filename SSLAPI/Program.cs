using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<SSLAPI.Seed>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<SSLAPI.Interfaces.IPokemonRepository, SSLAPI.Repository.PokemonRepository>();
builder.Services.AddScoped<SSLAPI.Interfaces.ICategoryRepository, SSLAPI.Repository.CategoryRepository>();
builder.Services.AddScoped<SSLAPI.Interfaces.ICountryRepository, SSLAPI.Repository.CountryRepository>();
builder.Services.AddScoped<SSLAPI.Interfaces.IOwnerRepository, SSLAPI.Repository.OwnerRepository>();
builder.Services.AddScoped<SSLAPI.Interfaces.IReviewRepository, SSLAPI.Repository.ReviewRepository>();
builder.Services.AddScoped<SSLAPI.Interfaces.IReviewerRepository, SSLAPI.Repository.ReviewerRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SSLAPI.Data.DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();


if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<SSLAPI.Seed>();
        service.SeedDataContext();
    }
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
