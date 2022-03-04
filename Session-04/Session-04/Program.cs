using Session_04;

//1. Reversing my name
Console.WriteLine("Exersice 1.Reverse your name");
var c1 = new Class1();
string name = "Christos Dompazis";
Console.WriteLine($"Real name:{name}");
Console.WriteLine($"Reversed:{ c1.ReverseStringFor(name)}");
Console.WriteLine("");

//2. Calculating Sum and Prod from 1 to n
Console.WriteLine("Exersice 2.Calculate Sum and Prod from 1 to n");
var c2 = new Class2();
Console.WriteLine("Enter an integer :");
int n = Convert.ToInt32(Console.ReadLine());
c2.CalcSum(n);
Console.WriteLine($"Sum: {c2.CalcSum(n)},Prod:{c2.CalcProd(n)} ");
Console.WriteLine("");

//3. Finding prime numbers from 1 to n 
Console.WriteLine("Exersice 3.Find prime numbers from 1 to n");
var c3 = new Class3();
Console.WriteLine("Enter an integer :");
int k = Convert.ToInt32(Console.ReadLine());
c3.GetPrimeNums(k);
Console.WriteLine("");
Console.WriteLine("");

//4. Array Multiplication
Console.WriteLine("Exersice 4.Array Multiplication");
var c4 = new Class4();
int[] array1 = new int[] { 2, 4, 9, 12 };
int[] array2 = new int[] { 1, 3, 7, 10 };
int[] array3 = c4.MultiplyArrays(array1, array2);
Console.WriteLine("Array of multiplication between Array1 and Array2: ");
Console.WriteLine("[" + String.Join(",", array3) + "]");
Console.WriteLine("");

//5.Array sorting using the SortArray method
Console.WriteLine("Exersice 5.Sort an Array");
int[] array5 = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
Console.WriteLine("Array to be sorted :");
Console.WriteLine("[" + String.Join(",", array5) + "]");
var c5 = new Class5();
c5.SortArray(array5);
Console.WriteLine("Sorted Array:");
Console.WriteLine("[" + String.Join(",", array5) + "]");
Console.WriteLine("");
