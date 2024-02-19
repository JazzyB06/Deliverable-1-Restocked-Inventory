namespace RestockInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Restocking Tool");
            Console.WriteLine();

            Console.WriteLine("How many sodas have been sold today? 100 are in stock");
            int sodas = Convert.ToInt32(Console.ReadLine());
            int x = 100;
            int y = 60;
            Console.WriteLine("There are " + (x - y) + " sodas left");
            Console.WriteLine();


            Console.WriteLine("How many Chips have been sold today? 40 are in stock");
            int chips = Convert.ToInt32(Console.ReadLine());
            int a = 40;
            int b = 20;
            Console.WriteLine("There are " + (a - b) + " chips left");
            Console.WriteLine();

            Console.WriteLine("How much candy have been sold today? 60 are in stock");
            int candy = Convert.ToInt32(Console.ReadLine());
            int c = 60;
            int d = 20;
            Console.WriteLine("There are " + (c - d) + " candies left");
            Console.WriteLine();

            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
            Console.WriteLine();

            if (sodas <= 40)
            {
                Console.WriteLine((x - y) + " sodas needs to be restocked");
                Console.WriteLine();
            }
            if (chips <= 20)
            {
                Console.WriteLine((a - b) + " chips needs to be restocked");
                Console.WriteLine();
            }
            if (candy <= 40)
            {
                Console.WriteLine((c - d) + " candies needs to be restocked");
                Console.WriteLine();
            }

            if (candy >= 30)
            {
                Console.WriteLine((c - d) + " That value is too high. Stock not adjusted ");
                Console.WriteLine();
            }

            if (chips >= 10)
            {
                Console.WriteLine((a - b) + " That value is too high. Stock not adjusted");
                Console.WriteLine();
            }
            if (sodas >= 20)
            {
                Console.WriteLine((x - y) + " That value is too high. Stock not adjusted");
                Console.WriteLine();
            }


        }
    }
}
