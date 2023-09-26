// See https://aka.ms/new-console-template for more information

using Leonardo;

var results = Fibonacci.RunAsync(args);
Console.WriteLine($"Finished");
results.Wait();