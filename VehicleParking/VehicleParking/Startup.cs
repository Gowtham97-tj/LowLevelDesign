using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VehicleParking.Common;
using VehicleParking.Repository;
using VehicleParking.Service;
using BuildingBlocks.DataAccess;
using Microsoft.OpenApi.Models;

namespace VehicleParking
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        IApiSetting _apiSettings = null;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _apiSettings = new ApiSetting(Configuration);
            services.AddControllers();
            services.AddSingleton<IParkingService, ParkingService>();
            services.AddSingleton<IParkingRepository, ParkingRepository>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IParkingSpaceService, ParkingSpaceService>();
            services.AddSingleton<IParkingSpaceRepository, ParkingSpaceRepository>();
            services.AddSingleton<IParkingLotService, ParkingLotService>();
            services.AddSingleton<IParkingLotRepository, ParkingLotRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Parking API", Version = "v1" });
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Park Your Vehicle");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
