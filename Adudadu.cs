//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika S1
//Kelas : A

using System;

namespace GameAduDadu
{
    class Program
    {
        static void Main(String[] args)
        {
            Intro();
            GamePlay();
            Outro();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat datang di Game Adu Dadu");
            Console.WriteLine();
            Console.WriteLine("Pada game ini Anda dan Komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine();
            Console.WriteLine("Mulai main...");
            Console.WriteLine();
        }

        static void GamePlay()
        {
           int daduAnda;
           int daduKomputer;
           int poinAnda = 0;
           int poinKomputer = 0;
           int jumlahRonde = 0;

           Random random = new Random();
           for (int i = 0; i < 10; i++)
           {
            
            Console.ReadKey();

            jumlahRonde++;
            Console.WriteLine("Ronde: " + jumlahRonde);
            Console.WriteLine("Lempar Dadu Anda...");
            daduAnda = random.Next(1, 7);
            Console.WriteLine("Nilai Anda :" + daduAnda);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            daduKomputer = random.Next(1, 7);
            Console.WriteLine("Nilai Komputer :" + daduKomputer);
            
            

            if(daduAnda > daduKomputer)
            {
                poinAnda++;
                Console.WriteLine("Anda memenangi Ronde ini! ");
            }
            else if(daduAnda < daduKomputer)
            {
                poinKomputer++;
                Console.WriteLine("Komputer memenangi Ronde ini!");
            }
            else
            {
                Console.WriteLine("Skor Ronde ini seri!");
            }

            Console.WriteLine("Skor - Anda : " + poinAnda + " . Komputer : " + poinKomputer + ".");
            Console.WriteLine("Lanjutkan ke Ronde berikutnya...");
            Console.WriteLine();
           }

           if(poinAnda > poinKomputer)
           {
            Console.WriteLine("Selamat Anda Memenangi Game ini!");
           }
           else if(poinAnda < poinKomputer)
           {
            Console.WriteLine("Sayang sekali, Anda kalah");
            Console.WriteLine("Komputer Memenangi Game ini!");
           }
           else
           {
            Console.WriteLine("Game ini berakhir Seri!");
           }
           Console.ReadKey();
        }

        static void Outro()
        {
            Console.WriteLine("Terima Kasih telah Bermain Game Adu Dadu!");
        }
    }
}