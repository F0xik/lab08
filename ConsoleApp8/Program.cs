using System.Reflection.PortableExecutable;
Console.WriteLine("Выберите (1 или 2) 1 - на 3 | 2 - на 4");
int vibor;
vibor = Convert.ToInt32(Console.ReadLine());
if (vibor == 1)
{
    Console.WriteLine("На 3");
    Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] mass = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введи элемент в массиве");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    int umno = mass[0];
    for (int i = 1; i < n; i++)
    {
        umno *= mass[i];
    }
    Console.WriteLine($"Максимальное число: {mass.Max()} \nМинимальное число:{mass.Min()} \nСреднее число: {mass.Average()} \nСумма: {mass.Sum()} \nПроизведвение: {umno}");
}
if (vibor == 2)
{
    Console.WriteLine("На 4");
    var random = new Random();
    var randnum1 = new byte[1];
    random.NextBytes(randnum1);
    int element = randnum1[0];
    var randoms = new Random();
    var randomchars = new byte[element];
    randoms.NextBytes(randomchars);
    foreach (byte value in randomchars)
        Console.Write($"{value}");
}