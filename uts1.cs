//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika-A


using System;
namespace uts
{
    class noSatu
    {
        static void Main(string[] args){
            string nama;
            string nim;
            string konsentrasi;

            Console.WriteLine("Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("NIM : ");
            nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|******************************|");
            Console.WriteLine("{0,-15} {1,16}", "|Nama: ", nama+"|");
            Console.WriteLine("{0,-10} {1,21}", "|", nim+"|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("{0,-3} {1,28}", "|", konsentrasi+"|");
            Console.WriteLine("|******************************|");
        }
    }
}