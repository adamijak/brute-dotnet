namespace App;
public partial class Program
{
    private static int Main(string[] args) => Run(Console.In, Console.Out);
    public static int Run(TextReader input, TextWriter output)
    {
        output.WriteLine("Hello Brute!");
        return 0;
    }
}