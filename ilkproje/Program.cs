

namespace ilkproje
{
    class ilkproje
    {
        static void Main(string[] args)
        {
           

            int tahmin = 0, tutulan, sayac = 0;
            Random rasgele = new Random();
            tutulan = rasgele.Next(1, 100);
            while (tahmin != tutulan)
            {
                Console.WriteLine(" ");
                sayac++;
                Console.Write("Sayı giriniz ");
                tahmin = rasgele.Next(1, 100);
                Console.WriteLine(tahmin);


                if (tahmin > tutulan)
                {

                    Console.WriteLine(" ");
                    Console.WriteLine("Sayıyı küçült");

                }
                else if (tahmin < tutulan)
                {

                    Console.WriteLine(" ");
                    Console.WriteLine("Sayıyı büyüt");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Tebrikler.");
            Console.WriteLine(" ");
            Console.WriteLine("{0}.hakkınızda bildiniz", sayac);
            Console.ReadKey();


        }




    }

}


