using System;
using System.Collections.Generic;
using System.Linq;

namespace DSaB.Charakters {
  class Hero : Skeleton {

    public List<string> Equipment = new List<string>();

    public Hero(int health, int attack) : base (health, attack) {
    }

    public void ShowEquipment() {
      if (HowManyItemsIsInEq(Equipment.ToArray()) == 0) {
        Console.WriteLine ("Twój ekwipunek jest pusty.");
      } else {
        var i = 1;
        foreach (var item in Equipment) {
          Console.WriteLine (i + ". " + item);
          i++;
        }
      }
    }

    public void AddToEquipment(string item) {
      if (HowManyItemsIsInEq(Equipment.ToArray()) < 3) {
        Equipment.Add(item);
      } else {
        Console.WriteLine("Twój ekwipunek jest pełny.");
      }
    }

    public void ShowAttributes() {
      Console.WriteLine("Punkty życia: " + Health);
      Console.WriteLine("Obrażenia: " + AttackPower);
    }

    private int HowManyItemsIsInEq(string[] equipment) {
      return equipment.Count(e => e != null);
    }

    public void GameOver() {
      Console.WriteLine("Game over!");
      Console.ReadKey();
      System.Environment.Exit(0);
    }
  }
}
