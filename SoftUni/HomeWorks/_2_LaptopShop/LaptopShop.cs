using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LaptopShop
{
    private string model;
    private decimal price;
    private string manufacturer;
    private string processor;
    private string RAM;
    private string graphicsCard;
    private string HDD;
    private string screen;
    public LaptopShop(string model, decimal price, string manufacturer = "", string processor = "", string RAM = "", string graphicsCard = "",
        string HDD = "", string screen = "")
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = RAM;
        this.GraphicsCard = graphicsCard;
        this.Hdd = HDD;
        this.Screen = screen;
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("Model: " + this.Model);
        result.AppendLine("Price: " + this.Price + "lv");
        if(this.Manufacturer != ""){
            result.AppendLine("Manufacturer: " + this.Manufacturer);
        }
        if (this.Processor != "")
        {
            result.AppendLine("Processor: " + this.Processor);
        }
        if (this.Ram != "")
        {
            result.AppendLine("Ram: " + this.Ram);
        }
        if (this.GraphicsCard != "")
        {
            result.AppendLine("Graphics Card: " + this.GraphicsCard);
        }
        if (this.Hdd != "")
        {
            result.AppendLine("Hdd: " + this.Hdd);
        }
        if (this.Screen != "")
        {
            result.AppendLine("Screen: " + this.Screen);
        }
        return result.ToString();
    }
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
            if (this.model == null || this.model.Length < 3)
            {
                throw new ArgumentOutOfRangeException("model must be minimum 3 charachters and can't be null!");
            }
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
            if(this.price < 1){
                throw new ArgumentOutOfRangeException("Price must be al least 1");
            }
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }
    public string Ram
    {
        get
        {
            return this.RAM;
        }
        set
        {
            this.RAM = value;
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }
    public string Hdd
    {
        get
        {
            return this.HDD;
        }
        set
        {
            this.HDD = value;
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            this.screen = value;
        }
    }
    static void Main()
    {
        LaptopShop LS = new LaptopShop("Lenovo", 2300);
        Battery batteryInstance = new Battery("Li-Ion, 4-cells, 2550 mAh", "4.5 hours");
        Console.WriteLine(LS.ToString());
        Console.WriteLine(batteryInstance.ToString());
        LaptopShop LS2 = new LaptopShop("DELL", 1850, "DELL Alienware");
        Battery batteryInstance2 = new Battery("Li-Ion, 4-cells, 2550 mAh");
        Console.WriteLine(LS2.ToString());
        Console.WriteLine(batteryInstance2.ToString());
        LaptopShop LS3 = new LaptopShop("ACER", 2440, "", "", "16GB");
        Battery batteryInstance3 = new Battery("", "3 hours");
        Console.WriteLine(LS3.ToString());
        Console.WriteLine(batteryInstance3.ToString());
        LaptopShop LS4 = new LaptopShop("ASUS", 890, "ASUS", "8 qdra", "8RAM", "nVidia GeForce750", "1TB + 128GB SSD", "15.6\"");
        Battery batteryInstance4 = new Battery("Li-Ion, 4-cells, 2550 mAh", "2 hours");
        Console.WriteLine(LS4.ToString());
        Console.WriteLine(batteryInstance4.ToString());
    }
}
