using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Configuration
{
    public static class ApiConfiguration
    {
        public static void AddApiConfiguration(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthorization();

            DependencyResolver.ResolveDependencies(builder);

            builder.Services.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureApi(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
