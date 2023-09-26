using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! 3");

app.MapGet("/Fibonacci", 
    async () => await Fibonacci.RunAsync(new []{"44", "43"}));

app.Run();
