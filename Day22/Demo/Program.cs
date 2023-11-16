using Demo
using Demo.Middlewares;
using Demo.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
});

// Add services to the container.
builder.Services.AddSingleton<IInstitutionService, InstitutionService>();
builder.Services.AddTransient<FactoryMiddleware1>();
builder.Services.AddTransient<FactoryMiddleware2>();
builder.Services.AddTransient<ExceptionMiddleware>();
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

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("In my middleware before api call");

//     await next(context);

//     Console.WriteLine("In my middleware after api request is processed");
// });

// app.UseMiddleware<ConventionMiddleware>();
app.UseMiddleware<FactoryMiddleware1>();
app.UseMiddleware<FactoryMiddleware2>();

app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();

app.Run();
