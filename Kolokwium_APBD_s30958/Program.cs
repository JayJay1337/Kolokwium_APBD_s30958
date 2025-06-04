using Kolokwium_APBD_s30958.data;
using Kolokwium_APBD_s30958.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Rejestruj usługi PRZED Build
builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<ICustomersService, CustomersService>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
app.Run();

