using ConsoleApp8;

//Rectangle[] rectangles = new Rectangle[]
//{
//    new Rectangle(2, 5),
//    new Rectangle(10, 8),
//    new Rectangle(3, 9),
//    new Rectangle(2, 2),
//    new Rectangle(3, 1),
//    new Rectangle(4, 10),
//    new Rectangle(2, 9),
//};

//foreach (Rectangle rect in rectangles)
//{
//    Console.WriteLine($"{rect.Width} {rect.Height}");
//}

Worker[] workers = new Worker[]
{
    new Worker("Mihalich", "Valera", 50, 200, false),
    new Worker("Petrov", "Ararat", 62, 150, false),
    new Worker("Sifsifilich", "Dimon", 63, 250, true),
    new Worker("Karkarich", "Valera", 16, 150, false),
    new Worker("Gustavo", "Gus", 45, 500, true),
};
//1
foreach (Worker work in workers)
{
    Console.WriteLine(work.ToString());
}
//2
Console.WriteLine();
foreach (Worker work in workers)
{
    if(work.Age >= 18)
    {
        Console.WriteLine(work.ToString());
    }
    
}
//3
Console.WriteLine();
foreach (Worker work in workers)
{
    if (work.Surname == "Petrov")
    {
        Console.WriteLine(work.ToString());
    }

}
//4
Console.WriteLine();
double result = 0;
foreach (Worker work in workers)
{
    if (work.IsPension)
    {
        result += work.SalaryPerMonth;
    }

}
Console.WriteLine(result);
