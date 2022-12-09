//Nama: Aini Nurul Amri
//NIM: 2207135967
//TI-A

using System;
using System.Collections.Generic;

namespace GameTebakKata

{
    class Program
    {
        static string kataMisteri = "INTERSTELLAR";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string>{};

        static void Main(string[] args)
        {
                Intro();
                PlayGame();
                Outro();
        }
       
        static void Intro()
        {
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak huruf-huruf penyusun kata misteri");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan judul sebuah film bergenre Sci-fi");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.WriteLine("Film apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void PlayGame()
        {
            while(kesempatan>0)
            {
                Console.Write("Apakah huruf tebakanmu? pilihlah dari (A-Z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);
                if(CekJawaban(kataMisteri, tebakanPemain)){
                    Console.WriteLine("Selamat, kata yang anda tebak benar!");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataMisteri}");
                    break;
                }else if(kataMisteri.Contains(input)){
                    Console.WriteLine("Huruf itu ada di dalam kata");
                    Console.WriteLine("Silakan tebak huruf lainnya!");
                    Console.WriteLine(Cekhuruf(kataMisteri, tebakanPemain));
                }else{
                    Console.WriteLine("Huruf tersebut tidak ada di dalam kata");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }
                
                if(kesempatan == 0)
                {
                    break;
                }
            }
        }
       
        static bool CekJawaban(string kataMisteri, List<string> list)
        {
            bool status = false;

            for (int i = 0; i < kataMisteri.Length; i++)
        {
            string c = Convert.ToString(kataMisteri[i]);
            if(list.Contains(c)){
                status = true;
            }else{
                return status = false;
            } 
        }          
        return status;
    }

    static string Cekhuruf(string kataMisteri, List<string> list){
        string x = "";

        for (int i = 0; i < kataMisteri.Length; i++)
        {
            string c = Convert.ToString(kataMisteri[i]);
            if(list.Contains(c)){
                x = x + c;
            }else{
                x = x + "_";
            }
        }
        
        return x;
    }

    static void Outro(){
        if(kesempatan == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Permainan telah berakhir");
            Console.WriteLine($"Kata misteri yang benar adalah {kataMisteri}");
            Console.WriteLine("Sekian Terima kasih sudah bermain!");
        }  
    }
  }
}