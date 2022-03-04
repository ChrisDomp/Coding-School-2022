using Session_04;

//1. Reversing my name
var c1 = new Class1();
string name = "Christos Dompazis";
Console.WriteLine(c1.ReverseStringFor(name));


//2. Calculating Sum and Prod from 1 to n
var c2 = new Class2();
Console.WriteLine("Enter an integer :");
int n = Convert.ToInt32(Console.ReadLine());
c2.CalcSum(n);
Console.WriteLine($"Sum: {c2.CalcSum(n)},Prod:{c2.CalcProd(n)} ");


//3. Finding prime numbers from 1 to n 
var c3 = new Class3();
Console.WriteLine("Enter an integer :");
int k = Convert.ToInt32(Console.ReadLine());
c3.GetPrimeNums(k);
Console.WriteLine("");


//4. 
var c4 = new Class4();
int[] array1 = new int[] { 2, 4, 9, 12 };
int[] array2 = new int[] { 1, 3, 7, 10 };

int[] array3 = c4.MultiplyArrays(array1, array2);
Console.WriteLine("Array of multiplication between Array1 and Array2: ");
Console.WriteLine("["+String.Join(",", array3)+"]");

//5.
