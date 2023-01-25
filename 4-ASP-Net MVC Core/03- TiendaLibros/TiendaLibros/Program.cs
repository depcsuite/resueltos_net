using Microsoft.EntityFrameworkCore;
using TiendaLibros.Data;




var builder = WebApplication.CreateBuilder(args);

// Add the whole configuration object here.
IConfiguration configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();


builder.Services.AddDbContext<LibrosDBContext>(options => options.UseSqlServer(
                                               configuration.GetConnectionString("LibrosDB")));


// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
    app.UseDeveloperExceptionPage();

app.Use(async (context, next) =>
{
    await next.Invoke();

    //After going down the pipeline check if we 404'd. 
    if (context.Response.StatusCode == StatusCodes.Status404NotFound)
    {
        context.Response.Redirect("/Home/404");
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


