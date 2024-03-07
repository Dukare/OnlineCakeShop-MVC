using Microsoft.EntityFrameworkCore;
using OnlineCakeShop.DataAccessLayer;
using System.Configuration;
using Microsoft.AspNetCore.Identity;
using OnlineCakeShop.DataAccessLayer.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace OnlineCakeShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<OnlineCakeShopDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            builder.Services.AddScoped<IEmailSender,EmailSender>();
            builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<OnlineCakeShopDbContext>();

            builder.Services.AddScoped<UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}