using API.General.Classes.Configure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/// <summary>
/// This method gets called by the runtime. Use this method to add services to the container.
/// </summary>






//Conection to data base
DatabaseConfigure.ConfigureService(builder.Services, builder);
//Dependency Injection
DependencyInjectionConfigure.ConfigureService(builder.Services);
//Globalization Configure service
GlobalizationConfigure.ConfigureService(builder.Services);



WebApplication app = builder.Build();

//Globalization Configure
GlobalizationConfigure.Configure(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

