namespace LuciansLusciousLasagna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lasagna = new Lasagna();
            Console.WriteLine(lasagna.ExpectedMinutesInoven()); // 40
            Console.WriteLine(lasagna.RemainingMinutesInOven(30)); // 10
            Console.WriteLine(lasagna.PreparationTimeInMinutes(2)); // 4
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(2, 30)); // 34
        }
    }
}
