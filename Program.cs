using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
        static Produk prod = new Produk();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

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
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            prod = new Produk();
            Console.Write("Kode Produk: ");
            prod.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk: ");
            prod.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli: ");
            prod.HargaBeli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual: ");
            prod.HargaJual = Convert.ToInt32(Console.ReadLine());

            daftarProduk.Add(prod);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk: ");
            string kodep = Console.ReadLine();

            var itemRemove = daftarProduk.SingleOrDefault(f => f.KodeProduk == kodep);

            if (itemRemove == null)
            {
                Console.WriteLine("Kode Produk tidak ditemukan");
            }
            else 
            {
                daftarProduk.Remove(itemRemove);
                Console.WriteLine();
                Console.WriteLine("Data Produk berhasil dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            
            int noUrut = 1;
            Console.WriteLine("Data Produk\n");

            foreach (Produk objProd in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, objProd.KodeProduk, objProd.NamaProduk, objProd.HargaBeli, objProd.HargaJual);
                noUrut++;
            }
            
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }

       
}
