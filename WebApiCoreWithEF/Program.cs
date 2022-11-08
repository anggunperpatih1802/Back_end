using Microsoft.EntityFrameworkCore;
using WebApiCoreWithEF.Models;
using WebApiCoreWithEF.Interface;
using WebApiCoreWithEF.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ITrbpkb, TrbpkbRepository>();
builder.Services.AddTransient<IStorageLocation, LocationRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MAFDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MAFDbConnection"));
});

var app = builder.Build();

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
