/* Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел 
больше 0 ввел пользователью*/
Console.Write($"Введите число М (сколько чисел вы будите вводить):");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];
void InputNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i+1} число > ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CheckNumPositive(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if(massiveNumbers[i] > 0 )
        count += 1;
    }
    return count;
}
InputNumbers(M);
int result = CheckNumPositive(massiveNumbers);
Console.WriteLine($"Введено чисел больше 0> {result}");
