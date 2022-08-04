var builder = WebApplication.CreateBuilder(args);

//Any time you add a service, the line has to go before var app = builder.Build(); since that builds it. YOu want to add before building
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // like css file in wwwroot/css
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();