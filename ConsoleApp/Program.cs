using ConsoleApp;

//SessionOne();

//DayThree.ProgramOne();
//DayThree.ProgramTwo();
//DayThree.ProgramThree();
//DayThree.ProgramFour();
//DayThree.ProgramFive();
//DayThree.ProgramSix();
DayThree.ProgramSeven();
static void SessionOne()
{
    Dayone obj1 = new Dayone();

    //Sum of two number
    /*Console.WriteLine("Enter two numbers to add:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    var result = obj1.Sum(firstNumber, secondNumber);
    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {result}");*/

    //convert minute to second
    /*Console.WriteLine("Enter minute to convert into second:");
    int minutes = Convert.ToInt32(Console.ReadLine());
    var seconds = obj1.MinutesToSeconds(minutes);
    Console.WriteLine($"{minutes}minutes is {seconds} seconds");*/

    //next number
    /*Console.WriteLine("Enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The next number is {obj1.NextNumber(number)}");*/

    //circuit power
    /*Console.WriteLine("Enter voltage:");
    int voltage = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter current:");
    int current = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The power is {obj1.CircuitPower(voltage, current)}");*/

    //age to days
    /*Console.WriteLine("Enter age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The converted days is {obj1.AgeToDays(age)}");*/

    //area of rectangle
    /*Console.WriteLine("Enter base of triangle:");
    int base1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter height of triangle:");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The area of traingle is {obj1.AreaOfTriangle(base1, height)}");*/

    //remainder
    /*Console.WriteLine("Enter dividend:");
    int dividend = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The remainder is {obj1.Remainder(dividend, divisor)}");*/

    //check if number is less than 0
    /*Console.WriteLine("Enter a number to check if it is less than 0:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(obj1.CheckNumber(number));*/

    //check if addition of two number is less than 100
    /*Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(obj1.LessThan100(firstNumber, secondNumber));*/

    //check if two  numbers are aqual
    /*Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(obj1.IsEqual(firstNumber, secondNumber));*/

    //flip bool
    /*Console.WriteLine("Enter a boolean value:(True/False)");
    bool value = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine($"The flipped value is {obj1.FlipBool(value)}");*/

    //return something
    /*Console.WriteLine("Enter a string:");
    string value = Console.ReadLine();
    Console.WriteLine(obj1.ReturnSomething(value));*/

    //perimeter of rectangle
    /*Console.WriteLine("Enter length:");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter breadth:");
    int breadth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The perimeter of rectangle is {obj1.PerimeterOfRectangle(length, breadth)}");*/

    //month converter
    /*Console.WriteLine("Enter a number between 1 and 12:");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(obj1.MonthConverter(value));*/

    //find largest and smallest
    /*Console.WriteLine("Enter the desired length of array:");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an array of number :");
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"The largest in the array is {obj1.FindLargest(arr)}");
    Console.WriteLine($"The smallest in the array is {obj1.FindSmallest(arr)}");*/

    //sum of absolute
    /*Console.WriteLine("Enter the desired length of array:");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an array of number :");
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"The sum of absolute value of all the elements in array is {obj1.SumOfAbsoluteValue(arr)}");*/

    //calculate power
    /*Console.WriteLine("Enter number and exponent:");
    double number = Convert.ToDouble(Console.ReadLine());
    double exponent = Convert.ToDouble(Console.ReadLine());
    double result = obj1.CalculatePower(number, exponent);
    Console.WriteLine($"{result}");*/

    //Multiply array elemenst by its length
    /*Console.WriteLine("Enter the desired length of array:");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an array of number :");
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("The given array is:");
    foreach (int i in arr)
    {
        Console.Write($"{i}"+" ");
    }
    int[] newarr = obj1.MultiplyByLength(arr);
    Console.WriteLine("\n The multiplied array is:");
    foreach (int i in newarr)
    {
        Console.Write($"{i}" + " ");
    }*/
}

static void SessionTwo()
{
    Daytwo obj2 = new Daytwo();
    obj2.NameShuffle("Hello this is reversed text");
    obj2.SmallerStringNumber("15", "100");
    obj2.CountPotatoes("potatoasdpotatosadpotato");
    obj2.FirstLast("This is a test setence");
    obj2.IsStringEmpty(" ");
    Console.WriteLine(obj2.Bomb("There is a bomb "));
    Console.WriteLine(obj2.HackersSpeak("HackerSpeak") + "\n");
    Console.WriteLine(obj2.ReverseCase("ReverseCase") + "\n");
    Console.WriteLine(obj2.CheckEquality(0, 0) + "\n");
    obj2.IndexOfCapitals("This is a Testing Sentence");
}


Console.ReadKey();