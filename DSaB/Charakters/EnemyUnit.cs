using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaB.Charakters {
  class EnemyUnit : Skeleton {
    public string Name { get; set; }
    public static List<Item> Drop { get; set; }

    public EnemyUnit(int health, int attack) : base(health, attack) {
    }

    public bool EnemyDropItem() { // TODO poprawic itemy z przeciwnikow
      if (Drop == null) return false;
      if (Drop.Count != 0) return true;
      return false;
    }

    public Item ItemFromEnemy() {
      return Drop[0]; // losowanie 0 dane do kompilacji
    }
  }

  class Item {
    public string ItemName { get; set; }
    public string Attribute { get; set; } = null;
    public int? Attack { get; set; }
    public int? Hp { get; set; }
  }
}
