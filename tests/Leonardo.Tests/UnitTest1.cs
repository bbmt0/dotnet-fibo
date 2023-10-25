using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.EventHandlers;

namespace Leonardo.Tests;

public class UnitTest1
{
    
    [Fact]
    public async void Test1()
    {
        var builder = new DbContextOptionsBuilder<FibonacciDataContext>();
        var dataBaseName = Guid.NewGuid().ToString();
        builder.UseInMemoryDatabase(dataBaseName);

        var options = builder.Options;
        var fibonacciDataContext = new FibonacciDataContext(options);
        await fibonacciDataContext.Database.EnsureCreatedAsync();
        
        var results = await new Fibonacci(fibonacciDataContext).RunAsync(new[] { "40", "41", "42" });
        Assert.Equal(3, results.Count);
        Assert.Equal(165580141, results[0]);
        Assert.Equal(267914296, results[1]);
        Assert.Equal(433494437, results[2]);
    }
}