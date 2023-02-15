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

int SumNumber (int number)
{
     int summa = 0;
while (number>0)
{
    summa = summa + number%10;
    number = number/10;  
}
return summa;
}

int number = ReadInt ("Введите число");
Console.WriteLine ($"Сумма цифр в числе равна {SumNumber (number)}");
