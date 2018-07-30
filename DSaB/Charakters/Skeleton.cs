using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaB.Charakters {
  class Skeleton {
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Skeleton(int health, int attackPower) {
      this.Health = health;
      this.AttackPower = attackPower;
    }

    public void GetDemage(int demage) {
      Health -= demage;
    }
  }
}
