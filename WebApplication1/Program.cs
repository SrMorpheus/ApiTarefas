using APITAREFA.Dados;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services
    .AddDbContext<ApiTarefaContexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TarefaDB"),
builder =>
{
    builder.EnableRetryOnFailure(20, TimeSpan.FromSeconds(10), null);
}


    ));





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
