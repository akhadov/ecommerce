using E_Commerce.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
#region Databases
var connectionString = builder.Configuration.GetConnectionString("DbName");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));
#endregion
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Middlewares
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
#endregion