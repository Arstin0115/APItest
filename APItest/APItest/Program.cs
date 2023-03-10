using APItest.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string dbFTConnectionString = builder.Configuration.GetConnectionString("dbFT");
builder.Services.AddDbContext<dbFTContext>(options =>
{
    options.UseSqlServer(connectionString: dbFTConnectionString);
});

builder.Services.AddControllers();

var MyAllowSpecificOrigins = "AllowAny";
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: MyAllowSpecificOrigins,
        policy => policy.WithOrigins("*").WithHeaders("*").WithMethods("*")
        );
});



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
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
