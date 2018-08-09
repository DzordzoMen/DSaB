using DSaB.Scenario;
using DSaB.Charakters;
using DSaB.Mechanics;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DSaB.Reader {
  class ReadJson {
    private static Hero MyHero { get; set; }

    public ReadJson(Hero hero) {
      MyHero = hero;
    }

    private HelpTextData ReadText(int number) {
      StreamReader sr = new StreamReader("../../Scenario/Text.json");
      string jsonFromFile = sr.ReadToEnd();
      HelpText json = JsonConvert.DeserializeObject<HelpText>(jsonFromFile);
      return json.Tour[number];
    }

    private void CheckIfItemDrop(dynamic item) { // enemy
      if (item != null) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dodano do ekwipunku: " + item);
        Console.ForegroundColor = ConsoleColor.Gray;
      }
    }

    private EnemyUnit ReadEnemy(string enemyName) {
      string pathToEnemy = "../../Scenario/Enemies/" + enemyName + ".json";
      StreamReader sr = new StreamReader(pathToEnemy);
      string enemyFromFile = sr.ReadToEnd();
      EnemyUnit enemyJson = JsonConvert.DeserializeObject<EnemyUnit>(enemyFromFile);
      return enemyJson;
    }

    private void CheckIfMeetEnemy(dynamic enemy) {
      if (enemy != null) {
        FightTime(enemy, MyHero);
      }
    }


    public void ReturnText(int tourNumber, Hero hero) { // dodac cos od walki i ktory wtedy czytac
      HelpTextData htd = ReadText(tourNumber);
      Console.WriteLine(htd.Text);
      CheckIfMeetEnemy(htd.Enemy);
      CheckIfItemDrop(htd.Item);
    }

    public void FightTime(string enemyName, Hero hero) {
      EnemyUnit newEnemy = ReadEnemy(enemyName);
      Console.WriteLine("Podczas swojej podróźy napotykasz " + newEnemy.Name);
      Fight fg = new Fight();
      fg.FightBeetween(newEnemy, hero);
    }
  }
}
