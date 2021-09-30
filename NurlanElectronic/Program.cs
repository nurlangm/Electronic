using System;

namespace ConsoleApp10
{
    class Proqram
    {
        static void Main(string[] args)
        {

            GamingNoteBook notebook = new GamingNoteBook("ASUS TUF GAMING", "Intel Core", "GeForce GTX 1650 Ti","32 GB");
            Console.WriteLine(notebook.ElectronicInfo());

            Laptop notebook2 = new Laptop("Hp Pavilion", "AMD Ryzen 5", "AMD Radeon Graphics", "8GB");
            Console.WriteLine(notebook2.ElectronicInfo());

            OfficeNoteBook notebook3 = new OfficeNoteBook("Acer Aspire", "Core i7", "Intel Iris Xe Graphics","12GB");
            Console.WriteLine(notebook3.ElectronicInfo());
        }
    }
}
