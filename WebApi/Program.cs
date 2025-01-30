using BuisnessLogic;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBuisnessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseCors("AllowAll");

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();