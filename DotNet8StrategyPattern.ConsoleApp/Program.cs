namespace DotNet8StrategyPattern.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Context context;

        context = new Context(new ConcreteStrategyA());
        context.ExecuteStrategy();

        context = new Context(new ConcreteStrategyB());
        context.ExecuteStrategy();
    }
}

public interface IStrategy
{
    void Execute();
}

public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A executed.");
    }
}

public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B executed.");
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}