var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Lesson}/{action=Index}/{id?}");
//app.MapGet("/", () => "Hello World!");


app.Run();