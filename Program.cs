using System;

namespace DasPro
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            int kesempatan = 3;
            //Invoke function/method
            Intro();
            //bool bGameSelesai = PlayGame();
            while(kesempatan > 0){
                PlayGame();
                kesempatan = kesempatan - 1;
            }
        }

        static void Intro(){
            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine();
        }

        static void PlayGame(){
            //Deklarasi Variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali;

            //Buat Random Number Generator (RNG)
            Random rng = new Random();

            //Inisialiasi Variabel
            kodeA = rng.Next(1,3);
            kodeB = rng.Next(1,3);
            kodeC = rng.Next(1,3);
            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

           //Intro();
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika Ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika Dikalikan hasilnya "+hasilKali);

            //Input User
            Console.WriteLine("Masukkan kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.WriteLine("Masukkan kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan Anda : "+tebakanA+" "+tebakanB+" "+tebakanC+"?(ya/tidak)");

            //Konfirmasi
            String konfirmasi = Console.ReadLine();
            if(konfirmasi == "ya"){

            //Logic
            if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Selamat, Tebakan anda Benar...");
                //return true;
            }else{
                Console.WriteLine("Sayang sekali, Tebakan anda Salah...");
                Console.WriteLine("Kode yang benar adalah "+kodeA+" "+kodeB+" "+kodeC+".");
                //return false;
            } 
            }else{
                //PlayGame();
            } 
        }
    }
}