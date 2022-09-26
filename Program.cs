//Задача 3

Console.WriteLine("Введите число N:");
string n = Console.ReadLine();
int N = Convert.ToInt32(n);
string Elka = "*";
for (int i = 0; i < N; i++)
{
    Console.SetCursorPosition(Console.WindowWidth / 2 - i, Console.CursorTop);
    Console.WriteLine(Elka);
    Elka += "**";
}