using System;
using System.Collections.Generic;

namespace ParkingLotSystem
{
    public class ParkingLot
    {
        private static ParkingLot _instance;
        private static readonly object _lock = new object();
        
        private int _availableSlots;

        // Private constructor to prevent direct instantiation
        private ParkingLot(int totalSlots)
        {
            _availableSlots = totalSlots;
        }

        // Singleton Instance Method
        public static ParkingLot GetInstance(int totalSlots = 10) // Default 10 slots
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ParkingLot(totalSlots);
                    }
                }
            }
            return _instance;
        }


        private List<IObserver> _observers = new List<IObserver>();
        // Observer methods
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }


        private Dictionary<string, ParkingTicket> _parkedVehicles = new();
        // Parking Methods
        public ParkingTicket ParkVehicle(IVehicle vehicle)
        {
            var ticket = new ParkingTicket(vehicle.LicensePlate);
            _parkedVehicles[vehicle.LicensePlate] = ticket;
            _availableSlots--;
            NotifyObservers($"Vehicle {vehicle.LicensePlate} parked. Available slots: {_availableSlots}");
            return ticket;
        }

        public bool UnparkVehicle(ParkingTicket ticket)
        {
            if (_parkedVehicles.Remove(ticket.VehiclePlate, out var removedTicket))
            {
                _availableSlots++;
                NotifyObservers($"Vehicle {ticket.VehiclePlate} left. Available slots: {_availableSlots}");
                return true;
            }
            return false;
        }
    }
}