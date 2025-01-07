using System.Text;

namespace ConsoleJsonToXml;

public class Weather
{
    public DateTime? Time;
    public float? Temperature;
    public int? Weathercode;
    public float? Windspeed;
    public int? Winddirection;

    public override string ToString()
    {
        return new StringBuilder()
            .Append("Time")
            .Append(": ")
            .Append(Time)
            .Append(" ")
            .Append("Temperature")
            .Append(": ")
            .Append(Temperature)
            .Append(" ")
            .Append("Weathercode")
            .Append(": ")
            .Append(Weathercode)
            .Append(" ")
            .Append("Windspeed")
            .Append(": ")
            .Append(Windspeed)
            .Append(" ")
            .Append("Winddirection")
            .Append(": ")
            .Append(Winddirection)
            .ToString();
    }
}