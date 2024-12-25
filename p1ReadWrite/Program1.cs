namespace C_Sharp_Console.p1ReadWrite
{
    public class Program1
    {
        public static void ReadWrite(){
            System.Console.Write("Hello, World!\nPlease enter your name: ");
            string? name = System.Console.ReadLine();
            System.Console.WriteLine($"Hello, {name}!\nNice to meet you!");
            System.Console.Write("Enter a number between 1 and 10: ");
            string? input = System.Console.ReadLine();
            int number = int.Parse(input?? "0");
            for (int i = 1; i <= number; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    System.Console.Write(i*j+" ");
                }
                System.Console.WriteLine();
            }

        }
    }
}