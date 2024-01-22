Console.WriteLine("Welcome to my room detail generator!");

//getting input from user
Console.WriteLine("Please enter width of the room:");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter length of the room:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter heigth of the room:");
double height = double.Parse(Console.ReadLine());

//room calculations
double area = (length * width);
double perimeter = ((length * 2) + (width * 2));
double volume = (length * width * height);
double surfaceArea = ((2 * length * width) + (2 * length * height) + (2 * width * height));
Console.WriteLine($"The area of your room is {area}");
Console.WriteLine($"The perimeter of your room is {perimeter}");
Console.WriteLine($"The volume of your room is {volume}");
Console.WriteLine($"The surface area of your room is {surfaceArea}");

//if logic for room designation based on area
if (area <= 250)
{
    Console.WriteLine("The room is small.");
}
else if (area >= 650)
{
    Console.WriteLine("The room is large.");
}
else
{
    Console.WriteLine("The room is medium");
}

//goodbye message
Console.WriteLine("Thank you for using my room detail generator. Goodbye!");