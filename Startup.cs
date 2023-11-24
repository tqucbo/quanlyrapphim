using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<QuanLyRapPhimDBContext>(
                (option) =>
                {
                    string connectionString = Configuration.GetConnectionString("quanLyRapPhimDBContext");
                    option.UseSqlServer(connectionString);
                }
            );

            services.AddIdentity<AppUserModel, IdentityRole>()
                    .AddEntityFrameworkStores<QuanLyRapPhimDBContext>()
                    .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(
                options =>
                {
                    // Thiết lập về mật khẩu

                    options.Password.RequireDigit = false;               // Yêu cầu số
                    options.Password.RequireLowercase = false;           // Yêu cầu có chữ thường
                    options.Password.RequireNonAlphanumeric = false;     // Yêu cầu có ký tự đặc biệt
                    options.Password.RequireUppercase = false;           // Yêu cầu có chữ hoa
                    options.Password.RequiredLength = 8;                 // Yêu cầu tối thiểu 08 ký tự

                    // Thiết lập về tạm khoá tài khoản

                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(30);  // Tạm khoá trong 30 giây
                    options.Lockout.MaxFailedAccessAttempts = 1000000;                        // Tạm khoá khi thất bại 05 lần
                    options.Lockout.AllowedForNewUsers = true;

                    // Thiết lập về người dùng

                    options.User.AllowedUserNameCharacters =            // Tên tài khoản chỉ gồm các ký tự sau.
                        "0123456789";
                    options.User.RequireUniqueEmail = true;             // Mỗi tài khoản chỉ ứng với 1 địa chỉ Email.

                    // Thiết lập đăng nhập
                    options.SignIn.RequireConfirmedEmail = false;       // Đăng nhập bằng địa chỉ Email đã xác thực
                    options.SignIn.RequireConfirmedPhoneNumber = false; // Đăng nhập bằng số điện thoại đã xác thực
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
