using LoginCadastroMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
<<<<<<< HEAD
    options.UseSqlServer(@"Server=LAB02-D08\SQLEXPRESS;Database=LoginCadastroDB;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
=======
    options.UseSqlServer("Server=KERNELOS-PC\\SQLSERVER2022;Database=LoginCadastroDB;Trusted_Connection=True;TrustServerCertificate=True;"));



builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Adiciona a sessão
>>>>>>> 6d39d0f1343eaba7d532b97a644cf13951c01201

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
<<<<<<< HEAD
app.UseSession();

=======
app.UseSession(); // Usa a sessão
>>>>>>> 6d39d0f1343eaba7d532b97a644cf13951c01201
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
