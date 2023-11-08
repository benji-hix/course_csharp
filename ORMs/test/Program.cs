DateTime now = DateTime.Now;
DateTime birthday = new DateTime(1997, 06, 23, 0, 0, 0);
TimeSpan TimeDiff = now.Subtract(birthday);
// string ageString = TimeDiff.TotalDays.ToString();
int age = (int)float.Parse(TimeDiff.TotalDays.ToString());
Console.WriteLine($"{age}");