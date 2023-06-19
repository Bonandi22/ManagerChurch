using IcmOdivelas.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//services DbContext
// Configure the connection string
var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");

// Configure the MySQL server version
var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseMySql(connectionString, serverVersion);
});

// Register IRepository and Repository
builder.Services.AddScoped<IRepository, Repository>();

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
