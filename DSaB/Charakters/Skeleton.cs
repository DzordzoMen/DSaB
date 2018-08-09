using System;

namespace DSaB.Charakters {
  class Skeleton {
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Skeleton(int health, int attackPower) {
      Health = health;
      AttackPower = attackPower;
    }

    public void GetDemage(double demage) {
      Health -= Convert.ToInt32(demage);
    }
  }
}
