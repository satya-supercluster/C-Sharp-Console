namespace C_Sharp_Console.p2Conditions
{
    class Program2
    {
        public static void Condition()
        {
            System.Console.Write("Enter a number between 1 and 10: ");
            string? input = System.Console.ReadLine(); // Nullable Reference Type
            if(input!=null && input.Length>0)
            {
                int number = int.Parse(input?? "0"); // Null Coalescing Operator
                int sum=0;
                for (int i = 1; i <= number; i++)
                {
                    for(int j = 1; j <= 10; j++)
                    {
                        sum+=i*j;
                        System.Console.Write(sum+" ");
                    }
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("No input received");
            }
        }
        
    }
}