using System;

namespace DSaB.Mechanics {
  // TODO propably change name
  class Moves {

    public void MoveOptions() { // change name
      Options();
      UserMove(Console.ReadLine());
    }

    private void Options() {
      Console.WriteLine();
      Console.WriteLine("Co chcesz zrobić?");
      Console.WriteLine("1. Iść dalej");
      Console.WriteLine("2. Poczekać na ratunek"); // to też dodać do innego pliku json
      Console.WriteLine("3. Poddać się i pić dalej imprezować");
      Console.WriteLine("4. Tu bedzie eq, cala logika w innych metodach");
      Console.WriteLine();
    }

    private void UserMove(string playerMove) {
      Console.WriteLine(Move(playerMove));
      CheckIfUserWantExit(playerMove);
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.WriteLine();
      if (playerMove != "1") {
        MoveOptions();
      }
    }

    private string Move(string playerChoose) {
      int switchCase;
      try {
        switchCase = int.Parse(playerChoose);
      } catch {
        return "Odpadł Ci palec, za oszukiwanie";
      }

      switch (switchCase) {
        case 1:
          return "Podoążasz dalej by poszukać skarbu.";
        case 2:
          return "Gdy czekasz przed tobą przechodzi czarny kot. -5 do szczęścia";
        case 3:
          return "Gdy wychodzisz z podziemi słyszysz śmiechy."; // moze tez do innego pliku json(tego samego)
        case 4:
          return "Not yet";
        default:
          return "Podczas zastanawiania się co masz zrobić dostajesz padaczki i umierasz.";
      }
    }

    private void CheckIfUserWantExit(string check) {
      if (check != "3") return;
      Console.ReadKey();
      System.Environment.Exit(0);
    }
  }
}
