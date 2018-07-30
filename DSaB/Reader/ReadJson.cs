using DSaB.Scenario;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DSaB.Reader {
  class ReadJson {
    private HelpTextData ReadText(int number) {
      StreamReader sr = new StreamReader("../../Scenario/Text.json");
      string jsonFromFile = sr.ReadToEnd();
      HelpText json = JsonConvert.DeserializeObject<HelpText>(jsonFromFile);
      return json.tour[number];
    }

    private void CheckIfItemDrop(dynamic item) {
      if (item != null) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dodano do ekwipunku: " + item);
        Console.ForegroundColor = ConsoleColor.Gray;
      }
    }

    public void ReturnText(int tourNumber) { // dodac cos od walki i ktory wtedy czytac
      HelpTextData htd = ReadText(tourNumber);
      Console.WriteLine(htd.text);
      CheckIfItemDrop(htd.item);
    }
  }
}
