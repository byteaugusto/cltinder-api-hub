using CltinderApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<LikeService>();
builder.Services.AddSingleton<MatchService>();
builder.Services.AddControllers();
builder.Services.AddSingleton<UsuarioService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();