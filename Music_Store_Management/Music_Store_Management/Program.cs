using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Music_Store_Management.context;
using Music_Store_Management.Profiles;

namespace Music_Store_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MusicStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connections")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper(typeof(CustomerProfile));

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

            app.MapControllers();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Convention-based routing
            //app.MapControllerRoute(
            //   name: "MoviesByReleaseDate",
            //   pattern: "{controller=Movies}/{action=ByReleaseDate}/{year:int:range(2015,2016)}/{month:regex(^\\d{{2}}$)}");

            app.Run();
        }
    }
}
