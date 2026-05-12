var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(options =>options.AddPolicy("All",build=>build.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()));
var app = builder.Build();
app.UseCors("All");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
