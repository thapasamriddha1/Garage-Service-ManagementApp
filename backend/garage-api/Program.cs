using Microsoft.EntityFrameworkCore;
using garage_api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// PostgreSQL connection
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
