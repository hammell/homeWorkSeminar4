string MassNumber(int a, int b, int c, int d, int e, int f, int g, int h)
{
    int[] newArray = new int[8] { a, b, c, d, e, f, g, h };
    string result = "";
    for (int i = 0; i < 8; i++)
    {
        if (i == 7) result = result + newArray[i];
        else result = result + newArray[i] + ",";
    }

    return result;
}
try
{
    Console.Write("Введите число 1: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Введите число 3: ");
    int c = int.Parse(Console.ReadLine());
    Console.Write("Введите число 4: ");
    int d = int.Parse(Console.ReadLine());
    Console.Write("Введите число 5: ");
    int e = int.Parse(Console.ReadLine());
    Console.Write("Введите число 6: ");
    int f = int.Parse(Console.ReadLine());
    Console.Write("Введите число 7: ");
    int g = int.Parse(Console.ReadLine());
    Console.Write("Введите число 8: ");
    int h = int.Parse(Console.ReadLine());

    string result = MassNumber(a, b, c, d, e, f, g, h);
    Console.WriteLine($"Массив из введенных элементов = [{result}]");
}
catch (Exception ex)
{
    Console.WriteLine($"Введеное значение имеет неверный формат. Ошибка: {ex.Message}");
}