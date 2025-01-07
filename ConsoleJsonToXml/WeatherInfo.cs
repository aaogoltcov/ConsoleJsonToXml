using System.Text;

namespace ConsoleJsonToXml;

public class WeatherInfo
{
    public Weather? Current;
    public Weather[]? History;

    public override string ToString()
    {
        return new StringBuilder()
            .Append("Current: ")
            .Append("\n")
            .Append(Current)
            .Append("\n")
            .Append("History: ")
            .Append("\n")
            .Append(string.Join("\n", History?.Select(value => value.ToString()) ?? Array.Empty<string>()))
            .ToString();
    }
}