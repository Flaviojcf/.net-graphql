using Data;
using Microsoft.EntityFrameworkCore;
using TransferPay.Data.Context;

namespace graphqlAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddGraphQLServer().AddQueryType<Query>()
                                   .AddProjections()
                                   .AddFiltering()
                                   .AddSorting();

            var app = builder.Build();

            CreateDatabase(app);


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGraphQL("/graphql");

            app.Run();


            static void CreateDatabase(WebApplication app)
            {
                var serviceScope = app.Services.CreateScope();
                var dataContext = serviceScope.ServiceProvider.GetService<MyDbContext>();
                dataContext?.Database.EnsureCreated();
            }
        }
    }
}