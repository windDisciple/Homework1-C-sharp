System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int rang = 1;

while (rang < num) {
    rang++;
        if (rang % 2 == 0) {
            System.Console.WriteLine(rang);
        }
}