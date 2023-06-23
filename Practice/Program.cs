using Practice;

MathMethods mathMethods = new MathMethods();

Console.WriteLine("What is your age?");
var age = Console.ReadLine();

Console.WriteLine($"Your age is {age}");
Console.WriteLine("I will now do mathmatical calculations that add and subtract with numbers that you give me! \n" +
  "I will also use that number to only print out odds for the added number and evens for the subtracted number, up to 1000!");

Console.WriteLine("Please enter 2 numbers!");
var num1=int.Parse(Console.ReadLine());
Console.WriteLine();
var num2=int.Parse(Console.ReadLine());

var added = mathMethods.Add(num1, num2);
var subtracted = mathMethods.Subtract(num1, num2);

Console.WriteLine($"Your numbers added are: {added}");
Console.WriteLine($"Your numbers subtracted are: {subtracted}");
Console.WriteLine();
Console.WriteLine($"From {added} to 1000 using only odds is:");
Console.WriteLine("==========================================");

for (int i = added; i <= 1000; i++)
{
  if(i % 2 != 0)
  {
    
    Console.WriteLine(i);
  }
}
Console.WriteLine();
Console.WriteLine($"From {subtracted} to 1000 using only evens is: ");
Console.WriteLine("================================================");
for (int i = subtracted; i <= 1000; i++)
{
  if(i % 2 == 0)
  {
    Console.WriteLine(i);
  }
  
}


Console.WriteLine();
Console.WriteLine("Thanks for Playing!");
