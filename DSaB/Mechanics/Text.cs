using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaB.Mechanics {
  class Text {
    // znajdz cos zeby tekst bral pod uwage szerokosc okna
    public void Start() {

    }

    /*
    public void TourNine() { // walka 1
      Console.WriteLine("Gdy zbliżasz się do żródła światła zauważąsz, że to lodówka, pewnie w środku niej będzie to ");
      Console.WriteLine("po co Cię tu wysłali. Podchodzisz i widzisz, że coś jej pilnuje, chyba to cerber, ale cel ");
      Console.WriteLine("uświęca środki, może go czymś przekupie, albo po prostu pokonam, “Pałka penetracji” ");
      Console.WriteLine("dawno nie była używana, ale mam tę kanapke którą zdobyłem z tamtego orka.");

      monserHealth = 120;
      monsterAttack = 17;
      tour = 1;

      Console.WriteLine();
      Console.WriteLine("Co chcesz zrobić?");
      Console.WriteLine("1. Zjedz kanapkę i zaatakuj potwora");
      Console.WriteLine("2. Rzuć kanapkę cerberowi może się skusi");
      Console.WriteLine("3. Powoli się wycofaj może znajdziesz inną drogę, do tej lodówki");
      Console.WriteLine();

      if (playerMove == "1") {
        healthPoints = 100; // monster
      }
    }

    public void TourTen() {
      Console.WriteLine();
      Console.WriteLine("Udało się zdobyłem dostęp do lodówki, teraz wystarczy ją otworzyć i zobaczyć czy w środku ");
      Console.WriteLine("jest to czego szukam. Otwierasz lodówke i widzisz ją wodę ognistą, trunek obiecany, święty ");
      Console.WriteLine("gral wśród studentów, wyjmujesz ją z lodówki, zimna tak jak powinno być, jak to mawiają, ");
      Console.WriteLine("“student też człowiek wody potzebuje”. ");

      Console.ReadKey();
    }

    public void FightOne() {
      //fight
      double monserHealth = 100;
      int monsterAttack = 10;
      int tour = 1;
      while (true) { // przenies do fight

        if (healthPoints <= 0) {
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Następnym razem będzie lepiej");
          Console.ForegroundColor = ConsoleColor.Gray;
          ShouldExit("3");
        }

        double demage = 0;
        Console.WriteLine();
        Console.WriteLine("Co chcesz zrobić?");
        Console.WriteLine("1. Atakuj");
        Console.WriteLine("2. Uciekaj, przecież nie godziłeś się na walke");
        Console.WriteLine();
        playerMove = Console.ReadLine();
        if (playerMove == "1") {
          demage = Attack(attackPoints);
          monserHealth = monserHealth - demage;
          if (demage > 0) {
            Console.ForegroundColor = ConsoleColor.Red;
          }
          Console.WriteLine("Zadajesz obrażenia równe: " + demage);
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine("Zdrowie potwora: " + monserHealth);
        } else if (playerMove == "2") {
          Console.WriteLine("Podczas uciekania potykasz się o własne nogi i tracisz przytomność");
          ShouldExit("3");
        } else {
          Console.WriteLine("Co ja zrobiłem straciłem ture na sprawdzanie innych rzeczy");
        }

        if (monserHealth <= 0) {
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Obrzydliwy ork upada na ziemie, a Ty wychodzisz z tarczą w ręku.");
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine();
          break;
        }

        tour++;

        if (tour % 2 == 0) {
          demage = Attack(monsterAttack);
          healthPoints = healthPoints - demage;
          if (demage > 0) {
            Console.ForegroundColor = ConsoleColor.Red;
          }
          Console.WriteLine();
          Console.WriteLine("Ork zadaje Ci obrażenia równe: " + demage);
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine("Twoje zdrowie: " + healthPoints);
          tour++;
        }

      }
    }

    public void FightTwo() {
      while (true) {
        double demage = 0;

        if (playerMove == "1") {
          demage = Attack(attackPoints);
          monserHealth = monserHealth - demage;
          if (demage > 0) {
            Console.ForegroundColor = ConsoleColor.Red;
          }
          Console.WriteLine("Zadajesz obrażenia równe: " + demage);
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine("Zdrowie potwora: " + monserHealth);
        } else if (playerMove == "3") {
          Console.WriteLine("Gdy próbujesz się wycofać, potykasz się o kawałek kości i tracisz przytomność. A byłeś już tak blisko...");
          ShouldExit("3");
        } else if (playerMove == "2") {

          Console.WriteLine("Udało się, cerber połknął haczyk i dzięki temu zdobyłem dostęp do lodówki, teraz wystarczy ");
          Console.WriteLine("ją otworzyć i zobaczyć czy w środku jest to czego szukam. Otwierasz lodówke i widzisz ją ");
          Console.WriteLine("wodę ognistą, trunek obiecany, święty gral wśród studentów, wyjmujesz ją z lodówki, zimna ");
          Console.WriteLine("tak jak powinno być, jak to mawiają, “student też człowiek wody potzebuje”. ");

          ShouldExit("3");
        } else {
          Console.WriteLine("Co ja zrobiłem straciłem ture na sprawdzanie innych rzeczy");
        }

        if (monserHealth <= 0) {
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Cerber upada na ziemie, zauważasz, żę to zwykły pies, co Ci podali na tej imprezie?");
          Console.ForegroundColor = ConsoleColor.Gray;
          break;
        }

        tour++;

        if (tour % 2 == 0) {
          demage = Attack(monsterAttack);
          healthPoints = healthPoints - demage;
          if (demage > 0) {
            Console.ForegroundColor = ConsoleColor.Red;
          }
          Console.WriteLine();
          Console.WriteLine("Cerber atakuje i zadaje Ci obrażenia równe: " + demage);
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine("Twoje zdrowie: " + healthPoints);
          tour++;
        }

        if (healthPoints <= 0) {
          Console.WriteLine();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Następnym razem będzie lepiej");
          Console.ForegroundColor = ConsoleColor.Gray;
          ShouldExit("3");
        }

        Console.WriteLine();
        Console.WriteLine("Co chcesz zrobić?");
        Console.WriteLine("1. Atakuj");
        Console.WriteLine("2. Powoli się wycofaj może znajdziesz inną drogę, do tej lodówki");
        Console.WriteLine();
        playerMove = Console.ReadLine();

        if (playerMove == "2") {
          playerMove = "3";
        }
      }
    }
    */
  }
}
