
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число >");
int secondValue = Prompt("Введите второе число >");
int thirdValue = Prompt("Введите третье число >");

int result = firstValue;

if (secondValue > result)
{
    result = secondValue;
}
if (thirdValue > result)
{
    result = thirdValue;
}

System.Console.Write($" {result},");

 