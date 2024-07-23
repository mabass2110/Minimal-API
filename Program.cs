
var builder = WebApplication.CreateBuilder(args); //creating a builder
var app = builder.Build(); //constructing an app instance using builder

app.MapGet("/", () => "Hello World!");

app.Run();

