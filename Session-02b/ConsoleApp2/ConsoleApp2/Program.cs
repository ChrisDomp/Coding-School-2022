//1.
Console.WriteLine("Hello Chris");

//2.
int a = 2;
int b = 3;
int sum = a + b;
float div = (float)a / b;
Console.WriteLine("Sum = " + sum);
Console.WriteLine("Div = " + div);

//3.
Console.WriteLine(-1 + 5 * 6);
Console.WriteLine(38 + 5 % 7);
Console.WriteLine(14 + (-3 * 6) / 7.0);
Console.WriteLine(2 + 13 * 6 / 6.0 + Math.Sqrt(7));
Console.WriteLine((Math.Pow(6, 4) + Math.Pow(5, 7)) / ((float)9 % 4));

//4.
int age = 20;
string gender = "female";
Console.WriteLine("You are " + gender + " and look younger than " + age);

//5.
string val;
Console.WriteLine("Enter an integer");
val = Console.ReadLine();
int seconds = Convert.ToInt32(val);
Console.WriteLine("Seconds : " + seconds);
float minutes = (float)seconds / 60;
Console.WriteLine("Minutes : " + minutes);
float hours = (float)seconds / 3600;
Console.WriteLine("Hours : " + hours);
float days = (float)hours / 24;
Console.WriteLine("Days : " + days);
float years = (float)days / 365;
Console.WriteLine("Years : " + years);

//6.
string val2;
Console.WriteLine("Enter an integer");
val = Console.ReadLine();
int secs = Convert.ToInt32(val);
TimeSpan t = TimeSpan.FromSeconds(secs);
Console.WriteLine("Seconds : " + t.TotalSeconds);
Console.WriteLine("Minutes : " + t.TotalMinutes);
Console.WriteLine("Hours : " + t.TotalHours);
Console.WriteLine("Days : " + t.TotalDays);
Console.WriteLine("Years : " + t.TotalDays / 365.0);

//7.
Console.Write("Enter the amount of Celsius: ");
int celsius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kelvin = {0}", celsius + 273);
Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);