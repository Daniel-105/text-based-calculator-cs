





Console.Write("Insert the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Insert the operation (plus, minus, multiply and divide) ");
var operation = Console.ReadLine();

Console.Write("Insert the second number: ");
int secondNum = int.Parse(Console.ReadLine());

 if (operation == "plus")
    {
        Console.WriteLine(firstNum + secondNum);
    }
    else if (operation == "minus")
    {
        Console.WriteLine(firstNum - secondNum);
    }
      else if (operation == "multiply")
    {
        Console.WriteLine(firstNum * secondNum);
    }
      else if (operation == "divide")
    {
        Console.WriteLine(firstNum / secondNum);
    }

