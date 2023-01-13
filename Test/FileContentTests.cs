namespace E2E;

[TestClass]
public class InOut
{
    private static IEnumerable<object[]> GetDataPub()
    {
        return Directory.GetFiles("datapub").Order().Chunk(2);
    }

    [TestMethod]
    [Timeout(60_000)]
    [DynamicData(nameof(GetDataPub), DynamicDataSourceType.Method)]
    public void DataPub(string inputPath, string outputPath)
    {
        using var inputStream = File.OpenRead(inputPath);
        using var outputStream = File.OpenRead(outputPath);
        using var inputReader = new StreamReader(inputStream);
        using var outputReader = new StreamReader(outputStream);

        using var outputWriterStream = new MemoryStream();
        using var outputWriter = new StreamWriter(outputWriterStream);
        var returnValue = App.Program.Run(inputReader, outputWriter);
        outputWriter.Flush();

        outputWriterStream.Position = 0;
        var outputWriterStreamReader = new StreamReader(outputWriterStream);
        Assert.AreEqual(0, returnValue);
        Assert.AreEqual(outputReader.ReadToEnd(), outputWriterStreamReader.ReadToEnd());
    }
}


