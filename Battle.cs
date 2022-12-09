//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika - A

using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("Selamat datang di game BATTLE TANK");
            Console.WriteLine("Anda menang jika berhasil menebak posisi tank tersembunyi");
            Console.WriteLine("Selamat Bermain!!");
            
            //Inisialisasi variabel
            int panjangRuang = 5;
            char tank = 't';
            char rumput = '~';
            char hit = 'X';
            char miss = 'O';
            int totalTank = 3;

            //Array 2 Dimensi untuk menempatkan Tank
            char[,] ruang = buatRuang(panjangRuang, rumput, tank, totalTank);
        
        

            //Array 2 Dimensi
             static char[,] buatRuang(int panjangRuang, char rumput, char tank, int totalTank){
                char[,] ruangan = new char[panjangRuang, panjangRuang];
                for (int baris = 0; baris < panjangRuang; baris++)
                {
                    for (int kolom = 0; kolom < panjangRuang; kolom++)
                    {
                        ruangan[baris,kolom] = rumput;
                    }
                }
                return letakkanTank(ruangan, totalTank, rumput, tank);
            }

            //Letakkan 3 Tank di dalam Array 2 Dimensi
             static char[,] letakkanTank(char[,] ruang, int totalTank, char rumput, char tank){
                int letakTank = 0;
                int panjangRuang = 5;

                while(letakTank < totalTank){
                    int[] lokasiTank = tentukanKoordinatTank(panjangRuang);
                    char posisi = ruang[lokasiTank[0], lokasiTank[1]];

                    if(posisi == rumput){
                        ruang[lokasiTank[0], lokasiTank[1]] = tank;
                        letakTank++;
                    }
                }
                return ruang;
            }
            //Menentukan posisi random koordinat tank dalam Array 2 dimensi
             static int[] tentukanKoordinatTank(int panjangRuang){
                Random rnd = new Random();
                int[] koordinat = new int[2];
                for (int i = 0; i < koordinat.Length; i++)
                {
                    koordinat[i] = rnd.Next(panjangRuang);
                }
                return koordinat;
            }

            //Print Array 2 dimensi untuk ke Console
            printRuangan(ruang, rumput, tank);

            //Print Array 2 dimensi ke console
             static void printRuangan(char[,] ruang, char rumput, char tank){

                Console.Write("  ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(i + 1 + " ");
                }
                Console.WriteLine();

                for (int baris = 0; baris < 5; baris++)
                {
                    Console.Write(baris + 1 + " ");
                    for (int kolom = 0; kolom < 5; kolom++)
                    {
                        char posisi = ruang[baris,kolom];
                        if(posisi == tank){
                            Console.Write(rumput + " ");
                        }else{
                            Console.Write(posisi + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            //Jumlah Tank Tersembunyi
            int jumlahTankTersembunyi = totalTank;

            //GamePlay
            while(jumlahTankTersembunyi > 0){
                int[] tebakKoordinat = getKoordinatPemain(panjangRuang);
                char updateTampilanRuang = verifikasiTebakanPemain(tebakKoordinat, ruang, tank, rumput, hit, miss);
                if(updateTampilanRuang == hit){
                    jumlahTankTersembunyi--;
                }
                ruang = updateRuangan(ruang, tebakKoordinat, updateTampilanRuang);
                printRuangan(ruang, rumput, tank);
            }
            Console.WriteLine("Game Over!!");
            Console.WriteLine("Thanks For Playing, GoodBye...");
            Console.Read();

            //Tebakan pemain
             static int[] getKoordinatPemain(int panjangRuang){
                int baris;
                int kolom;

                do{
                    Console.Write("Pilih Baris : ");
                    baris = Convert.ToInt32(Console.ReadLine());
                }while(baris<0 || baris > panjangRuang + 1);

                do{
                    Console.Write("Pilih Kolom : ");
                    kolom = Convert.ToInt32(Console.ReadLine());
                }while(kolom<0 || kolom > panjangRuang + 1);

                return new[]{baris-1, kolom-1};
            }

            //Cek Validasi tebakan pemain
             static char verifikasiTebakanPemain(int [] tebakKoordinat, char[,] ruang, char tank, char rumput, char hit, char miss){
                string pesan;
                int baris = tebakKoordinat[0];
                int kolom = tebakKoordinat[1];
                char target = ruang[baris, kolom];

                if(target == tank){
                    pesan = "BOOM YOU HIT!!";
                    target = hit;
                }else if(target == rumput){
                    pesan = "SORRY YOU MISS!!";
                    target = miss;
                }else{
                    pesan = "CLEAR!!";
                }

                Console.WriteLine(pesan);
                Console.WriteLine("  ");
                return target;
            }

            //Update Tampilan Array 2 dimensi berdasarkan tebakan pemain
             static char[,] updateRuangan(char[,] ruang, int[] tebakKoordinat, char updateTampilanRuang){

                int baris = tebakKoordinat[0];
                int kolom = tebakKoordinat[1];
                ruang[baris,kolom] = updateTampilanRuang;
                return ruang;
            }
        }
    }
}