using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auth.Contracts;
using BearerAuthenticationApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Repository.Contracts;
using Repository.Models;
using Repository.Repository;
using Repository.Services;
using Service.Contracts;
using Service.Services;

namespace TeamNotationAPI
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
            services.AddCors();
            var key = Configuration.GetValue<string>("Secret");
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddControllers();
            services.AddScoped(typeof(NotationContext));

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressService, AddressService>();

            services.AddScoped<IAttachService, AttachService>();
            services.AddScoped<IAttachRepository, AttachRepository>();
            services.AddScoped<IBacklogRepository, BacklogRepository>();
            services.AddScoped<IImpedimentRepository, ImpedimentRepository>();
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IMockupRepository, MockupRepository>();
            services.AddScoped<INotationRepository, NotationRepository>();
            services.AddScoped<INotationService, NotationService>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IExecutionTaskRepository, ExecutionTaskRepository>();
            services.AddScoped<IExecutionTaskService, ExecutionTaskService>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddDbContext<NotationContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("myconn")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
