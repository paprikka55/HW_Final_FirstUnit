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
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
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

int GetLengthShortArray(string[] array)
{
  int arrayLength = 0;
  foreach (var item in array)
  {
    if (item.Length <= 3)
    { arrayLength++; }
  }
  return arrayLength;
}

string[] GetShortStrings(string[] array)
{
  int index = 0;
  string[] shortArray = new string[GetLengthShortArray(array)];
  foreach (var item in array)
  {
    if (item.Length <= 3)
    {
      shortArray[index] = item;
      index++;
    }
  }
  return shortArray;
}


System.Console.WriteLine(@"Выберите способ создания массива:
1. Массив заполненный случайными символами
2. Заполнить массив вручную
Для выхода нажмите Q");
char inputChar = Console.ReadKey().KeyChar;
if (inputChar == '1')
{
  System.Console.WriteLine();
  string[] array = CreateRandomArray();
  System.Console.WriteLine("Созданный массив: ");
  PrintArray(array);
  System.Console.WriteLine("Массив со строками меньше ии равно 3 символам: ");
  string[] shortArray = GetShortStrings(array);
  PrintArray(shortArray);
}
else if(inputChar == '2')
{
  System.Console.WriteLine("Вручную");  
}
else if(inputChar == 'q' || inputChar == 'Q')
{
  System.Environment.Exit(0);
}

