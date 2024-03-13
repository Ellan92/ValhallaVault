using Blazored.Modal;
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

// Repos
builder.Services.AddScoped<QuestionRepo>();
builder.Services.AddScoped<SegmentRepo>();
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<SubcategoryRepo>();
builder.Services.AddScoped<UserRepo>();
builder.Services.AddScoped<GenericRepo<QuestionModel>>();
builder.Services.AddScoped<GenericRepo<SegmentModel>>();
builder.Services.AddScoped<GenericRepo<SubcategoryModel>>();
builder.Services.AddScoped<GenericRepo<CategoryModel>>();
builder.Services.AddScoped<GenericRepo<ApplicationUser>>();
builder.Services.AddScoped<GenericRepo<ResultModel>>();

// Managers
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<CategoryModel>>();
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<SegmentModel>>();
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<SubcategoryModel>>();
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<QuestionModel>>();
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<ApplicationUser>>();
builder.Services.AddScoped<ValhallaVault.Managers.GenericManager<ResultModel>>();
builder.Services.AddScoped<ValhallaVault.Managers.SegmentManager>();
builder.Services.AddScoped<ValhallaVault.Managers.Factory>();
builder.Services.AddScoped<ValhallaVault.Managers.UserManager>();
builder.Services.AddScoped<ValhallaVault.Managers.SubcategoryManager>();
builder.Services.AddScoped<ValhallaVault.Managers.QuestionManager>();
builder.Services.AddScoped<ValhallaVault.Managers.CategoryManager>();

// ge detaljerade error-meddelanden 
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

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
    .AddSignInManager<SignInManager<ApplicationUser>>()    // definiera vilken user som ska gälla för signinmanager. 
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


/*using (ServiceProvider sp = builder.Services.BuildServiceProvider())
{
    var context = sp.GetRequiredService<ApplicationDbContext>();
    var signInManager = sp.GetRequiredService<SignInManager<ApplicationUser>>();
    var roleManager = sp.GetRequiredService<RoleManager<IdentityRole>>();

    //context.Database.Migrate();

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

        // Tilldela adminrollen till den nya användaren
        signInManager.UserManager.AddToRoleAsync(newUser, "Admin").GetAwaiter().GetResult();
    }
}*/
builder.Services.AddBlazoredModal();

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
    .AddAdditionalAssemblies(typeof(Auth).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapControllers();

app.Run();
