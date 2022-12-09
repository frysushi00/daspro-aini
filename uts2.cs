//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika-A

using System;
namespace uts
{
    class noDua
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool bermain = true;
            int min = 1;
            int max = 100;
            int tebakan;
            int angkaMisteri=70;
            int tebakanPemain;
            
            while(bermain){
                tebakan = 0;
                tebakanPemain = 0;
                

                while(tebakan != angkaMisteri){
                    Console.Write("Tebak angka antara " +min+"-" +max+" : ");
                    tebakan = Convert.ToInt32(Console.ReadLine());

                    if(tebakan < angkaMisteri){
                        Console.WriteLine("Salah. Nilai terlalu rendah.");
                    }else if(tebakan > angkaMisteri){
                        Console.WriteLine("Salah.   Nilai terlalu tinggi.");
                    }
                    tebakanPemain++;
                    }

                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    break;
                  }
                }
             }
           }
