using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using PlayRiggedGames.DataAccess;
using PlayRiggedGames.DataAccess.Data;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service;
using PlayRiggedGames.Service.EmailServices;

namespace PlayRiggedGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region User Secrets stuff
            // implments user secrets
            builder.Configuration.AddUserSecrets<Program>();

            // actually grabs connection string from secret
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            #endregion

            #region DbContext stuff
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            #endregion

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Services Injection stuff 
            builder.Services.AddScoped<IRiggedDataAccess, ApplicationDbContext>();
            builder.Services.AddScoped<IRiggedService, RiggedService>();
            #endregion

            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

            //Makes it so a user must have a unique email address to create an account
            builder.Services.Configure<IdentityOptions>(options => options.User.RequireUniqueEmail = true);

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireRoleAdmin",
                        policy => policy.RequireRole("Admin"));
            });

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
            app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}