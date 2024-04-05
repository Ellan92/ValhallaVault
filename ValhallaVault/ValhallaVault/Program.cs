using Blazored.Modal;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.CallesMiddleware;
using ValhallaVault.Client.Pages;
using ValhallaVault.Components;
using ValhallaVault.Components.Account;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.EliasMiddleware;
using ValhallaVault.EmeliesMiddleware;
using ValhallaVault.Models;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddScoped<CompletedSubcategoryRepo>();
builder.Services.AddScoped<CompletedSegmentRepo>();
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
builder.Services.AddScoped<ValhallaVault.Managers.CompletedSubcategoryManager>();
builder.Services.AddScoped<ValhallaVault.Managers.CompletedSegmentManager>();
builder.Services.AddScoped<ValhallaVault.Managers.CompletionManager>();

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
    .AddSignInManager<SignInManager<ApplicationUser>>()    // definiera vilken user som ska g√§lla f√∂r signinmanager. 
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

        // Tilldela adminrollen till den nya anv√§ndaren
        signInManager.UserManager.AddToRoleAsync(newUser, "Admin").GetAwaiter().GetResult();
    }
}*/

builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-CSRF-TOKEN"; // Anv‰nd samma namn som i din klientkod
});

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


app.UseMiddleware<Middleware>();  // Emelie 


app.UseMiddleware<LogURLMiddleware>(); // Calle
app.UseLogUrl(); // Calle

app.UseHttpsRedirection();

app.UseMiddleware<RequestMiddleware>(); // Elias

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseAntiforgery();



app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Auth).Assembly);



// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();


app.MapControllers();

app.UseCors("AllowAll");
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Farre
//Farres Middleware 
//k‰llor:
//https://www.youtube.com/watch?v=2Gv71TvkroI
//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0
//https://www.tutorialsteacher.com/core/aspnet-core-middleware

// finns tre metoder som man kan configuera request.
// -run
//vet inget om n‰sta middleware och anv‰nds fˆr att executa. end of pipeline
// -use 
// anv‰nds vid anv‰nding av flera middlewares.
// -Map
//Uppfattar det som att n‰r en request gˆrs sÂ j‰mfˆr den med den angivna v‰gen.

//
app.Map("/Farre", name =>
{
    name.Run(async context =>
    {
        await context.Response.WriteAsync("Du har skrivit in Farre i HTTP req.");
    });
    //Om man skriver Farre sÂ kommer det visa "Du har skrivit in Farre i HTTP req."
});


//Anv‰nder flera middlewares. fˆr att visa "This is a Middleware"
app.Use(async (context, next) =>
{
    Console.WriteLine("fˆre en HTTP fˆrfrÂgan");
    await next();
    Console.WriteLine("Efter HTTP fˆrfrÂgan");
});

//en enkel Middleware - end of pipeline
//app.Run(async context =>
//{

//    await context.Response.WriteAsync("This is a Middleware");
//});

//============================================================================ Farre


app.Run();
