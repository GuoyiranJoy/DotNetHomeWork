using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Homework12.Models;

namespace Homework12
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

            //使用MySql数据库，配置连接字符串和Mysql的版本
            //这里创建了一个单例DbContext对象，用于实现依赖注入
            services.AddDbContextPool<OrderContext>(
                 options => options.UseMySql("Server=localhost;Database=orderDb2;User=root;Password=123456;", // replace with your Connection String
                    //  mySqlOptions =>
                    //  {
                    //      mySqlOptions.ServerVersion(new Version(5, 7, 30), ServerType.MySql); // replace with your Server Version and Type
                    // }
                    new MySqlServerVersion(new Version(8,0,24))
             ));

            //添加一个 OrderService对象，用于依赖注入
            services.AddScoped<OrderService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //去掉swagger
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }else {
                app.UseHsts();
            }

            app.UseHttpsRedirection();//启动http到https的重定向

            app.UseRouting();//将路由组件添加到app中

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//启动映射，将url路由到控制器
            });
        }
    }
}
