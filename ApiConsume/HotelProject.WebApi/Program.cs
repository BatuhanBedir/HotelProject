using HotelProject.DataAccessLayer.Extensions;
using HotelProject.BusinessLayer.Extensions;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
builder.Services
        .AddEFCoreServices(builder.Configuration)
        .AddBusinessServices();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddNewtonsoftJson(opt=>opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

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
app.UseCors("OtelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
