using GalaxyExpress.API.Mapping.Configurations;
using GalaxyExpress.BLL.Services;
using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.DAL.Bogus;
using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Entities.Identity;
using GalaxyExpress.DAL.Repositories;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


#region SERVICES
{
    #region API
    {
        // Logging
        builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerFactory, LoggerFactory>());
        builder.Services.TryAdd(ServiceDescriptor.Singleton(typeof(ILogger<>), typeof(Logger<>)));

        // DbContext
        builder.Services.AddDbContext<GalaxyExpressDbContext>(options =>
        {
            options.UseSqlServer(
                    configuration.GetConnectionString("sqlServerConnection"),
                    op => op.MigrationsAssembly("GalaxyExpress.API")
                );
        });

        #region IDENTITY
        {
            // Reads data from our previously created JWT Section of appsettings.json
            builder.Services.Configure<JWT>(configuration.GetSection("JWT"));

            // Register ASP.NET Core Identity with method AddIdentity<TUser, TRole>
            builder.Services.AddIdentity<User, IdentityRole<Guid>>()
                // To register the required EFCore implementation of Identity stores
                .AddEntityFrameworkStores<GalaxyExpressDbContext>()
                .AddDefaultTokenProviders();
            // Adding Authentication
            builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                // Adding JwtBearer
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,

                        ValidIssuer = configuration["JWT:Issuer"],
                        ValidAudience = configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(configuration["JWT:Key"] ?? "C1CF4B7AC4D2161B6695DC4F55AA3AA23ACCA53A"))
                    };
                });
        }
        #endregion

        builder.Services.RegisterMapsterConfiguration(); // Mapster
    }
    #endregion

    #region BLL
    {
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IEmailService, EmailService>();
        builder.Services.AddScoped<IPhoneNumberService, PhoneNumberService>();
        builder.Services.AddScoped<IPaymentCardService, PaymentCardService>();
        builder.Services.AddScoped<IParcelMachineService, ParcelMachineService>();
        builder.Services.AddScoped<IPostBranchService, PostBranchService>();
    }
    #endregion

    #region DAL
    {
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IEmailRepository, EmailRepository>();
        builder.Services.AddScoped<IPhoneNumberRepository, PhoneNumberRepository>();
        builder.Services.AddScoped<IPaymentCardRepository, PaymentCardRepository>();
        builder.Services.AddScoped<IParcelMachineRepository, ParcelMachineRepository>();
        builder.Services.AddScoped<IPostBranchRepository, PostBranchRepository>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
    #endregion
}
#endregion


builder.Services.AddControllers();

// Register a Swagger generator by defining 1 or more Swagger documents
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Galaxy Express",
        Version = "v1",
        Description = "API for performing operations with \"Galaxy Express\""
    });

    // CUstomizing the comment path for Swagger JSON and UI
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    option.IncludeXmlComments(xmlPath);
});


//DataGenerator.InitBogusData(); // seeding db
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = "swagger";
    });
}


// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();