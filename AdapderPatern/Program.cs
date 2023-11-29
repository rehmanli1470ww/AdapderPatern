
interface Enegery 
{
    public void ChargingTypeC();
}

class Samsung : Enegery
{
    public void ChargingTypeC()
    {
        Console.WriteLine("charging...");
    }
}

class Redmi : Enegery
{
    public void ChargingTypeC()
    {
        Console.WriteLine("charging...");
       
    }
}

class Ipone
{
    public void ChargingUsb_c()
    {
        Console.WriteLine("charging...");

    }
}


class IponeAdapder : Ipone, Enegery
{
    public void ChargingTypeC()
    {
        ChargingUsb_c();
    }
}


