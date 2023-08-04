// Метод печати массива.
void Print1DArr(string[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

string[] array = { "Hello", "2", "world", ":-)", "1234", "- 2", "computer science", "Denmark", "Kazan" };
string[] newArr = new string[0];
int indexNewArr = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3)
  {
    Array.Resize(ref newArr, newArr.Length + 1);
    newArr[indexNewArr] = array[i];
    indexNewArr++;
  }
}

Print1DArr(array);
Print1DArr(newArr);

