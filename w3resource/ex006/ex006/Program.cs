// Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36

Console.Write("Input the first number to multiply: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Input the second number to multiply: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.Write("Input the third number to multiply: ");
int numberThree = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberOne} x {numberTwo} x {numberThree} = {numberOne * numberTwo * numberThree}");
