using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.Client.Pages;
using ValhallaVault.Components;
using ValhallaVault.Components.Account;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

var builder = WebApplication.CreateBuilder(args);

// Kommentar
// Kommentar 2

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<QuestionRepo>();
builder.Services.AddScoped<SegmentRepo>();
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<SubcategoryRepo>();
builder.Services.AddScoped<GenericRepo<QuestionModel>>();
builder.Services.AddScoped<GenericRepo<SegmentModel>>();
builder.Services.AddScoped<GenericRepo<SubcategoryModel>>();
builder.Services.AddScoped<GenericRepo<CategoryModel>>();



builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
            policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
            });
});


using (ServiceProvider sp = builder.Services.BuildServiceProvider())
{
    var context = sp.GetRequiredService<ApplicationDbContext>();
    var signInManager = sp.GetRequiredService<SignInManager<ApplicationUser>>();
    var roleManager = sp.GetRequiredService<RoleManager<IdentityRole>>();

    context.Database.Migrate();

    ApplicationUser newUser = new()
    {
        UserName = "adminuser@mail.com",
        Email = "adminuser@mail.com",
        EmailConfirmed = true,
    };

    ApplicationUser secondUser = new()
    {
        UserName = "user@mail.com",
        Email = "user@mail.com",
        EmailConfirmed = true,
    };

    var user = signInManager.UserManager.FindByEmailAsync(newUser.Email).GetAwaiter().GetResult();
    var user2 = signInManager.UserManager.FindByEmailAsync(secondUser.Email).GetAwaiter().GetResult();

    if (user == null && user2 == null)
    {
        // Skapa en ny user
        signInManager.UserManager.CreateAsync(newUser, "Password1234!").GetAwaiter().GetResult();
        signInManager.UserManager.CreateAsync(secondUser, "Password1234!").GetAwaiter().GetResult();
        //signInManager.UserManager.ConfirmEmailAsync(newUser);

        // Kolla om adminrollen existerar
        bool adminRoleExists = roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult();

        if (!adminRoleExists)
        {
            // Skapa adminrollen
            IdentityRole adminRole = new()
            {
                Name = "Admin",

            };
            roleManager.CreateAsync(adminRole).GetAwaiter().GetResult();
        }

        // Tilldela adminrollen till den nya anv�ndaren
        signInManager.UserManager.AddToRoleAsync(newUser, "Admin").GetAwaiter().GetResult();
    }
}

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapControllers();

app.Run();
