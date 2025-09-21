using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BankMe.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BankMeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankMeContext") ?? throw new InvalidOperationException("Connection string 'BankMeContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
