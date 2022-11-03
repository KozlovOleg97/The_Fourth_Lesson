
int length; //длинна матрицы или строка
int height; //высота матрицы или столбец
int sum = 0;  //сумма чисел, заполняющих матрицу
Console.Write("Введите длину матрицы              : ");
length = int.Parse(Console.ReadLine());
Console.Write("Введите высоту матрицы             : ");
height = int.Parse(Console.ReadLine());
Console.WriteLine("\nЗаполнение матрицы\n");
int[,] ara = new int[length, height];
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < height; j++)
    {
        Console.Write("Введите число                      : ");
        ara[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < height; j++)
    {
        Console.Write("{0} ", ara[i, j]);
        sum += ara[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("\nСумма матрицы = {0}", sum);
Console.ReadKey();
return 0;