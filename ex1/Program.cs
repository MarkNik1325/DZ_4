int ReadInt (string argumentName)
{
Console.WriteLine($"Input {argumentName}");
  int number = 0;

 while (!int.TryParse (Console.ReadLine(), out number))
 {
    Console.WriteLine("Its not number");
 }
return number;
}

int Expo (int number1, int number2)
{
     int number = 1;
     int count = 1;
while (count <= number2)
{
    number = number*number1;
    count ++;  
}
return number;
}

bool PlusNumber (int number2)
{
if (number2<0)
{
    Console.WriteLine("Вы ввели ненатуральное число");
    return false;
}
return true;
}

void Task ()
{
int number1 = ReadInt ("Введите число");
int number2 = ReadInt ("Введите натуральное число для возведения в степень");
int exponenta = Expo (number1, number2);
if (PlusNumber(number2))
{
Console.WriteLine($"{number1} в степени {number2} = {exponenta}");
}
}

Task ();


