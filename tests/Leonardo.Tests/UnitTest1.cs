namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var results = await Fibonacci.RunAsync(new string[] { "44", "22" });
        Assert.Equal(701408733, results[0]);
        Assert.Equal(17711, results[1]);
    }
}