using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StocksManagement.Application.RepositoryInterfaces.Repositories;
using StocksManagement.Application.Services;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.RepositoryInterfaces.Repositories;
using StocksManagement.Infrastructure.Data.Repositories;
using StocksManagement.Infrastructure.Mapper;
using StocksManagement.Infrastructure.Persistence;
using System.Text;


// Variable declarations
var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


// Authorization, Policy and Cord
builder.Services.AddAuthentication(auth =>      // asta am adaugat
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
        ValidateIssuer = false,
        ValidateAudience = false,

    };
});

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
    opt.AddPolicy("RequireUserRole", policy => policy.RequireRole("Member"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
                      });
});

// Services & Repositories
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IStorageRepository, StorageRepository>();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<IStorageService, StorageService>();

// Add Controllers & Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connection, b => b.MigrationsAssembly("StocksManagement.Infrastructure"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<ApplicationDbContext>();
    await context.Database.MigrateAsync();
    await DataSeed.Seed(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
