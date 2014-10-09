using System;
class Validation
{
    public static void isLessThanThree(string name)
    {
        if (name.Length < 3 || name == null)
        {
            throw new ArgumentOutOfRangeException("Name must be at least three symbols!", "Name / Details");
        }
    }
    public static void isLessThanOne(Decimal price)
    {
        if(price < 1){
            throw new ArgumentOutOfRangeException("The price must be at least 1!", "Price");
        }
    }
}
