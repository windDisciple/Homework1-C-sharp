System.Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
    System.Console.WriteLine("max = " + num1);
} else {
    System.Console.WriteLine("max = " + num2);
}