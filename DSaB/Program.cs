using DSaB.Charakters;
using DSaB.Mechanics;
using DSaB.Reader;

namespace DSaB {
  class Program {
    static void Main(string[] args) {
      Hero myCharacter = new Hero(100, 20);
      Moves move = new Moves();
      Text tour = new Text();
      ReadJson read = new ReadJson();

      int tourNumber = 0; // zwiekszac gdy bedzie 1 i zwracać, a moze dac to w moves
      // dodac uzywanie eq, [Hard]


      while(tourNumber != 9) {
        read.ReturnText(tourNumber, myCharacter);
        move.MoveOptions();
        tourNumber++;
      }



      /*
      while (playerMove != "1") { // przenies do moves
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Poczekać na ratunek");
        Console.WriteLine ("3. Poddać się i pić dalej imprezować");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }

      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Zobaczy czy ktoś Cię śledzi");
        Console.WriteLine ("3. Wrócić, przecież boisz się ciemności");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }



      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Przyczaić się, i poczekać na odpowiedni moment");
        Console.WriteLine ("3. Zawrócić, świerszczy zapewni Ci doznania lepsze niż chodzenie po piwnicy");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }



      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Zerknąć na pierwszą strone");
        Console.WriteLine ("3. Uciec, troche tu strasznie, a co jak trafisz na jakiegoś zboka?");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }




      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Poczytać jeszcze trochę tego ulicznego poety");
        Console.WriteLine ("3. Szybko pobiec do wyjścia i zarwać do tej dziewczyny która podoba Ci się od początków studiów");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }





      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Powąchać kanapkę, może jednak nie jest taka zła");
        Console.WriteLine ("3. Poddać się i pić dalej alkohol");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }


      playerMove = null;

      while (playerMove != "1") {
        ShouldExit (playerMove);

        Console.WriteLine ();
        Console.WriteLine ("Co chcesz zrobić?");
        Console.WriteLine ("1. Iść dalej");
        Console.WriteLine ("2. Poczekać chwilkę, chyba nadlatuje helikopter");
        Console.WriteLine ("3. Wrócić na góre i zobaczyć czy jeszcze impreza trwa");
        Console.WriteLine ();
        playerMove = Console.ReadLine ();
        Console.WriteLine (Move (playerMove));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine ();
      }





  */
    }
  }
}
