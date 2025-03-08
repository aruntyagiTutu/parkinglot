namespace ParkingLotSystem
{
    public interface IVehicle
    {
        string GetVehicleType();
        string LicensePlate { get; }
    }


    public class Car : IVehicle
    {
        public string LicensePlate { get; private set; }

        public Car(string plate) => LicensePlate = plate;

        public string GetVehicleType() => "Car";
    }

    public class Bike : IVehicle
    {
        public string LicensePlate { get; private set; }

        public Bike(string plate) => LicensePlate = plate;

        public string GetVehicleType() => "Bike";
    }

    public class Truck : IVehicle
    {
        public string LicensePlate { get; private set; }

        public Truck(string plate) => LicensePlate = plate;

        public string GetVehicleType() => "Truck";
    }


    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type, string plate)
        {
            switch (type)
            {
                case "Car": return new Car(plate);
                case "Bike": return new Bike(plate);
                case "Truck": return new Truck(plate);
                default: throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

}