using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Computer
{
    private string name;
    private decimal price;
    private List<Components> details = new List<Components>();
    private decimal fullPrice;
    public Computer(string name, decimal price, List<Components> details = null)
    {
        this.Name = name;
        this.Price = price;
        if (details != null)
        {
            this.Details = details;
        }
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
            Validation.isLessThanThree(this.name);
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
            Validation.isLessThanOne(this.price);
        }
    }
    public List<Components> Details
    {
        get
        {
            return this.details;
        }
        set
        {
            foreach (Components detail in value)
            {
                if(detail != null){
                    this.details.Add(detail);
                    Validation.isLessThanThree(detail.ToString());
                }
            }
        }
    }
    public override string ToString()
    {
        this.fullPrice += this.price;
        string result = "Name: " + this.name;
        result += "\nPrice: " + this.price;
        result += "\n\nComponents:\n";
        foreach (Components detail in this.details)
        {
            this.fullPrice += detail.Price;
            result += "\n" + detail.Name;
            result += "\n" + detail.Price;
            if(detail.Details != null){
                result += "\n" + detail.Details + "\n";
            }
        }
        result += "\nFull Price: " + this.fullPrice + "\n\n";
        return result;
    }
}
