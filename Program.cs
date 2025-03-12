// See https://aka.ms/new-console-template for more information
using modul4_103022300021;

Console.Write("Masukan nama produk: ");
string inputProduk = Console.ReadLine();

if (Enum.TryParse(inputProduk,out KodeProduk.produk harga))
{
    string kodeProduk = KodeProduk.getKodeProduk(harga);
    Console.WriteLine($"Harga {inputProduk} : {kodeProduk}");
}
else
{
    Console.WriteLine($"Harga {inputProduk} : Tidak Ada!");
}
