namespace ParkingLotSystem
{
    public class ParkingTicket
    {
        public string TicketNumber { get; private set; }
        public string VehiclePlate { get; private set; }
        public DateTime EntryTime { get; private set; }

        public ParkingTicket(string vehiclePlate)
        {
            TicketNumber = Guid.NewGuid().ToString().Substring(0, 8); // Unique Ticket ID
            VehiclePlate = vehiclePlate;
            EntryTime = DateTime.Now;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket: {TicketNumber}, Vehicle: {VehiclePlate}, Time: {EntryTime}");
        }
    }

    public class TicketFactory
    {
        public static ParkingTicket CreateTicket(string vehiclePlate)
        {
            return new ParkingTicket(vehiclePlate);
        }
    }
}