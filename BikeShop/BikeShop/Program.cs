using BikeShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BikeShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var ConnectionStrings = builder.Configuration.GetSection("ConnectionStrings")["Default"];

            //서비스 주입
            builder.Services.AddDbContext<ProductionDbContext>(options =>
            options.UseSqlServer(ConnectionStrings));

            builder.Services.AddHttpContextAccessor();

            // Add services to the container.
            builder.Services.AddControllersWithViews();


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


            app.MapControllers();// 특성 라우팅 컨트롤러를 매핑


            //규칙기반 or 특성라우팅 컨트롤러 를 모두 맵핑 
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/");

            //app.MapControllerRoute(
            //    name: "controllerAction",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}