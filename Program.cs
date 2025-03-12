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


Console.WriteLine("\n");

FanLaptop mode = new FanLaptop();

while (true)
{
    Console.Write("Masukan Mode Fan (Quiet, Balance, Performance, Turbo / Keluar) : ");
    string command = Console.ReadLine();

    if (command == "Quiet")
    {
        mode.modeQuiet();
    }
    else if (command == "Balanced")
    {
        mode.modeBalance();
    }
    else if (command == "Performance")
    {
        mode.modePerformance();
    }
    else if (command == "Turbo")
    {
        mode.modeTurbo();
    }
    else if (command == "Keluar")
    {
        break;
    }
    else
    {
        Console.WriteLine("Pilih lagi");
    }

}
