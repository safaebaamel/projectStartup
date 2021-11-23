using FluentValidation;
using FluentValidation.AspNetCore;
using gitlab.Controllers;
using Microsoft.OpenApi.Models;

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
    builder =>
            {
                builder.WithOrigins("http://example.com",
                                    "http://www.contoso.com");
            });
});

// Controllers
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMvc(setup => 
    {
      //...mvc setup...
    }).AddFluentValidation();

builder.Services.AddMvc()
  .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProjectValidator>());

IServiceCollection serviceCollection = builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Gitlab API",
        Description = "Consuming Gitlab Apis",
        
    });
    options.AddServer(new OpenApiServer
    {
        Url = "https://localhost/api/v4/",
        Description = "Gitlab API"
    });
    options.EnableAnnotations();
});

var app = builder.Build();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "GITLAB API V1");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);
app.Run();