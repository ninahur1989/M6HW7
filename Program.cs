
var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(
        builder => builder.AllowAnyOrigin())
           );

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();


app.MapControllers();

app.Run();
