using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("mehmet can");
            isimler.Add("hasan hüseyin");
            Console.WriteLine(isimler.Lenght);

            
        }
    }
}
