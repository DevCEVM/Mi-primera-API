using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // 🔹 MySQL 5.7.19
            var server57 = new MySqlServerVersion(new Version(5, 7, 19));

            // 🔹 DbContext para base 'sah'
            builder.Services.AddDbContext<LazaroDbContext>(options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("DbLazaro"),
                    server57
                )
            );

            // 🔹 DbContext para base 'sah_hrsj_valle'
            builder.Services.AddDbContext<ValleDbContext>(options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("DbValle"),
                    server57
                )
            );

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
