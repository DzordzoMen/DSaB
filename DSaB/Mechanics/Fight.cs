using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaB.Mechanics {
  class Fight {
    static double Attack(int attackPower) {
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
  }
}
