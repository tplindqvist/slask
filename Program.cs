namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine(DoSomething("Tobias"));
        Console.WriteLine(DoSomething("Nisse did a bad choise"));
    }

    static string DoSomething(string name)
    {
        return $"Hello{name}";
    }
}
