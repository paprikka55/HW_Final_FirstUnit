void FillRandomArray (string[] array)
{
Random rnd = new Random();
int elementLength;
char simbol;
string tempString;

for (int i = 0; i < array.Length; i++)
{
  elementLength = rnd.Next(1, 10);
  tempString = "";
  for (int j = 0; j < elementLength; j++)
  {
    simbol = Convert.ToChar(rnd.Next(33, 127));
    tempString += simbol;
  }
  array[i] = tempString;
}
}

void PrintArray(string[] array)
{
  foreach (var item in array)
  {
    System.Console.Write($"{item} ");
  }
}

string[] CreateRandomArray()
{
  int length = new int();
  while (true)
  {
    System.Console.Write("Для создания рандомного массива введите количество элементов: ");
    bool success = int.TryParse(Console.ReadLine(), out length);
    if (success == true)
    {
      break;
    }
    else
    {
      System.Console.WriteLine("Ошибка данных. Нужно ввести целочисленное значение!");
    }
  }
  string[] array = new string[length];
  FillRandomArray(array);
  return array;
}

while (Console.ReadKey(true).Key != ConsoleKey.Q)
{
  System.Console.WriteLine(@"Выберите способ создания массива:
  1. Массив заполненный случайными символами
  2. Заполнить массив вручную
  Для выхода нажмите q");
  if (Console.ReadKey().KeyChar == 1)
  {

  }
  else if(Console.ReadKey().KeyChar == 2)
  {
    string[] array = CreateRandomArray();
    PrintArray(array);
  }
}

// PrintArray(array);