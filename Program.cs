using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SavManagementApp.Data; // Remplacez par votre espace de noms contenant AppDbContext

var builder = WebApplication.CreateBuilder(args);

// Configuration de la connexion à la base de données
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("La chaîne de connexion 'DefaultConnection' est introuvable dans appsettings.json.");
    }
    options.UseSqlServer(connectionString);
});

// Ajouter Identity pour la gestion des utilisateurs et des rôles
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Ajouter les services MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuration du pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Configurer HSTS (Strict-Transport-Security)
}

app.UseHttpsRedirection(); // Redirection vers HTTPS
app.UseStaticFiles();      // Support des fichiers statiques (CSS, JS, etc.)

app.UseRouting();          // Configuration du routage

app.UseAuthentication();   // Gestion de l'authentification
app.UseAuthorization();    // Gestion des autorisations

// Configuration du routage par défaut
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();