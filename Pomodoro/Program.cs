using Microsoft.EntityFrameworkCore;
using Pomodoro.Data;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendLocalhost",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173") // Add the frontend origin
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontendLocalhost");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
