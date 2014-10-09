using System;
using System.Collections.Generic;
using System.Linq;

class PCCatalog
{
    public static void Main()
    {
        Components hdd = new Components("HDD", 249.99m, "SATA");
        Components graphicsCard = new Components("Graphics Card", 399.49m, "nVidia GeForce 750M");
        Components ssd = new Components("SSD", 199.99m, "128GB");
        Components ram = new Components("RAM", 189.99m, "16GB");
        Computer computer1 = new Computer("Lenovo", 2249.99m, new List<Components>() {
            hdd, graphicsCard, ssd, ram
        });
        Computer computer2 = new Computer("DELL", 1789.49m, new List<Components>() {
            ram, ssd
        });
        Computer computer3 = new Computer("ACER", 1349.99m, new List<Components>() {
            hdd, graphicsCard, ssd
        });
        Computer computer4 = new Computer("ASUS", 2349.99m, new List<Components>() {
            hdd, ssd, ram
        });

        List<Computer> computers = new List<Computer>() { computer1, computer2, computer3, computer4 };

        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
        }
    }
}
