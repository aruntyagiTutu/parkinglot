namespace ParkingLotSystem
{

    public interface IParkingSpot
    {
        string GetSpotType();
    }

    public class CompactSpot : IParkingSpot
    {
        public string GetSpotType() => "Compact Spot";
    }

    public class LargeSpot : IParkingSpot
    {
        public string GetSpotType() => "Large Spot";
    }

    public class HandicappedSpot : IParkingSpot
    {
        public string GetSpotType() => "Handicapped Spot";
    }

    public class ParkingSpotFactory
    {
        public static IParkingSpot GetParkingSpot(string type)
        {
            switch (type)
            {
                case "Compact": return new CompactSpot();
                case "Large": return new LargeSpot();
                case "Handicapped": return new HandicappedSpot();
                default: throw new ArgumentException("Invalid parking spot type");
            }
        }
    }


    // Parking spot Decorator 

    public abstract class ParkingSpotDecorator : IParkingSpot
    {
        protected IParkingSpot _parkingSpot;

        public ParkingSpotDecorator(IParkingSpot parkingSpot)
        {
            _parkingSpot = parkingSpot;
        }

        public virtual string GetSpotType() => _parkingSpot.GetSpotType();
    }

    // Valet Service
    public class ValetService : ParkingSpotDecorator
    {
        public ValetService(IParkingSpot parkingSpot) : base(parkingSpot) { }

        public override string GetSpotType() => _parkingSpot.GetSpotType() + ", with Valet Service";
    }

    // Premium Parking Decorator
    public class PremiumParking : ParkingSpotDecorator
    {
        public PremiumParking(IParkingSpot parkingSpot) : base(parkingSpot) { }

        public override string GetSpotType() => _parkingSpot.GetSpotType() + ", Premium Parking";
    }

    // EV Charging Decorator
    public class EVCharging : ParkingSpotDecorator
    {
        public EVCharging(IParkingSpot parkingSpot) : base(parkingSpot) { }

        public override string GetSpotType() => _parkingSpot.GetSpotType() + ", with EV Charging";
    }

}