// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double getDoubleByDivision(int a, int b)
{
    if (b == 0)
    {
        b = 1;
    }
    return Convert.ToDouble(a) / Convert.ToDouble(b);
}

double getRandomDouble()
{
    Random rnd = new Random();
    return getDoubleByDivision(
        rnd.Next(-10, 11),
        rnd.Next(-10, 11)
    );
}

void fillMatrixWithRandomDoubles(double[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = getRandomDouble();
        }
    }
}

void printMatrixToConsole(double[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        Console.Write("\n");
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            Console.Write($" {String.Format("{0:F1}", matrix[rowIndex, columnIndex])}");
        }
    }
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
    double[,] matrix = new double[m, n];

    fillMatrixWithRandomDoubles(matrix);
    printMatrixToConsole(matrix);
}
