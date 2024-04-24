using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

System.Diagnostics.Debug.WriteLine($"@@@@ Operating System: {Environment.OSVersion} @@@@@");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // Disable HTTPS redirection in WSL
    if (!Environment.OSVersion.Platform.ToString().Equals("Unix"))
    {
        app.UseHttpsRedirection();
    }
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
