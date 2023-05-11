using Example.BAL.Implementation;
using Example.BAL.Interface;
using Example.DAL.Implementation;
using Example.DAL.Interface;
using Example.DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CompanyDbContext>(x => x.UseSqlServer("Data Source=RSPLLT423\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True; TrustServerCertificate=True"));
builder.Services.AddTransient<CompanyDbContext>();

builder.Services.AddTransient<IEmployee, EmployeeRepo>();
builder.Services.AddTransient<IEmployeeBO, EmployeeBO>();

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
