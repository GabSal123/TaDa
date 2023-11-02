using Microsoft.EntityFrameworkCore;
using QuickMedik.Model;
using QuickMedik.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000", "https://appname.azurestaticapps.net");
    });
});
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseInMemoryDatabase("Clients");
});

builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseInMemoryDatabase("Proffesionals");
});

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
