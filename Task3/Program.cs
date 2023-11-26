using System.Xml.XPath;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 cu tapsiriq
            int num1 = 4688;
            int num2 = 6987;
            int num3 = 4682;
            int result1 = num1 * 1 / 100 - num2 * 2 / 100 - num3 * 3 / 100;
            Console.WriteLine( result1 + num3*7/100 );

            //9 cu tapsiriq
            int a = 468146;
            int b = 844620;
            int c = 864228;
            a = 468146 * 10 / 100;
            b = 844620 * 10 / 100;
            c = 864228 * 10 / 100;
            Console.WriteLine((c + a + b)*10/100);
            //8 ci tapsiriq
            int x = 4682;
            int y = 2468825;
            x = x * 4 / 100;
            y = y * 9 / 100;
            Console.WriteLine((y + x)*10/100);
            //7 ci tapsiriq sual verersen
            int eded1 = 24682;
            int eded2 = 13580;
            int h = eded1+eded2;
            h = 5382625;
            Console.WriteLine(h*5/100);
            //6 ci tapsiriq
            int k = 8624;
            k = k * 20 / 100;
            k = k * 10 / 100;
            Console.WriteLine(k*k);
            //5 cu tapsiriq
            string number = "2536";               //bu ededi ozumuzden secdik
            string result = "4" + number + "44";                   //bu ededin evveline 4 elave etdik ve sonuna 44 elave etdik.
            int yekun_netice = int.Parse(result);      //alinan neticeni string tipinde int.Parse metodu ile int tipine cevirdik.
            int faiz_tap = yekun_netice * 44 / 100;         //alinan neticenin(result) 44 faizinin tapilmasi
            Console.WriteLine(faiz_tap);
            // int.Parse() ile string tipinden int tipine kecirik
            //2 ci usul
            int number2 = 425344 - 253;
            int result3 = 253+ number2;
            Console.WriteLine(result3);


            //4 cu tapsiriq 2 ci usul
            int num5 = 2467;
            Console.WriteLine(num5*7/100);
            //2 ci usul
            string numm = "246";
            string netice = numm + "7";
            int son = int.Parse(netice);
            Console.WriteLine(son*7/100);
            //3 cu tapsiriq
            int i = 24682;
            int sonn = i*18/100 ;
            Console.WriteLine(sonn *3/100);
            //2 ci tapsiriq
            int number4 = 467467;
            Console.WriteLine(number4);
            //1 ci tapsiriq
            int number8 = 724688;
            Console.WriteLine(number8); 



            



          
           
            



        }
    }
}