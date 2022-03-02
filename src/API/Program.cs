using API.Configuration;

var builder = WebApplication.CreateBuilder(args);

ApiConfiguration.AddApiConfiguration(builder);

var app = builder.Build();

ApiConfiguration.ConfigureApi(app);
