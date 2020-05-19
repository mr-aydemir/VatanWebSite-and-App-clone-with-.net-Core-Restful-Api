using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VatanAPI.Core.Repositories;
using VatanAPI.Core.Security.Hashing;
using VatanAPI.Core.Security.Tokens;
using VatanAPI.Core.Services;
using VatanAPI.Domain.Repositories;
using VatanAPI.Domain.Services;
using VatanAPI.Persistence;
using VatanAPI.Persistence.Contexts;
using VatanAPI.Persistence.Repositories;
using VatanAPI.Security.Hashing;
using VatanAPI.Security.Tokens;
using VatanAPI.Services;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using VatanAPI.Extensions;

namespace VatanAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))); 
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();
            //services.AddCustomSwagger();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<ISepetRepository, SepetRepository>();
            services.AddScoped<ISiparisRepository, SiparisRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<ISiparisService, SiparisService>();
            services.AddScoped<ISepetService, SepetService>();
            services.AddAutoMapper(typeof(Startup));
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddSingleton<ITokenHandler, Security.Tokens.TokenHandler>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.Configure<TokenOptions>(Configuration.GetSection("TokenOptions"));
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

             services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(jwtBearerOptions =>
                 {
                     jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters()
                     {
                         ValidateAudience = true,
                         ValidateLifetime = true,
                         ValidateIssuerSigningKey = true,
                         ValidIssuer = tokenOptions.Issuer,
                         ValidAudience = tokenOptions.Audience,
                         IssuerSigningKey = signingConfigurations.Key,
                         ClockSkew = TimeSpan.Zero
                     };
                 });
 
            services.AddAutoMapper(this.GetType().Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseCustomSwagger();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
