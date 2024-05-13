using Academia.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Services.AddInfrastructure(builder.Configuration);


app.Run();
