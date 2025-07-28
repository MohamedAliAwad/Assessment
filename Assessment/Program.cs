

#region Q01
//Console.WriteLine("Please enter a number");
//int num;
//int.TryParse(Console.ReadLine(), out num);
//if (num % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}
#endregion

#region Q02

//Console.WriteLine("Please enter a Char");
//char Char;
//char.TryParse(Console.ReadLine(), out Char);
//if(char.IsLetter(Char))
//{
//    switch(Char){
//        case 'a':
//        case 'A':
//        case 'e':
//        case 'E':
//        case 'i':
//        case 'I':
//        case 'o':
//        case 'O':
//        case 'U':
//        case 'u':
//            Console.WriteLine("Vowal");
//            break;
//            default:
//            Console.WriteLine("Constant");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Not valid char");
//}

#endregion


#region Q03

//Console.WriteLine("Please enter a month number");
//int num;
//int.TryParse(Console.ReadLine(), out num);
//if(num > 0)
//{
//    switch(num)
//    {
//        case 1:
//        case 3:
//        case 5:
//        case 7:
//        case 8:
//        case 10:
//        case 12:
//            Console.WriteLine("31 Days");
//            break;
//            case 2:
//            Console.WriteLine("28 Days");
//            break;
//        case 4:
//        case 6:
//        case 9:
//        case 11:
//            Console.WriteLine("30 Days");
//            break;
//            default:
//            Console.WriteLine("Not valid month");
//            break;
//    }
//}


#endregion


#region Q04
//Console.WriteLine("Please enter a month number");
//int num;
//int.TryParse(Console.ReadLine(), out num);
//for (int i = 0; i < num; i++)
//{
//    Console.Write($"{i} ,");
//}
//Console.WriteLine();
//for(int i = num; i >= 0; i--)
//{
//    Console.Write($"{i} ,");
//}
#endregion


#region Q05
//Console.WriteLine("Please enter a number");
//int num;
//int.TryParse(Console.ReadLine(), out num);
//int pow;
//Console.WriteLine("Please enter the power");
//int.TryParse(Console.ReadLine(), out pow);
//decimal result = 1;

//for(int i = 0; i < pow; i++)
//{
//    result *= num;
//}
//Console.WriteLine(result);

#endregion

#region Q06
//Console.WriteLine("Please enter a string");
//string str = Console.ReadLine();
//if (str != null)
//{
//    for (int i = str.Length -1; i >=0; i--)
//    {
//        Console.Write(str[i]);
//    }
//}
#endregion

#region Q07



#endregion


#region Q08
//Console.WriteLine("Please enter the size");
//int size;
//int.TryParse(Console.ReadLine(), out size);
//int[] arr = new int[size];
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Enter Value {i+1}");
//  arr[i] = int.Parse(Console.ReadLine());
//}
//int min = int.MaxValue;
//int max = int.MinValue;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//        min = arr[i];
//    if (arr[i] > max)
//        max = arr[i];
//}
//Console.WriteLine($"Min = {min}, and Max = {max}");

#endregion

#region Q09
//Console.WriteLine("Please enter the size");
//int size;
//int.TryParse(Console.ReadLine(), out size);
//int[] arr = new int[size];
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Enter Value {i + 1}");
//    arr[i] = int.Parse(Console.ReadLine());
//}
//int dist = 0;

//for(int i = arr.Length-1;i >= 0;i--)
//{
//    for(int j = 0; j <= arr.Length-1; j++)
//    {

//    }
//}
//Console.WriteLine(dist);

#endregion

#region Q10



#endregion

#region Q11
//enum color : byte
//{
//    Red, Green, Blue
//}


using Assessment;

Console.WriteLine("Please enter the color");
Colors color;
Enum.Parse(color.GetType(), Console.ReadLine());
if(color == Colors.Red || color == Colors.Green || color == Colors.Blue)
{
    Console.WriteLine("Primary");
}
else
{
    Console.WriteLine("Not");
}

#endregion

#region Q12
//Console.WriteLine("Please Enter number of persons");
//int size;
//int.TryParse(Console.ReadLine(), out size);
//Person[] people = new Person[size];

//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Please enter p {i + 1}");
//    people[i].Name = Console.ReadLine(); 
//    people[i].Age = int.Parse(Console.ReadLine());
//}

//for (int i = 0;i < people.Length; i++)
//{
//    Console.WriteLine(people[i].ToString());
//}




#endregion