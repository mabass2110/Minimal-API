using Microsoft.OpenApi.Models;
using PizzaStore.DB;

var builder = WebApplication.CreateBuilder(args);

//Using builder services such as SwaggerGen and Endpoints API explorer
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "Making the Pizzas you love", Version = "v1" });
});

//App instatiation
var app = builder.Build();

 
if (app.Environment.IsDevelopment())
{
   // Swagger middleware
   app.UseSwagger();
   app.UseSwaggerUI(c =>
   {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
   });
}
//GET,POST, PUT and DELETE Routes
app.MapGet("/", () => "Hello World!");

app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));

app.MapGet("/pizzas", () => PizzaDB.GetPizzas());

app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));

app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));

app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));

//This command initializes the API
app.Run();
