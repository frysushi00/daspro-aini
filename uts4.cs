//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika-A

using System;
namespace uts
{
    class noEmpat
    {
        static void Main(string[] args){
        
        int skorPemain = 0;
        int skorKomputer = 0;
        int SkorSeri = 0;
        char InputPemain = ' ';
        bool pemainRunningAway = false;
        Random rnd = new Random();
        {
            while (InputPemain != 'e'){
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, [e]xit :");
                InputPemain = Convert.ToChar(Console.ReadLine());

                if (InputPemain == 'e')
                {
                    Console.Clear();
                    break;
                }

                int pilihanKomputer=rnd.Next(1, 4);
                if (InputPemain == 'b'){
                    if(pilihanKomputer == 1){
                        Console.WriteLine("Komputer memilih Batu.");
                        Console.WriteLine("Seri.");
                        SkorSeri++;
                    }else if (pilihanKomputer == 2){
                        Console.WriteLine("Komputer memilih Gunting.");
                        Console.WriteLine("Anda menang.");
                        skorPemain++;
                    }else if(pilihanKomputer == 3){
                        Console.WriteLine("Komputer memilih Kertas.");
                        Console.WriteLine("Komputer Menang.");
                        skorKomputer++;
                    }
                }

                else if (InputPemain == 'g'){
                    if (pilihanKomputer == 1){
                        Console.WriteLine("Komputer memilih Batu.");
                        Console.WriteLine("Anda Kalah.");
                        skorKomputer++;
                    }else if (pilihanKomputer == 2){
                        Console.WriteLine("Komputer memilih Gunting.");
                        Console.WriteLine("Seri.");
                        SkorSeri++;
                    }else if(pilihanKomputer == 3){
                        Console.WriteLine("Komputer memilih Kertas.");
                        Console.WriteLine("Anda Menang.");
                        skorPemain++;
                    }
                }

                else if (InputPemain == 'k'){
                    if (pilihanKomputer == 1){
                        Console.WriteLine("Komputer memilih Batu.");
                        Console.WriteLine("Anda Menang.");
                        skorPemain++;
                    }else if (pilihanKomputer == 2){
                        Console.WriteLine("Komputer memilih Gunting.");
                        Console.WriteLine("Anda Kalah.");
                        skorKomputer++;
                    }else if(pilihanKomputer == 3){
                        Console.WriteLine("Komputer memilih Kertas.");
                        Console.WriteLine("Seri.");
                        SkorSeri++;
                    }
                }
                Console.WriteLine("Skor: " +skorPemain+ " menang," +skorKomputer+ " Kalah," +SkorSeri+" Seri");
                Console.WriteLine("Tekan Enter untuk melanjutkan permainan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
 }
}
  
