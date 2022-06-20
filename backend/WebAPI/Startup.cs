
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Entity.Context;
using AutoMapper;
using StockPriceMonitor.Repository.Interfaces;
using StockPriceMonitor.Repository.Implementation;
using Domain.SourceDomain;
using Repository.Interfaces;
using Domain.TickerDomain;
using Repository.Implementation;
using Domain.PriceDomain;

namespace FuelTracker.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRepository();           
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost", "http://localhost:4200", "http://localhost:3000")
                                        .AllowAnyHeader()
                                .AllowAnyMethod();
                });
            });

           
          
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddTransient<ISourceRepository, SourceRepository>();
            services.AddTransient<ISourceService, SourceService>();
            services.AddTransient<ITickerRepository, TickerRepository>();
            services.AddTransient<ITickerService,TickerService>();
            services.AddTransient<IPriceRepository, PriceRepository>();
            services.AddTransient<IPriceService, PriceService>();
            services.AddTransient<IPriceMapper, PriceMapper>();

            services.AddDbContext<PriceMonitorDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("priceDbConnect")));           
            
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);           

           // services.AddDefaultIdentity<ApplicationUser>().AddEntityFrameworkStores<AthenticationContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Stock Price Monitor API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stock Price Monitor API");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
