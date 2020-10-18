class Exc9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the temperature:");

            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("It is god damn cold!");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("It is cold!");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("It is cool!");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("It is just perfect!");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("It is getting too hot!");
            }
            else
            {
                Console.WriteLine("Stay at home and get hydrated!");
            }
        }
    }
