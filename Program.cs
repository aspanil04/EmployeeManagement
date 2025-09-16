using Employeemanagement.Database;
using Employeemanagement.oprations;
using Employeemanagement.services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// DIP 
builder.Services.AddDbContext<EmployeeDbContext>(
    t => t.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddTransient<IEmployeeoprations, EmployeeService>(); // Unity container memory alocation

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Specify allowed origins
            .AllowAnyMethod() // Allow all HTTP methods (GET, POST, etc.)
            .AllowAnyHeader(); // Allow all headers
    });
});

var app = builder.Build();
app.UseCors("AllowSpecificOrigins");//
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

