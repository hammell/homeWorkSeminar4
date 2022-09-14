double naturalDegree(int A, int B)              //можно удалить
{                                               //можно удалить
    return Math.Pow(A, B);                      //можно удалить
}                                               //можно удалить
try
{
    Console.Write("Введите число A: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите степень числа А: ");
    int b = int.Parse(Console.ReadLine());
    double result = Math.Pow(a, b);
    Console.WriteLine($"число {a} в натуральной степени {b} = {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Введеное значение имеет неверный формат. Ошибка: {ex.Message}");
}