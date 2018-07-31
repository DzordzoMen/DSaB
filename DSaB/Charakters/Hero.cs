﻿using System;
using System.Collections.Generic;

namespace DSaB.Charakters {
  class Hero : Skeleton {

    public List<string> equipment = new List<string>();

    public Hero(int health, int attack) : base (health, attack) {
    }

    public void ShowEquipment() {
      if (HowManyItemsIsInEq(equipment.ToArray()) == 0) {
        Console.WriteLine ("Twój ekwipunek jest pusty.");
      } else {
        int i = 1;
        foreach (var item in equipment) {
          Console.WriteLine (i + ". " + item);
          i++;
        }
      }
    }

    public void AddToEquipment(string item) {
      if (HowManyItemsIsInEq(equipment.ToArray()) < 3) {
        equipment.Add(item);
      } else {
        Console.WriteLine("Twój ekwipunek jest pełny.");
      }
    }

    public void ShowAttributes() {
      Console.WriteLine("Punkty życia: " + Hero.Health);
      Console.WriteLine("Obrażenia: " + Hero.Attack);
    }

    private int HowManyItemsIsInEq(string[] equipment) {
      int itemsInEq = 0;
      for (int i = 0; i < equipment.Length; i++) {
        if (equipment[i] != null) itemsInEq++;
      }
      return itemsInEq;
    }

    public void GameOver() {
      Console.WriteLine("Game over!");
      Console.ReadKey();
      System.Environment.Exit(0);
    }
  }
}
