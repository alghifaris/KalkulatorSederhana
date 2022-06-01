using System;

namespace Kalkulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }        
        
        private static bool MainMenu()
        {                 
            Console.WriteLine("Menu:");
            Console.WriteLine("1 Penambahan");
            Console.WriteLine("2 Perkurangan");
            Console.WriteLine("3 Perkalian");
            Console.WriteLine("4 Pembagian");
            Console.WriteLine("5 Pemangkatan");
            Console.WriteLine("6 Sisa Hasil Bagi");
            Console.WriteLine("7 Faktorial ");
            Console.WriteLine("8 Keluar ");
            Console.Write("\r\nPilih Menu: ");            
            decimal a,b;            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Penambahan");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka b = ");
                    b = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Hasil : {0} + {1} = {2}",a,b,Convert.ToDecimal(a + b));
                    Console.WriteLine("");
                    return true;
                case "2":
                    Console.WriteLine("Perkurangan");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka b = ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Hasil : {0} - {1} = {2}", a, b, Convert.ToDecimal(a - b));
                    Console.WriteLine("");
                    return true;
                case "3":
                    Console.WriteLine("Perkalian");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka b = ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Hasil : {0} * {1} = {2}",a,b, Convert.ToDecimal(a * b));
                    Console.WriteLine("");
                    return true;
                case "4":
                    Console.WriteLine("Pembagian");
                    Console.Write("Input Angka c = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka d = ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Hasil : {0} / {1} = {2}",a,b, Convert.ToDecimal(a / b));
                    Console.WriteLine("");
                    return true;
                case "5":
                    Console.WriteLine("Perpangkatan");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka b = ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    decimal hasil = 1;
                    string HasilString = "";
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                        if (HasilString == "")
                        {
                            HasilString = a.ToString();
                        }
                        else {
                            HasilString = HasilString + " x " + a.ToString();
                        }

                    }
                    Console.WriteLine("Hasil : {0}^{1} = {2} = {3}", a, b, HasilString,Convert.ToDecimal(hasil));
                    Console.WriteLine("");
                    return true;
                case "6":
                    Console.WriteLine("Sisa Hasil Bagi");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Input Angka b = ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Hasil : {0} % {1} = {2}", a, b, Convert.ToDecimal(a % b));
                    Console.WriteLine("");
                    return true;
                case "7":                
                    Console.WriteLine("Faktorial");
                    Console.Write("Input Angka a = ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    decimal Faktorial = 1;
                    string FaktorialString = "";
                    for (decimal i = a; i >0 ; i--)
                    {
                        Faktorial *= i;
                        if (FaktorialString == "") {
                            FaktorialString = i.ToString();
                        }
                        else
                        {
                            FaktorialString = FaktorialString + " x " + i.ToString();
                        }
                    }
                    Console.WriteLine("Hasil : {0}!= {1} = {2}", a, FaktorialString, Convert.ToDecimal(Faktorial));
                    Console.WriteLine("");
                    return true;
                case "8":
                    return false;
                default:
                    Console.WriteLine("Menu tidak ada");
                    Console.WriteLine("");
                    return true;
            }
        }

    }
}