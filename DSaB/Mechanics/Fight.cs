using System;
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

    private bool CheckIfDead(Hero target) {
      return target.Health <= 0;
    }

    private bool CheckIfDead(EnemyUnit target) { // bylo tak, ze sprawdzal czy jest 0 i dawal true, a jak nie to false
      return target.Health <= 0;
    } 

    private double SetAttack(Hero target) {
      return Attack(target.AttackPower);
    }

    private double SetAttack(EnemyUnit target) {
      return Attack(target.AttackPower);
    }

    private void CheckWhoWin(EnemyUnit enemy, Hero hero) { // potem? TODO
      if (HealthEqualZero(enemy)) {
        Console.WriteLine("Brawo wygrałeś");
        if (enemy.EnemyDropItem()) Console.WriteLine("Z przeciwnika wyleciały przedmioty: " + enemy.ItemFromEnemy().Name); // to jest object
      }

      if (HealthEqualZero(hero)) hero.GameOver();
    }

    private bool HealthEqualZero(Hero target) {
      return target.Health <= 0;
    }

    private bool HealthEqualZero(EnemyUnit target) {
      return target.Health <= 0;
    }

    public void FightBeetween(EnemyUnit enemy, Hero hero)
    {
      while (true) {
        double heroDemage = SetAttack(hero);
        Console.WriteLine("Atakujesz za " + heroDemage);
        enemy.GetDemage(heroDemage);
        if(CheckIfDead(enemy)) break;
        double enemyDemage = SetAttack(enemy);
        Console.WriteLine(enemy.Name + " atakuje ciebie za " + enemyDemage); // do enemy dodać nazwę TODO
        hero.GetDemage(enemyDemage);
        if(CheckIfDead(hero)) break;
      }
      CheckWhoWin(enemy, hero);
    }
    // metoda TryEskape - ucieczka z walki mała szansa i jak sie nie uda to tracisz ruch
    // i teraz bomba - randomowe eventy z wyborami gg.
  }
}
