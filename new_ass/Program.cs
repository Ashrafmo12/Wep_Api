using Microsoft.EntityFrameworkCore;
using new_ass.DATA;
using new_ass.Repo.Appoiment_repo;
using new_ass.Repo.Doctor_repo;
using new_ass.Repo.Patient_repo;
using new_ass.Repo.Prescription_repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Appdbcontext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("data")));
builder.Services.AddScoped<IPatient,Patientt>();
builder.Services.AddScoped<IDoctor,Docrorr>();
builder.Services.AddScoped<Iappoiment,appoimentt>();
builder.Services.AddScoped<Iprescription,prescriptionn>();
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
