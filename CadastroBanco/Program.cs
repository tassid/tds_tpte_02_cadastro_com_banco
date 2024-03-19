var construtor = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
construtor.Services.AddControllers();
construtor.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "MinimalApiProducts", Version = "v1" });
});

var app = construtor.Build();

// Configurar o pipeline de solicitação HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MinimalApiProducts v1");
});

app.MapControllers();

app.Run();
