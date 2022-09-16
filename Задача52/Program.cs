// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void fillMatrixWithRandomPositiveIntegers(int[,] matrix)
{
    Random rnd = new Random();
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(0, 10);
        }
    }
}

double[] countColumnAverage(int[,] matrix)
{
    double[] count = new double[matrix.GetLength(1)];

    for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
    {
        int summ = 0;
        for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
        {
            summ += matrix[rowIndex, columnIndex];
        }
        count[columnIndex] = Convert.ToDouble(summ) / Convert.ToDouble(matrix.GetLength(0));
    }

    return count;
}
Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректные значения");
}
else
{
    int[,] matrix = new int[m, n];
    fillMatrixWithRandomPositiveIntegers(matrix);
    Console.WriteLine("Среднее арифметическое каждого столбца: " + String.Join("; ", countColumnAverage(matrix)));
}
