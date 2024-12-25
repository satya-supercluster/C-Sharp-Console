namespace C_Sharp_Console.p3TypeConversion
{
    class Program3{
        public static void TypeConversion(){
            float f=123.45F;
            int i=(int)f; // Explicit Conversion
            float p=12376786464786874.45F;
            Int128 k= Convert.ToInt64(p); // Explicit Conversion
            System.Console.WriteLine(i);
            System.Console.WriteLine(k);
            string s="123";
            int j= int.Parse(s); // Explicit Conversion
            System.Console.WriteLine(j);
            string t="123.45hy";
            _ = float.TryParse(t, out float l); // Explicit Conversion 
            System.Console.WriteLine(l);
        }
    }
}