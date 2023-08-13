using Microsoft.EntityFrameworkCore;
using Tax_Calculator.BusinessLayer;
using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Factories;
using Tax_Calculator.Repository;
using Tax_Calculator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddScoped<ICalculateTax, CalculateTaxProgressive>();
builder.Services.AddScoped<ICalculateTax, CalculateTaxFlatRate>();
builder.Services.AddScoped<ICalculateTax, CalculateTaxFlatValue>();
builder.Services.AddTransient<ITaxCalculationTypeFactory, TaxCalculationTypeFactory>();
builder.Services.AddTransient<ICalculateService, CalculateTaxService>();
builder.Services.AddTransient<ITaxCalculatorAdapterService, TaxCalculatorAdapterService>();
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ApplicationDbContext>(options =>
{	
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
