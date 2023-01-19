namespace App;
public class Algorithm
{
    private readonly TextReader input;
    private readonly TextWriter output;

    public Algorithm(TextReader input, TextWriter output)
    {
        this.input = input;
        this.output = output;
    }
    public int Run()
    {
        output.WriteLine("Hello Brute!");
        return 0;
    }
}