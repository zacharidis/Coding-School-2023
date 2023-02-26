using GZFuel.EF.Repositories;
using GZFuel.Model.Entities;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IEntityRepo<Admin>,AdminRepository>();
builder.Services.AddScoped<IEntityRepo<Customer>,CustomerRepository>();
builder.Services.AddScoped<IEntityRepo<Employee>,EmployeeRepository>();
builder.Services.AddScoped<IEntityRepo<Transaction>,TransactionRepository>();
builder.Services.AddScoped<IEntityRepo<Item>,ItemRepository>();
builder.Services.AddScoped<IEntityRepo<TransactionLine>,TransactionLineRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
