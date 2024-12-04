
using InquiryApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages services
builder.Services.AddRazorPages();

// Add the database context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container
builder.Services.AddControllers(); // Enable controllers (for APIs)
builder.Services.AddEndpointsApiExplorer(); // For Swagger
builder.Services.AddSwaggerGen(); // Adds Swagger

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger
    app.UseSwaggerUI(); // Enable Swagger UI
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Map API controllers
app.MapRazorPages();

app.Run();