using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaB.Charakters {
  class EnemyUnit : Skeleton {

    public List<Items> drop { get; set; }

    public EnemyUnit(int health, int attack) : base(health, attack) {
    }

    public bool EnemyDropItem(EnemyUnit enemy) {
      if (enemy.drop.Count != 0) return true;
      return false;
    }

    public Items ItemFromEnem(EnemyUnit enemy) {
      return enemy.drop;
    } 

  }

  class Items {
    public string name { get; set; }
    public string attribute { get; set; } = null;
    public int attack { get; set; } = null;
    public int hp { get; set; } = null;
  }
}
