using Financias.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Financias.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Financias
{
    public class Program
    {
        public static void Main(string[] args)
        {

string connectionString = "server=0.0.0.0;port=5432;database=clientes;user id=postgres;password=toorpos;";

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();
    // Execute SQL statements here

    string sql = "INSERT INTO cliente (id, name, description, phone) VALUES (@id, @name, @description, @phone)";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        

        command.ExecuteNonQuery();
    }
    connection.Close();
}
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddDbContext<PeopleContext>(opt => opt.UseInMemoryDatabase("People"));

            builder.Services.AddQuickGridEntityFrameworkAdapter();;

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
