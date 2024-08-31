using backend.Model;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<UserSettings>(
    builder.Configuration.GetSection("UserDetailsDatabase"));

builder.Services.AddSingleton<UserService>();

builder.Services.AddControllers();
   
   /* .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null); */

builder.Services.AddDbContext<UserContext>(opt =>
    opt.UseInMemoryDatabase("UserDb"));

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

