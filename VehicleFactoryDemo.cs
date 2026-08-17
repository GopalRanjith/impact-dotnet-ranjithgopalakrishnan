using System;

public interface IFactoryVehicle
{
    void Drive();
}

public class FactoryCar : IFactoryVehicle
{
    public void Drive()
    {
        Console.WriteLine("Factory Car is driving");
    }
}

public class FactoryBike : IFactoryVehicle
{
    public void Drive()
    {
        Console.WriteLine("Factory Bike is driving");
    }
}

public class FactoryTruck : IFactoryVehicle
{
    public void Drive()
    {
        Console.WriteLine("Factory Truck is driving");
    }
}
public static class SimpleVehicleFactory
{
    public static IFactoryVehicle CreateVehicle(string type)
    {
        return type.ToLower() switch
        {
            "car" => new FactoryCar(),
            "bike" => new FactoryBike(),
            "truck" => new FactoryTruck(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}
public abstract class VehicleFactoryMethod
{
    public abstract IFactoryVehicle CreateVehicle();

    public void StartVehicle()
    {
        IFactoryVehicle vehicle = CreateVehicle();
        vehicle.Drive();
    }
}

public class FactoryCarFactory : VehicleFactoryMethod
{
    public override IFactoryVehicle CreateVehicle()
    {
        return new FactoryCar();
    }
}

public class FactoryBikeFactory : VehicleFactoryMethod
{
    public override IFactoryVehicle CreateVehicle()
    {
        return new FactoryBike();
    }
}

public class FactoryTruckFactory : VehicleFactoryMethod
{
    public override IFactoryVehicle CreateVehicle()
    {
        return new FactoryTruck();
    }
}