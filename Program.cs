var builder = WebApplication.CreateBuilder(args);

//builder.Logging.AddJsonConsole();

// Add services to the container.

var app = builder.Build();

app.Logger.LogInformation("A INFORMATION log ...");


// Configure the HTTP request pipeline.

app.MapGet("/factorial/{nbr:int}", (int nbr) => {
    if (nbr > 25) 
        return Results.BadRequest("Max factorial number is 25");
    int factorial = 1;
    for(int i = 2; i <= nbr; i++) {
        factorial *= i;
    }
    return Results.Ok(factorial);
});

app.Run("http://localhost:5432");
