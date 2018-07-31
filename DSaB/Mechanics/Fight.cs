using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaB.Charakters;

namespace DSaB.Mechanics {
  class Fight {
    private double Attack(int attackPower) {
      Random rnd = new Random();
      int value = rnd.Next(0, 100);

      if (value > 75) {
        return attackPower * 2;
      } else if (value < 75 && value > 50) {
        return attackPower * 0.50;
      } else if (value < 50 && value > 25) {
        return attackPower * 0.25;
      } else {
        return attackPower * 0.1;
      }
    }

    private bool CheckIfDead(Object target) {
      if (target.Health == 0) return true;
      return false;
    } 

    private double SetAttack(Object target) {
      return Attack(target.AttackPower);
    }

    private void CheckWhoWin(EnemyUnit enemy, Hero hero) {
      if (HealthEqualZero(enemy)) {
        Console.WriteLine("Brawo wygrałeś");
        if (enemy.EnemyDropItem()) Console.WriteLine("Z przeciwnika wyleciały przedmioty: " + enemy.ItemFromEnem().toString()); // to jest object
      }

      if (HealthEqualZero(hero)) hero.GameOver();
    }

    private bool HealthEqualZero(Object target) {
      if (target.Health == 0) return true;
      return false;
    }

    public void FightBeetween(EnemyUnit enemy, Hero hero) {
      double heroDemage = null;
      double enemyDemage = null;
      while (true) {
        heroDemage = SetAttack(hero);
        Console.WriteLine("Atakujesz za " + heroDemage);
        enemy.GetDemage(heroDemage);
        if(CheckIfDead(enemy)) break;
        enemyDemage = SetAttack(enemy);
        Console.WriteLine(enemy + " atakuje ciebie za " + enemyDemage); // do enemy dodać nazwę TODO
        hero.GetDemage(enemyDemage);
        if(CheckIfDead(hero)) break;
      }
    }
  }
}
