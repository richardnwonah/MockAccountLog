//using MockBankApi.Data;
//using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using MockBankApi.Services;
using System.Data.SQLite;


var builder = WebApplication.CreateBuilder(args);
//using MockBankApi.Data;
//using System.Data.SqlClient;
//builder.Services.AddDbContext<StagingDbContext>(options =>
//using MockBankApi.Data;
//using System.Data.SqlClient;
//options.UseSqlite("Data Source=Database.db"));
  //  options.UseSqlServer("Server=localhost;Database=CAVDemoBank;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;Encrypt=False"));

// Add services to the container.

//builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
//            options.UseSqlServer("Server=localhost;Database=CAV;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;Encrypt=False"));


builder.Services.AddControllers();
builder.Services.AddScoped<IAccountService, AccountService>();
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
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
