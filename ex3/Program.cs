
int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;
}

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

void PrintArray (int [] array)
{
    for (int counter = 0; counter < array.Length; counter++)
{
Console.Write ($"{array[counter]} ");
}
Console.WriteLine();
Console.Write ("[");
for (int count = 0; count < array.Length; count++)
{
Console.Write ($" {array[count]} ");
}
Console.Write ("]");
}


int length = ReadInt ("Введите длину массива");
int min = ReadInt ("Введите минимальное значение массива");
int max = ReadInt ("Введите максимальное значение массива");
int[] array = GetRandomArray(length, min, max);
PrintArray (array);