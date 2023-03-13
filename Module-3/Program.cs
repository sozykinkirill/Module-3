namespace Module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            Console.Write("Enter yout age:");
            var age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("Enter your birthsdate:");
            var data = Console.ReadLine();
            Console.WriteLine("Your birthsday is {0}", data);
            Console.Write("What is your favorite day of week:");
            var day = (GoodDay)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.ReadKey();
        }
        enum GoodDay: byte
        {
            Monday = 1, 
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}