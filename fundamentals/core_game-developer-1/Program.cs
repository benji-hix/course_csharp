Enemy zigzagoon = new Enemy("Zigzagoon");

Attack tailWhip = new Attack("Tail Whip", 0);
Attack tackle = new Attack("Tackle", 40);
Attack doubleEdge = new Attack("Double-edge", 120);

zigzagoon.addAttack(doubleEdge);
zigzagoon.addAttack(tackle);
zigzagoon.addAttack(tailWhip);

zigzagoon.RandomAttack();