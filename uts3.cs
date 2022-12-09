//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika-A

using System;
namespace uts{
    class noTiga
    
    {
        static void Main(string[] args){
            Intro();
        }
        static void Intro(){
                int TotalDenda = 0;

                Console.Write("Input jumlah hari peminjaman : ");
                int Haripeminjaman = Convert.ToInt32(Console.ReadLine());
                if(Haripeminjaman <= 0 && Haripeminjaman <= 5){
                    TotalDenda = 0;
                }else if(Haripeminjaman > 5 && Haripeminjaman <= 10){
                    Haripeminjaman -= 5;
                    TotalDenda = Haripeminjaman*10000;
                }else if (Haripeminjaman > 10 && Haripeminjaman <= 30){
                    Haripeminjaman -= 10;
                    TotalDenda = Haripeminjaman*20000+50000;
                }else if(Haripeminjaman>30){
                    Haripeminjaman -= 30;
                    Console.WriteLine("Keanggotaan anda dibatalkan.");
                    TotalDenda = Haripeminjaman*30000+50000+400000;
                }else{
                    
            }
            Console.WriteLine("Total Denda : Rp." + TotalDenda);
        }
    }
}
