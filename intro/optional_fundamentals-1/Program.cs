//* Comment test

//* 1)
/*
for (int i = 1; i <= 255; i++) {
    Console.WriteLine($"{i}");
}
*/

//* 2 + 3)
/*
Random rand = new Random();
int sum = 0;

for (int i = 1; i <= 5; i++) {
    sum += rand.Next(10, 21);
}

Console.WriteLine($"sum of all numbers is {sum}");
*/

//* 4)

for (int i = 1; i <= 100; i++) {
    if (i % 3 == 0 && i % 5 != 0) {
        Console.WriteLine("Fizz");
    }
    else if (i % 3 != 0 && i % 5 == 0) {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine("FizzBuzz");
    }
}
