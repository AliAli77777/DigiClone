using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowNextJs", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

    app.MapOpenApi();

    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseCors("AllowNextJs");
app.UseAuthorization();
app.MapControllers();

app.Run();
