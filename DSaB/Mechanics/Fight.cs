using System;
using DSaB.Charakters;

namespace DSaB.Mechanics {
  class Fight {
    private readonly Random _rnd = new Random();
    private double Attack(int attackPower) {
      var value = _rnd.Next(0, 100);
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

    private string FightOptions(string playerChoose) { // zmienic z stringa na void, albo jednak int :thinking:
      int switchCase;
      try {
        switchCase = int.Parse(playerChoose);
      } catch {
        return "Dobra robota, właśnie straciłeś okazję na wykonanie poprawnego ruchu,\nrób tak dalej, a szybko trafisz do grobu...";
      }

      switch (switchCase) { // TODO wywoluje metody ktorych jeszcze nie ma
        case 1:
          return "Wykonujesz skok do przodu, po czym zadajesz szybkie cięcie, które zadaje obrażenia w wysokości: ";
        case 2:
          return "Potężny zamach jest wykonywany przez twoją osobę,\ngdy naglę widzisz jak końcówką swojej broni się gasz przeciwnika i zadajesz mu obrażenia w wysokości: ";
        case 3:
          return "Panikuj";
        case 4:
          return "Próbujesz zastosować postawę obronną, warto było oglądać te filmy z Jackie Chan'em.";
        case 5:
          return "Próbujesz uciec, masz na to bardzo nikłe szanse, bo przecierz twój przeciwnik nie jest zbyt inteligentny.";
        default:
          return "Zagapiłeś się, i przez przypadek uderzyłeś się w głowę.";
      }
    }

    private bool CheckIfDead(Hero target) {
      return target.Health <= 0;
    }

    private bool CheckIfDead(EnemyUnit target) {
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
        if (enemy.EnemyDropItem()) Console.WriteLine("Z przeciwnika wyleciały przedmioty: " + enemy.ItemFromEnemy().ItemName); // to jest object
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
        Console.WriteLine(enemy.Name + " atakuje ciebie za " + enemyDemage);
        hero.GetDemage(enemyDemage);
        if(CheckIfDead(hero)) break;
      }
      CheckWhoWin(enemy, hero);
    }
    // metoda TryEskape - ucieczka z walki mała szansa i jak sie nie uda to tracisz ruch
    // i teraz bomba - randomowe eventy z wyborami gg.
  }
}
