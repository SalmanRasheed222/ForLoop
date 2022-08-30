



int value, start, end;

Console.WriteLine("Enter Value:");
value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Starting Point:");
start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Ending Value:");
end = Convert.ToInt32(Console.ReadLine());

for (; start <= end;)
{
	Console.WriteLine(value + "x" + start + "=" + (value * start));
	start++;
}



///////////////////////////////////////////////////////////////////////////////////////


//string name;
//int start, end;
//Console.Write("Enter Yor Name: ");
//name = Console.ReadLine();


//Console.WriteLine("Enter Starting Point:");
//start = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Ending Value:");
//end = Convert.ToInt32(Console.ReadLine());


//for (; start <= end;)
//{
//	Console.WriteLine("");
//	Console.WriteLine(name + (start));
//	start++;
//}


//for (int i = 1; i <= 10; i++)
//{
//	Console.WriteLine(name + (i));
//}