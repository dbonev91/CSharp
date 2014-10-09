using System;
using System.Collections.Generic;
class Components
{
    private string name;
    private decimal price;
    private string details;
    public Components( string name, decimal price, string details=null )
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
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
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            this.details = value;
            Validation.isLessThanThree(this.details);
        }
    }
    public override string ToString()
    {
        string result="";
        result += "Name: " + this.name;
        result += "\nPrice: " + this.price;
        if (this.details != null)
        {
            result += "\nDetails: " + this.details;
        }
        result += "\n";
        return result;
    }
}
