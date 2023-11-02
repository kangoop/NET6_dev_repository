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

            //���� ����
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


            app.MapControllers();// Ư�� ����� ��Ʈ�ѷ��� ����


            //��Ģ��� or Ư������� ��Ʈ�ѷ� �� ��� ���� 
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