namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            string name;
            int age;
            double hourlyPay;
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? That's not old at all!");
            Console.WriteLine("How much do you make, " + name + "?");
            Double.TryParse(Console.ReadLine(), out hourlyPay);
            Console.WriteLine(hourlyPay.ToString("C") + "! I hope that's per hour and not per year!");
            Console.WriteLine();
            Console.WriteLine("Please enter the following information so I can commit identity fraud!!");
            Console.WriteLine();
            name


        }
    }
}
