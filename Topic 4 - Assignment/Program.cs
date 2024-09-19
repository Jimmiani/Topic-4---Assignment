namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            string name, lastName, login, item1, item2;
            int age, grade, studentId;
            double hourlyPay, averageGrade, num1, num2, num3, price1, price2, tax, discount, total, subtotal, totalOwed;
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? That's not old at all!");
            Console.WriteLine("How much do you make, " + name + "?");
            Double.TryParse(Console.ReadLine(), out hourlyPay);
            Console.WriteLine(hourlyPay.ToString("C") + "! I hope that's per hour and not per year!");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the following information so I can commit identity fraud!!");
            Console.WriteLine();
            Console.Write("First name: ");
            name = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Int32.TryParse (Console.ReadLine(), out grade);
            Console.Write("Student ID: ");
            Int32.TryParse (Console.ReadLine (), out studentId);
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            Double.TryParse (Console.ReadLine(), out averageGrade);
            Console.WriteLine("Your information:");
            Console.WriteLine();
            Console.WriteLine("\tLogin:\t\t" + login);
            Console.WriteLine("\tID:\t\t" + studentId);
            Console.WriteLine("\tName:\t\t" + lastName + ", " + name);
            Console.WriteLine("\tAverage:\t" + averageGrade + "%");
            Console.WriteLine("\tGrade:\t\t" + grade);
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know that in five years you will be " + (age + 5) + "? And five years ago you were " + (age - 5) + "! That's crazy!");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Hello! I'm a calculator! Enter in three numbers, and I'll add 'em all up and divide the answer by two!");
            Console.WriteLine();
            Console.Write("Enter number 1: ");
            Double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter number 2: ");
            Double.TryParse(Console.ReadLine(), out num2);
            Console.Write("Enter the final number: ");
            Double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("Thank you! Processing your calculation...");
            Thread.Sleep(4000);
            Console.WriteLine("All done! Press enter to view the answer!");
            Console.ReadLine();
            Console.WriteLine((num1 + num2 + num3) / 2);
            Console.WriteLine();
            Console.WriteLine("Hello sir! What two items are you buying today?");
            Console.WriteLine();
            Console.Write("Item 1: ");
            item1 = Console.ReadLine();
            Console.Write("Item 2: ");
            item2 = Console.ReadLine();
            Console.WriteLine("Oh I love " + item1 + ", and " + item2 + "! They're my favourite foods! Remind me, how much are they again?");
            Console.WriteLine();
            Console.Write("Price of " + item1 + ": ");
            Double.TryParse(Console.ReadLine(), out price1);
            Console.Write("Price of " + item2 + ": ");
            Double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine();
            total = price1 + price2;
            discount = total * 0.2;
            subtotal = total - discount;
            tax = subtotal * 0.13;
            totalOwed = subtotal + tax;
            Console.WriteLine("Thank your sir! That will be " + total.ToString("C") + " Before tax.");
            Console.WriteLine("However, luckily for you, we have a special promotion going on right now!");
            Console.WriteLine(item1 + " and " + item2 + "s are actually on sale right now!");
            Console.WriteLine("20% discount off the total price! That means your final price will only be " + totalOwed.ToString("C") + "!");
            Console.WriteLine("I'll get that receipt printed out for you right away.");
            Console.WriteLine();
            Console.WriteLine("\tSales Receipt");
            Console.WriteLine();
            Console.WriteLine("\tItem 1:\t " + item1);
            Console.WriteLine("\tPrice:\t " + price1.ToString("C"));
            Console.WriteLine("\tItem 2:\t " + item2);
            Console.WriteLine("\tPrice:\t " + price2.ToString("C"));
            Console.WriteLine("\t==================");
            Console.WriteLine("\tTotal:\t " + total.ToString("C"));
            Console.WriteLine("\tDiscount (20%):\t " + discount.ToString("C"));

        }
    }
}
