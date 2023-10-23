Melee mercenary = new Melee("Mercenary");
Ranged archer = new Ranged("Archer");
Magic mage = new Magic("Mage");

mercenary.PerformAttack(archer, mercenary.kick);
mercenary.Rage(mage);
archer.PerformAttack(mercenary, archer.shootArrow);
archer.Dash();
archer.PerformAttack(mercenary, archer.shootArrow);
mage.PerformAttack(mercenary, mage.fireball);
mage.Heal(archer);
mage.Heal(mage);


