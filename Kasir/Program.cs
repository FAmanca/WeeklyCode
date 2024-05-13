using System;
using System.Diagnostics;

DateTime dt = DateTime.Now;
string sistem_operasi = Environment.OSVersion.Platform.ToString();

void res()
{
    switch (sistem_operasi)
    {
        case "Unix":
            Console.Clear();
            break;
        case "Win32NT":
            Console.Clear();
            break;
        default:
            break;
    }
}

void menu()
{
    Console.WriteLine("======================================");
    Console.WriteLine("              RakuenMilk              ");
    Console.WriteLine("======================================");
    Console.WriteLine("List Menu");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("A . SD (Susu Dingin) : Rp. 6000");
    Console.WriteLine("B . SMP (Susu Murni Panas) : Rp. 5000");
    Console.WriteLine("C . SMA (Susu Madu Anget) : Rp. 10000");
    Console.WriteLine("D . SMK (Susu Murni Kocok) : Rp. 13000");
    Console.WriteLine("EX. TAMPILKAN MENU KHUSUS :v");
    Console.WriteLine("======================================");
}

void ms()
{
    Console.WriteLine("======================================");
    Console.WriteLine("        The Taste From Heaven         ");
    Console.WriteLine("======================================");
    Console.WriteLine("List Menu Special");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("SM. Susu Makima : Rp. 140000");
    Console.WriteLine("SW. Susu Watame : Rp. 135000");
    Console.WriteLine("SG. Susu Ganyu : Rp. 170000");
    Console.WriteLine("SS. Susu Shenhe : Rp. 200000");
    Console.WriteLine("SN. Susu Nahida : Rp. 900000");
    Console.WriteLine("======================================");
}

void pmb(string listnama, int harga, int diskon, int ttl)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Anda beli : " + listnama);
    Console.WriteLine("Total Belanjaan Anda : = Rp." + harga);
    Console.WriteLine("Diskon Belanjaan Anda : = Rp." + diskon);
    Console.WriteLine("Total Bayar = Rp." + ttl);
    Console.WriteLine("------------------------------------");
}

res();
Console.WriteLine("======================================");
Console.WriteLine("    Selamat Datang Di RakuenMilk      ");
Console.WriteLine("======================================");
Console.Write("Masukan Nama Anda = ");
string nm = Console.ReadLine() ?? "";
Console.WriteLine("");
Console.WriteLine("Halo " + nm);
Console.WriteLine("Silahkan Pilih Pesanan Anda :D");
Console.WriteLine("======================================");
Console.WriteLine("");
Console.WriteLine("");
System.Threading.Thread.Sleep(1000);

void strk(string listnama, int jp, int harga, int diskon, int byr, int ttl, int kmb)
{
    Console.WriteLine("======================================");
    Console.WriteLine("              RakuenMilk              ");
    Console.WriteLine("======================================");
    Console.WriteLine("Tanggal Pemesanan: " + dt.ToString("yyyy-MM-dd HH:mm"));
    Console.WriteLine("Menu : " + listnama);
    Console.WriteLine("Jumlah Beli : " + jp);
    Console.WriteLine("Harga : Rp. " + harga);
    Console.WriteLine("Diskon : Rp. " + diskon);
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Dibayar : Rp. " + byr);
    Console.WriteLine("Jumlah Bayar : Rp. " + ttl);
    Console.WriteLine("kembalian : Rp. " + kmb);
    Console.WriteLine("======================================");
    Console.WriteLine("          TERIMA KASIH " + nm );
    Console.WriteLine("======================================");
}

res();
menu();
Console.Write("Masukan Pesanan Anda = ");
string psn = Console.ReadLine() ?? "";
if (psn == "EX" || psn == "ex")
{
    ms();
    Console.Write("Masukan Pesanan Anda = ");
    psn = Console.ReadLine() ?? "";
}
Console.Write("Masukan Jumlah Pesanan = ");
int jp = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("======================================");
Console.WriteLine("\n    ");

//degradasi/pengenalan
string listnama = "";
int harga = 0;
int diskon = 0;
int ttl = 0;

if (psn == "A" || psn == "a")
{
    listnama = "SD (Susu Dingin)";
    harga = (6000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "B" || psn == "b")
{
    listnama = "SMP (Susu Murni Panas)";
    harga = (5000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "C" || psn == "c")
{
    listnama = "SMA (Susu Madu Anget)";
    harga = (10000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "D" || psn == "d")
{
    listnama = "SMK (Susu Murni Kocok)";
    harga = (13000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "SM" || psn == "sm")
{
    listnama = "Susu Makima";
    harga = (140000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "SW" || psn == "sw" || psn == "Sw")
{
    listnama = "Susu Watame";
    harga = (135000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "SG" || psn == "sg" || psn == "Sg")
{
    listnama = "Susu Ganyu";
    harga = (170000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "SS" || psn == "ss" || psn == "Ss")
{
    listnama = "Susu Shenhe";
    harga = (200000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

if (psn == "SN" || psn == "sn" || psn == "Sn")
{
    listnama = "Susu Nahida";
    harga = (900000 * jp);
    if (jp >= 10)
    {
        diskon = (int)(harga * 0.1);
        ttl = (int)(harga - diskon);
    }
    else
    {
        diskon = 0;
        ttl = (int)(harga - diskon);
    }
}

pmb(listnama, harga, diskon, ttl);
Console.Write("Masukan Nominal Uang Anda = Rp.");
int byr = int.Parse(Console.ReadLine() ?? "");
int kmb = byr - ttl;

void gagal()
{
    Console.WriteLine("======================================");
    Console.WriteLine("       PEMABYARAN GAGAL COEG        ");
    Console.WriteLine("      UANG ANDA TYDAK CUKUP :V      ");
    Console.WriteLine("     DUID KAO KURENG  Rp." + (ttl - byr));
    Console.WriteLine("======================================");
}

if (byr < ttl)
{
    res();
    gagal();
    while (true)
    {
        Console.Write("apakah ingin mengulang ? Y/N = ");
        string ilp = Console.ReadLine() ?? "";
        if (ilp == "Y" || ilp == "y")
        {
            pmb(listnama, harga, diskon, ttl);
            Console.Write("Masukan Nominal Uang Anda = ");
            byr = int.Parse(Console.ReadLine() ?? "");
            kmb = byr - ttl;
            if (byr < ttl)
            {
                res();
                gagal();
            }
        }
        else if (ilp == "N" || ilp == "n")
        {
            res();
            Console.WriteLine("======================================");
            Console.WriteLine("  AOWKAOWKAOWKAWO GA MAMPU BAYAR :V   ");
            Console.WriteLine("======================================");
            break;
        }

        if (byr >= ttl)
        {
            kmb = byr - ttl;
            res();
            strk(listnama, jp, harga, diskon, byr, ttl, kmb);
            break;
        }
    }
}
else
{
    res();
    strk(listnama, jp, harga, diskon, byr, ttl, kmb);
}