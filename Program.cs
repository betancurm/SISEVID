using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SISEVID;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddServerSideBlazor();
builder.Services.AddSqlServer<SisevidContext>(builder.Configuration.GetConnectionString("cnSisevid"));
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

app.MapBlazorHub();  

app.MapGet("/dbconexion",async([FromServices] SisevidContext dbContext)=>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria "+ dbContext.Database.IsInMemory());
});

app.Run();
