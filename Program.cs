

using System;
using The_Fourth_Lesson;




int length; 
int height; 
int sum = 0;  
Console.Write("Enter the length of the matrix: ");
length = int.Parse(Console.ReadLine());

Console.Write("Enter the height of the matrix: ");
height = int.Parse(Console.ReadLine());

Console.WriteLine("\nFillin in the matrix\n");
int[,] ara = new int[length, height];
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < height; j++)
    {
        Console.Write("Enter a number: ");
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
Console.WriteLine("\nSum of the matrix = {0}", sum);
Console.ReadKey();


MathOperations mathOp = new MathOperations();

Console.WriteLine("Choose the action.");
Console.WriteLine("'p' - amount of positive and negative numbers");
Console.WriteLine("'s' - array sorting");
Console.WriteLine("'i' - array inversion");
char act = Convert.ToChar(Console.ReadLine());

switch (act)
{
    case 'p':
        mathOp.AmountOfPosAndNegNumbers(ara, length, height);
        break;
    case 's':
        mathOp.ArrSort(ara, length, height);
        break;
    case 'i':
        mathOp.Invers(ara, length, height);
        break;
}