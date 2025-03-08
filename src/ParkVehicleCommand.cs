
namespace ParkingLotSystem
{
public interface ICommand
{
    void Execute();
    void Undo();
}

public class ParkVehicleCommand : ICommand
{
    private ParkingLot _parkingLot;
    private IVehicle _vehicle;
    private ParkingTicket _ticket;

    public ParkVehicleCommand(ParkingLot parkingLot, IVehicle vehicle)
    {
        _parkingLot = parkingLot;
        _vehicle = vehicle;
    }

    public void Execute()
    {
        _ticket = _parkingLot.ParkVehicle(_vehicle);
        Console.WriteLine($"Vehicle {_vehicle.LicensePlate} parked with Ticket ID: {_ticket.TicketNumber}");
    }

    public void Undo()
    {
        if (_ticket != null)
        {
            _parkingLot.UnparkVehicle(_ticket);
            Console.WriteLine($"Undo: Vehicle {_vehicle.LicensePlate} unparked.");
        }
    }
}


}
