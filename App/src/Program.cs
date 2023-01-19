namespace App;
public partial class Program
{
    private static int Main(string[] args)
    {
        var algo = default(Algorithm);
        if (args.Length == 1)
        {
            var inputStream = File.OpenRead(args[0]);
            var inputReader = new StreamReader(inputStream);
            algo = new Algorithm(inputReader, Console.Out);
        }
        else
        {
            algo = new Algorithm(Console.In, Console.Out);
        }

        return algo.Run();
    }
}