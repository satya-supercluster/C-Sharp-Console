using System.Collections.ObjectModel;

namespace C_Sharp_Console.p4Loops
{
    class Program4{
        public static void Loops(){
            for(int i=0;i<10;i++){
                System.Console.WriteLine(i);
            }
            Collection<int> collection = [1,2,3,4,5,6,7,8,9,10];
            foreach (var item in collection)
            {
                System.Console.WriteLine(item*2);
            }
        }
    }
}