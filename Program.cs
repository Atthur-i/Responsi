using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.WriteLine( "Pilih Menu Aplikasi" );
                Console.WriteLine();
                Console.WriteLine( "1. Tambah Produk" );
                Console.WriteLine( "2. Hapus Produk" );
                Console.WriteLine( "3. Tampilkan Produk" );
                Console.WriteLine( "4. Keluar" );
                Console.WriteLine();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        
                        break;

                    case 2:
                        HapusProduk();
                     
                        break;

                    case 3:
                        TampilProduk();
                        
                        break;

                    case 4: // keluar dari program
                        
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Console.WriteLine( "Tambah Produk\n" );
                                Produk produk = new Produk();
                                Console.Write( "No. produk : ");
                                produk.no = Console.ReadLine();
                                Console.Write("Nama Produk : ");
                                produk.nama = Console.ReadLine();
                                Console.Write("Harga Beli : ");
                                produk.hb = Console.ReadLine();
                                Console.Write("Harga Jual : ");
                                produk.hj = Console.ReadLine();
                                daftarProduk.Add(produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Produk\n");
                        Console.Write("Nomor Produk : ");
                        string NO = Console.ReadLine();
                        foreach (Produk Produk in daftarProduk )
                        {
                            no++;
                            if (Produk.no == NO)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            daftarProduk.RemoveAt(hapus);
                            Console.WriteLine("\nProduk Berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nProduk tidak ditemukan");
                        }
                        

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int nourut = 0;
            foreach (Produk produk in daftarProduk)
            {
            nourut++;
                Console.WriteLine("{0}. No. Produk : {1}, Nama Produk : {2}, {3:N0}, Harga Jual : {4:N0} Harga Beli", nourut, produk.no, produk.nama, produk.hb, produk.hj);
            }
                        
                        if (nourut < 1)
                        {
                            Console.WriteLine("Data Produk Kosong");
                        }
                        

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
