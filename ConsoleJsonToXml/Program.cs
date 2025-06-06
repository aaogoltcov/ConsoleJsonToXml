﻿using System.Text.Json;
using System.Xml.Serialization;
using ConsoleJsonToXml;

// task 1
var xmlFile = """
              <?xml version="1.0" encoding="utf-8"?>
              <Data.Root xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                  
                  <Data.Root.Names>
                      <Name>Name1</Name>
                      <Name>Name2</Name>
                      <Name>Name3</Name>
                  </Data.Root.Names>
                  
                  <Data.Entry LinkedEntry="Name1">
                      <Data.Name>Name2</Data.Name>
                  </Data.Entry>
                  
                  <Data_x0023_ExtendedEntry LinkedEntry="Name2">
                      <Data.Name>Name1</Data.Name>
                      <Data_x0023_Extended>NameOne</Data_x0023_Extended>
                  </Data_x0023_ExtendedEntry>
                  
              </Data.Root>
              """;

var dataRoot = new DataRoot
{
    Names = new string[] { "Name1", "Name2", "Name3" },
    Entry = new DataEntry
    {
        LinkedEntry = "Name1",
        Name = "Name2"
    },
    ExtendedEntry = new DataExtendedEntry
    {
        LinkedEntry = "Name2",
        Name = "Name1",
        ExtendedName = "NameOne"
    }
};


var serializer = new XmlSerializer(typeof(DataRoot));

serializer.Serialize(Console.Out, dataRoot);

// task 2
var jsonFile =
    "{\"Current\":{ \"Time\": \"2023-06-18T20:35:06.722127+04:00\", \"Temperature\":29 , \"Weathercode\": 1, \"Windspeed\" : 2.1, \"Winddirection\" : 1}, \"History\": [{ \"Time\":\"2023-06-17T20:35:06.77707+04:00\", \"Temperature\": 29, \"Weathercode\": 2, \"Windspeed\" : 2.4 , \"Winddirection\":1},{ \"Time\": \"2023-06-16T20:35:06.777081+04:00\", \"Temperature\":22 , \"Weathercode\": 2, \"Windspeed\" : 2.4, \"Winddirection\":1},{ \"Time\": \"2023-06-15T20:35:06.777082+04:00\", \"Temperature\": 21, \"Weathercode\": 4, \"Windspeed\":2.2 ,\"Winddirection\":1}]}";

var weather = JsonSerializer.Deserialize<WeatherInfo>(jsonFile, new JsonSerializerOptions() { IncludeFields = true });

Console.WriteLine(weather);

// task 3
var weatherXmlSerializer = new XmlSerializer(typeof(WeatherInfo));

weatherXmlSerializer.Serialize(Console.Out, weather);
