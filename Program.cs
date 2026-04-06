using RhOrquestradorService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<FunctionClient>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => Results.Ok(new
{
    servico = "RH Orquestrador Service",
    descricao = "Servico que orquestra fluxos e chama Azure Functions."
}));

app.MapControllers();
app.Run();
