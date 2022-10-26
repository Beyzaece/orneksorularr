using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)

        {
            //Uygulama1
            Console.WriteLine("Uygulama 1..");
            int s1 = 48 / 6 / 4;
            int s2 = 24 / 3 * 2;
            int s3 = 2 ^ 2 + 5 - 1 + 4;
            int s4 = (7 + 4) * 2 - 1 + 8 / 2;
            double s5 = (5 - 1) * 2 - 1 + 7 ^ 2 / 2;

            Console.WriteLine("s1: "+s1);
            Console.WriteLine("s2: " + s2);
            Console.WriteLine("s3: " + s3);
            Console.WriteLine("s4: " + s4);
            Console.WriteLine("s5: " + s5);

            Console.WriteLine("--------------------------------------------------------");
            //Uygulama2
            Console.WriteLine("Uygulama 2..");
            int x = 20, y = 13, z = 42;
            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);
            Console.WriteLine(23 >= 23 && 45 != 18);
            Console.WriteLine(x > y && z == y && z < x);
            Console.WriteLine(z > x && y < x);
            Console.WriteLine(x != z || y <= z);
            Console.WriteLine("--------------------------------------------------------");
            //Uygulama3
            Console.WriteLine("Uygulama 3..");
            Console.WriteLine("1.sayıyı giriniz: ");
            int K = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz: ");
            int e = Convert.ToInt16(Console.ReadLine());
            if (K > e)
            {
                if (K % e == 0)
                {
                    Console.WriteLine(K + " Sayısı " + e + " Sayısına Tam Bölünüyor.");

                }
                else
                {
                    Console.WriteLine("Girilen Sayılar Birbirine Tam Bölünemez.");


                }
            }
            else
            {
                if (e % K == 0)
                {
                    Console.WriteLine(e + " Sayısı " + K + " Sayısına Tam Bölünüyor.");

                }
                else
                {
                    Console.WriteLine("Girilen Sayılar Birbine Tam Bölünemez.");
                }
            }
            Console.WriteLine("----------------------------------------------------------");
            //Uygulama4
            Console.WriteLine("Uygulama 4..");
            Console.WriteLine("gg.aa.yy formatında tarih giriniz ");
           
            int gg = Convert.ToInt16(Console.ReadLine());
            int aa = Convert.ToInt16(Console.ReadLine());
            int yy = Convert.ToInt16(Console.ReadLine());
            if(aa<1 || aa > 12)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " Girilen tarih doğru bir tarih değil");
                 
            }
            else if(aa == 1)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " ocak ayında bulunuyorsunuz.");
            }else if(aa==2){
                Console.WriteLine(gg + "." + aa + "." + yy + " şubat ayında bulunuyorsunuz.");


            }
            else if (aa == 3)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " mart ayında bulunuyorsunuz.");

            }
            else if (aa == 4)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " nisan ayında bulunuyorsunuz.");
            }
            else if (aa == 5)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " mayıs ayında bulunuyorsunuz.");
            }
            else if (aa == 6)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " haziran ayında bulunuyorsunuz.");
            }
            else if (aa == 7)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " temmuz ayında bulunuyorsunuz.");
            }
            else if(aa==7)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " ağustos ayında bulunuyorsunuz.");
            }
            else if(aa==8)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " eylül ayında bulunuyorsunuz.");
            }
            else if (aa == 9)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " ekim ayında bulunuyorsunuz.");
            }
            else if (aa == 10)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " kasım ayında bulunuyorsunuz.");
            }
            else if (aa == 11)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " aralık ayında bulunuyorsunuz.");
            }
            else if (aa == 12)
            {
                Console.WriteLine(gg + "." + aa + "." + yy + " kasım ayında bulunuyorsunuz.");
            }
            Console.WriteLine("-------------------------------------------------------------");
            //uygulama 5
            Console.WriteLine("Uygulama 5..");
            Console.Write("A Değerini Giriniz = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B Değerini Giriniz = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C Değerini Giriniz = ");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = (b* b) - (4 * a * c);
            if (d > 0)
            {
                double k1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double k2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Denklemin İki Kökü Vardır = ");
                Console.WriteLine("k1 =" + k1);
                Console.WriteLine("k2 =" + k2);
            }
            else if (d == 0)
            {
                double k = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                Console.WriteLine("k =" + k);
            }
            else
            {
                Console.WriteLine("Sanal Kök Vardır");
            }


            Console.WriteLine("-------------------------------------------------------------");
            //uygulama6 
            Console.WriteLine("Ugulama 6...");
            int derece, r, g;
            double pi = 3.13;
            Console.WriteLine("Lütfen açıyı giriniz: ");
            derece = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(d * pi / 180);
            g = derece * 200 / 180;
            Console.WriteLine("Radyan: " + r);
            Console.WriteLine("Grad: " + g);
            Console.ReadKey();
            

            
}



        }
    }

