using DemoWebApiForAppService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRedirectTo(from: "/index.html", to: "/swagger");

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
