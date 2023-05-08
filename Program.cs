using RickAndMorty.Service.RickAndMorty.Provider;
using RickAndMorty.Service.RickAndMorty.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IRickAndMortyProvider, RickAndMortyProvider>();  
builder.Services.AddSingleton<IRickAndMortyProvider, RickAndMortyProvider>();

builder.Services.AddTransient<IRickAndMortyService, RickAndMortyService>();
builder.Services.AddSingleton<IRickAndMortyService, RickAndMortyService>();

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

app.MapControllers();

app.Run();
