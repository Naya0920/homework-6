// #1
/*
Console.Write("Enter numbers : ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Number of digits > 0: {count}");
*/
// #2
/*
Console.Write("Enter number x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double x = (-x2 + x1)/(-y1 + y2);
double y = y2 * x + x2;

Console.Write($"Two lines intersect at a point with coordinates X: {x}, Y: {y}");
*/