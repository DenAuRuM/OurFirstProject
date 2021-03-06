using GameCafe.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GameCafe.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GameCafeContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<GameCafeContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBoardGameManager, BoardGameManager>();
builder.Services.AddScoped<IReviewManager, ReviewManager>();
builder.Services.AddScoped<IBookManager, BookManager>();
builder.Services.AddScoped<IDrinkManager, DrinkManager>();
builder.Services.AddScoped<IMovieManager, MovieManager>();
builder.Services.AddScoped<IPlaceManager, PlaceManager>();
builder.Services.AddScoped<ISnackManager, SnackManager>();
builder.Services.AddScoped<ITariffManager, TariffManager>();
builder.Services.AddScoped<IVideogameManager, VideogameManager>();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
