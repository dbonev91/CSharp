using System;
using System.Text;

class Battery
{
    private string battery;
    private string batteryLife;

    public Battery(string battery="", string batteryLife="")
    {
        this.BatterySetter = battery;
        this.BatteryLife = batteryLife;
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        if(this.BatterySetter != ""){
            result.AppendLine("Battery: " + this.BatterySetter);
        }
        if(this.BatteryLife != ""){
            result.AppendLine("BatteryLife: " + this.BatteryLife);
        }
        return result.ToString();
    }
    public string BatterySetter{
        get{
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public string BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            this.batteryLife = value;
        }
    }
}
