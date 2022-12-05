System.Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {
    System.Console.WriteLine("Max = " + a);
} else if (a > b && a < c) {
    System.Console.WriteLine("Max = " + c);
} else if (a < b && c < b) {
    System.Console.WriteLine("Max = " + b);
}