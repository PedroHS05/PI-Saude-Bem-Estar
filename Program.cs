using LoginCadastroMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=KERNELOS-PC\\SQLSERVER2022;Database=LoginCadastroDB;Trusted_Connection=True;TrustServerCertificate=True;"));



builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Adiciona a sessão

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession(); // Usa a sessão
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
