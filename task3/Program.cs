/*Найдите максимальное значение в матрице по каждой строке, получите 
сумму этих максимумов. Затем найдите минимальное значение по каждой 
колонке,получите сумму этих минимумов. Затем из первой суммы 
(с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2*/
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[2, 3];
FillArray(matrix);
int max1 = matrix[0, 0];
int max2 = matrix[1, 0];

for (int j = 1; j < matrix.GetLength(1); j++)
{
    if (matrix[0, j] > max1)
    {
        max1 = matrix[0, j];
    }
}
for (int j = 1; j < matrix.GetLength(1); j++)
{
    if (matrix[1, j] > max2)
    {
        max2 = matrix[1, j];
    }
}

Console.WriteLine($"{max1}, {max2}");
int min1 = matrix[0, 0];
int min2 = matrix[0, 1];
int min3 = matrix[0, 2];
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (matrix[i, 0] < min1)
    {
        min1 = matrix[i, 0];
    }
}
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (matrix[i, 1] < min2)
    {
        min2 = matrix[i, 1];
    }
}
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (matrix[i, 2] < min3)
    {
        min3 = matrix[i, 2];
    }
}
Console.WriteLine($"{min1}, {min2}, {min3}");
int result1 = max1 + max2;
int result2 = min1 + min2 + min3; 
int result3 = result1 -result2;
System.Console.WriteLine($" {max1} + {max2} = {result1}");
System.Console.WriteLine($" {min1} + {min2} + {min3} = {result2}");
System.Console.WriteLine($" {result1} - {result2} = {result3}");