﻿DateTime EndDate = new DateTime(2023, 11, 24, 7, 30, 0);
DateTime CurrentDate = DateTime.Now;
TimeSpan TimeDiff = EndDate.Subtract(CurrentDate);
Console.WriteLine("{0}", CurrentDate);
Console.WriteLine("{0}", EndDate);
Console.WriteLine("{0}", TimeDiff.Days);
Console.WriteLine("{0}", TimeDiff.Hours);
Console.WriteLine("{0}", TimeDiff.Minutes);
// Console.WriteLine(TimeDiff);
// Console.WriteLine("{0:dd} {0:y}", TimeDiff);