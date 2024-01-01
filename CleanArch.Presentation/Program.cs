using CleanArch.Infra.Context;
using CleanArch.Infra;
using CleanArch.App.Services;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("Sqlite");
builder.Services.ConfigurePersistenceApp(connectionString);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void CreateDatabase(WebApplication app)
{
  using var scope = app.Services.CreateScope();
  var services = scope.ServiceProvider;
  try
  {
    var context = services.GetRequiredService<AppDbContext>();
    context?.Database.EnsureCreated();
  } 
  catch(Exception e)
  {
    throw new ApplicationException("Error to seedDatabase", e);
  }
}