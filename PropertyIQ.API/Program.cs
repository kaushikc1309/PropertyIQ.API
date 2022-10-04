using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using PropertyIQ.Domain.Repository;
using PropertyIQ.Infrastructure;
using PropertyIQ.Infrastructure.Repository;
using PropertyIQ.ServiceAbstractions.Services;
using PropertyIQ.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add service to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IPropertyService, PropertyService>();
//builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme).
//    AddOpenIdConnect(options => { options.ResponseType = "id_token"; }).
//          AddMicrosoftIdentityWebApp(builder.Configuration, "AzureAd");
//var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
//builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["ApplicationInsights:InstrumentationKey"]);
//var kvUri = "https://YOURVAULTNAME.vault.azure.net/";
//var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
//KeyVaultSecret secret = await client.GetSecretAsync("SECRETNAME");
//var connectionString = secret.Value.ToString();
var connectionString = "Test connection string";
builder.Services.AddDbContext<RepositoryDbContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();