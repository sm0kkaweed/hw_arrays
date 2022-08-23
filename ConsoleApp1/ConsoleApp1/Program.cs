
using System.ComponentModel;
Console.WriteLine("Choose how to sort : 1) Descending, 2) Ascending");
int min = -20;
int max = 20;
int[] newArray = new int[7];
Random randnumb = new Random();
Console.WriteLine("Before:");
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = randnumb.Next(min,max);
    Console.WriteLine(newArray[i]);
}

string select = Console.ReadLine();
switch (select)
{
    case "1":
        newArray = newArray.OrderByDescending(x => x).ToArray();
        Console.WriteLine("After:");
      for(int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
        break;
        case "2":
        newArray = newArray.OrderBy(x => x).ToArray();
        Console.WriteLine("After:");
        for(int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
        break;
}
